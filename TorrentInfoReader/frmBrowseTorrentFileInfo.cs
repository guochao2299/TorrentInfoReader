using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BencodeNET.Objects;
using BencodeNET.Parsing;
using BencodeNET.Torrents;

namespace TorrentInfoReader
{
    public partial class frmBrowseTorrentFileInfo : Form
    {
        public frmBrowseTorrentFileInfo()
        {
            InitializeComponent();
        }

        public frmBrowseTorrentFileInfo(Torrent torrentFileInfo)
        {
            InitializeComponent();
            btnBrowseAndParse.Visible = false;
            ConstructFileTree(torrentFileInfo);
        }

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

            Torrent infoTorr = new BencodeParser().Parse<Torrent>(ofd.FileName);
            ConstructFileTree(infoTorr);
            //var data = TorrentParser.DecodeFile(ofd.FileName);
            //txtResult.Text = string.Empty;
            //ShowData(data);
        }

        private TreeNode FindNode(TreeNode tnParent, string nodeName)
        {
            if (tnParent.Nodes[nodeName] == null)
            {
                TreeNode tnNew = new TreeNode(nodeName);
                tnNew.Name = nodeName;
                tnParent.Nodes.Add(tnNew);
            }

            return tnParent.Nodes[nodeName];
        }

        private void ConstructFileTree(Torrent infoTor)
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("种子文件");
            treeView1.Nodes.Add(root);
            TreeNode tnNow = null;

            foreach (MultiFileInfo f in infoTor.Files)
            {
                tnNow = root;

                if (f.Path.Count > 1)
                {
                    for (int i = 0; i < f.Path.Count - 1; i++)
                    {
                        tnNow = FindNode(tnNow, f.Path[i]);
                    }
                }

                if (tnNow.Tag == null)
                {
                    tnNow.Tag = new List<string>();
                }

                (tnNow.Tag as List<string>).Add(f.Path.Last());
            }
        }

        //private void ShowData(ItemBase data)
        //{
        //    if (data.ItemType == ItemType.Dictionary)
        //    {
        //        foreach (var kv in (data as DictionaryItem).DictionaryData)
        //        {
        //            switch (kv.Value.ItemType)
        //            {
        //                case ItemType.Dictionary:
        //                    txtResult.Text += (kv.Key + ":\r\n");
        //                    ShowData(kv.Value);
        //                    break;
        //                case ItemType.List:
        //                    txtResult.Text += (kv.Key + ":\r\n");
        //                    ShowData(kv.Value);
        //                    break;
        //                case ItemType.String:
        //                    if (kv.Key == "pieces")
        //                    {
        //                        break;
        //                    }

        //                    txtResult.Text += (kv.Key + "=" + (kv.Value as StringItem).StringData + ":\r\n");
        //                    break;
        //                case ItemType.Number:

        //                    txtResult.Text += (kv.Key + "=" + (kv.Value as NumberItem).NumberData + ":\r\n");
        //                    break;
        //            }
        //        }
        //    }
        //    if (data.ItemType == ItemType.List)
        //    {
        //        foreach (var i in (data as ListItem).ListData)
        //        {
        //            switch (i.ItemType)
        //            {
        //                case ItemType.Dictionary:
        //                case ItemType.List:
        //                    ShowData(i);
        //                    break;
        //                case ItemType.String:
        //                    txtResult.Text += ((i as StringItem).StringData + ":\r\n");
        //                    break;
        //                case ItemType.Number:
        //                    txtResult.Text += ((i as NumberItem).NumberData + ":\r\n");
        //                    break;
        //            }
        //        }
        //    }
        //}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            if(e.Node.Tag!=null)
            {
                listBox1.Items.AddRange(((List<string>)e.Node.Tag).ToArray());
            }            
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
