using BencodeNET.Parsing;
using BencodeNET.Torrents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TorrentInfoReader
{
    public partial class frmTorrentFileComparison : Form
    {
        public frmTorrentFileComparison()
        {
            InitializeComponent();
        }

        private Torrent m_torrentFileInfo = null;

        private void btnBrowseAndParse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Torrent文件|*.Torrent";

            if (ofd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            txtFilePath.Text = ofd.FileName;

            try
            {
                m_torrentFileInfo = new BencodeParser().Parse<Torrent>(ofd.FileName);
                btnBrowseFileInfo.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Torrent文件解析失败，错误消息为：" + ex.Message);
            }
        }

        private void btnDeletePath_Click(object sender, EventArgs e)
        {
            for (int i = lstFindPathes.SelectedIndices.Count-1; i >=0 ; i--)
            {
                lstFindPathes.Items.RemoveAt(lstFindPathes.SelectedIndices[i]);
            }
        }

        private void btnNewPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()== DialogResult.OK)
            {
                if(lstFindPathes.Items.Contains(fbd.SelectedPath))
                {
                    lstFindPathes.SelectedItem = fbd.SelectedPath;
                }
                else
                {
                    lstFindPathes.Items.Add(fbd.SelectedPath);
                }
            }
        }

        private void cbRemovePrefix_CheckedChanged(object sender, EventArgs e)
        {
            txtRemovePrefix.Enabled = cbRemovePrefix.Checked;
        }

        private void cbRemovePostfix_CheckedChanged(object sender, EventArgs e)
        {
            txtRemovePostfix.Enabled = cbRemovePostfix.Checked;
        }

        private void DisplayResult(List<FindRecord> records,int filterOption)
        {
            dgvResults.Rows.Clear();

            IEnumerable<FindRecord> filterResult = records;
            switch(filterOption)
            {
                case 1:
                    filterResult = records.Where(r => !string.IsNullOrEmpty(r.LocaFilePath));
                    break;

                case 2:
                    filterResult = records.Where(r => string.IsNullOrEmpty(r.LocaFilePath));
                    break;
            }
            foreach (FindRecord fr in filterResult)
            {
                dgvResults.Rows.Add(new object[] { dgvResults.Rows.Count+1, fr.TorrentFileName, fr.ProcessedFileName + fr.FileExtension, fr.LocaFilePath });                
            }
        }

        private List<FindRecord> m_lstFindResults = new List<FindRecord>();

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFilePath.Text)&& !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("请选择种子文件");
                btnBrowseAndParse.Focus();
                return;
            }

            if(lstFindPathes.Items.Count<=0)
            {
                MessageBox.Show("请设置本地文件的搜索路径");
                lstFindPathes.Focus();
                return;
            }

            m_lstFindResults.Clear();

            foreach (MultiFileInfo f in m_torrentFileInfo.Files)
            {
                FindRecord fr = new FindRecord();
                fr.TorrentFileName = f.FileName;
                fr.TorrentFullPath = f.FullPath;
                fr.Index = m_lstFindResults.Count + 1;
                fr.ProcessedFileName = Path.GetFileNameWithoutExtension(fr.TorrentFileName);
                fr.FileExtension = Path.GetExtension(fr.TorrentFileName);

                if (cbRemovePrefix.Checked &&
                   !string.IsNullOrEmpty(txtRemovePrefix.Text) &&
                   fr.ProcessedFileName.StartsWith(txtRemovePrefix.Text))
                {
                    fr.ProcessedFileName = fr.ProcessedFileName.Substring(txtRemovePrefix.Text.Length);
                }

                if(cbRemovePostfix.Checked &&
                   !string.IsNullOrEmpty(txtRemovePostfix.Text) &&
                   fr.ProcessedFileName.EndsWith(txtRemovePostfix.Text))
                {
                    fr.ProcessedFileName = fr.ProcessedFileName.Substring(0, fr.ProcessedFileName.Length - txtRemovePostfix.Text.Length);
                }

                foreach(string findDir in lstFindPathes.Items)
                {
                    string[] searchResult = Directory.GetFiles(findDir, fr.ProcessedFileName + fr.FileExtension, SearchOption.AllDirectories);
                    if(searchResult==null || searchResult.Length<=0)
                    {
                        continue;
                    }

                    fr.LocaFilePath = searchResult[0];
                    break;
                }

                m_lstFindResults.Add(fr);
            }

            DisplayResult(m_lstFindResults, GetFilterOption());
        }

        private const int ALL_RECORDS = 0;
        private const int EXIST_LOCAL_FILE_RECORDS = 1;
        private const int NOT_EXIST_LOCAL_FILE_RECORDS = 2;

        private void btnBrowseFileInfo_Click(object sender, EventArgs e)
        {
            frmBrowseTorrentFileInfo form = new(m_torrentFileInfo);
            form.ShowDialog(this);
        }

        private int GetFilterOption()
        {
            if(rbAll.Checked)
            {
                return ALL_RECORDS;
            }

            if(rbExistLocalFile.Checked)
            {
                return EXIST_LOCAL_FILE_RECORDS;
            }

            if(rbNotExistLocalFile.Checked)
            {
                return NOT_EXIST_LOCAL_FILE_RECORDS;
            }

            return ALL_RECORDS;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            DisplayResult(m_lstFindResults, GetFilterOption());
        }
    }
}
