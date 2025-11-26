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
    public partial class BAI8 : Form
    {
        public BAI8()
        {
            InitializeComponent();
        }

        private void createNode()
        {
            TreeNode ds = new TreeNode();
            ds.Text = "Danh Sách Sinh Viên";

            TreeNode lopa = new TreeNode();
            lopa.Text = "Lớp A";

            TreeNode lopb = new TreeNode();
            lopb.Text = "Lớp B";

            TreeNode lopc = new TreeNode();
            lopc.Text = "Lớp C";

            ds.Nodes.Clear();
            ds.Nodes.Add(lopa);
            ds.Nodes.Add(lopb);
            ds.Nodes.Add(lopc);
            trvchienpa.Nodes.Add(ds);
        }

        private void pnchienpa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BAI8_Load(object sender, EventArgs e)
        {
            createNode();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < trvchienpa.Nodes.Count; i++)
            {
                TreeNode node = trvchienpa.Nodes[i];
                for (int j = 0; j < node.Nodes.Count; j++)
                {
                    if (node.Nodes[j].IsSelected == true)
                    {
                        
                        node.Nodes[j].Nodes.Add(txtma.Text + " - " + txthoten.Text);
                        TreeNode NewNode = new TreeNode();
                        NewNode.Text = txtdiachi.Text;
                        node.Nodes[j].Nodes[0].Nodes.Add(NewNode);

                        // node.Nodes[j].Nodes.Count - 1 lấy node vừa thêm


                    }

                }
            }
        }

        private void trvchienpa_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trvchienpa_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            

        }

        private void trvchienpa_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.Parent != null && node.Nodes.Count > 0)
            {
                string[] arr = node.Text.Split('-');
                txtma.Text = arr[0].Trim();
                txthoten.Text = arr[1].Trim();
                txtdiachi.Text = node.Nodes[0].Text;
            }
            if (node.Parent != null && node.Nodes.Count == 0)
            {
                string[] arr = node.Text.Split('-');
                txtma.Text = arr[0].Trim();
                txthoten.Text = arr[1].Trim();
                txtdiachi.Text = node.Text;
            }
        }
    }
}
