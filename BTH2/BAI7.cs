using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH2
{
    public partial class BAI7 : Form
    {
        public BAI7()
        {
            InitializeComponent();
        }
        public void CreatNode()
        {
            TreeNode node = new TreeNode();
            node.Text = "Khoa tin học";
                TreeNode Node5a = new TreeNode();
                Node5a.Text = "THTH5A";
                      TreeNode Node5a1 = new TreeNode();
                      Node5a1.Text = "Nguyễn Văn An";
                      TreeNode Node5a2 = new TreeNode();
                      Node5a2.Text = "Trần Thị Bưởi";
                Node5a.Nodes.Add(Node5a1);
                Node5a.Nodes.Add(Node5a2);
            node.Nodes.Add(Node5a);
            trvchienpa.Nodes.Add(node);
                TreeNode Node5b = new TreeNode();
                Node5b.Text = "THTH5B";
                    TreeNode Node5b1 = new TreeNode();
                    Node5b1.Text = "Nguyễn Văn Ba";
                    TreeNode Node5b2 = new TreeNode();
                    Node5b2.Text = "Trần Thị Bò";
                Node5b.Nodes.Add(Node5b1);
                Node5b.Nodes.Add(Node5b2);
            node.Nodes.Add(Node5b);

            TreeNode node5c = new TreeNode();
            node5c.Text = "THTH5C";
                TreeNode node5c1 = new TreeNode();
                node5c1.Text = "Nguyễn Văn Cà";
                TreeNode node5c2 = new TreeNode();
                node5c2.Text = "Trần Thị Cá";
            node5c.Nodes.Add(node5c1);
            node5c.Nodes.Add(node5c2);
            node.Nodes.Add(node5c);
        }
        private void BAI7_Load(object sender, EventArgs e)
        {
                        CreatNode();
                        creatcolumn();
        }
        private void creatcolumn()
        {
            lstvchienpa.Columns.Add("colhoten", "Họ Tên");
            lstvchienpa.Columns.Add("collop", "Lớp");
            
            lstvchienpa.Columns[0].Width = 150;
            lstvchienpa.Columns[1].Width = 100;


        }
        private void lstvchienpa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < trvchienpa.Nodes.Count; i++)
            {
                TreeNode khoaNode = trvchienpa.Nodes[i];
                for (int j = 0; j < khoaNode.Nodes.Count; j++)
                {
                    TreeNode lopNode = khoaNode.Nodes[j];
                    for (int k = 0; k < lopNode.Nodes.Count; k++)
                    {
                        TreeNode svNode = lopNode.Nodes[k];
                        if (svNode.Text == txtnhapten.Text)
                        {
                            lstvchienpa.Items.Clear();
                            ListViewItem item = new ListViewItem();
                            item.Text = svNode.Text;
                            item.SubItems.Add(lopNode.Text);
                            lstvchienpa.Items.Add(item);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                }
            }
        }
    }
}
