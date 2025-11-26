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
    public partial class BAI3 : Form
    {
        public BAI3()
        {
            InitializeComponent();
        }

        private void chienpaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ImageList imageListIcons = new ImageList();                 // Khởi tạo ImageList



        private void BAI3_Load(object sender, EventArgs e)
        {
            imageListIcons.ImageSize = new Size(24, 24); // kích thước icon

            // Example: Add an actual Image to the ImageList (replace with your own image)
            // imageListIcons.Images.Add("collastname", Image.FromFile("path_to_image.png"));

            // Remove the incorrect indexing usage:
            // imageListIcons.Images.Add("collastname", imageListIcons[0]);
            imageListIcons.Images.Add("collastname", Image.FromFile("C:\\Users\\PC ACER\\OneDrive\\Pictures\\Saved Pictures\\avt.jpg"));/////
            lstvchienpa.SmallImageList = imageListIcons;///////



            lstvchienpa.Columns.Add("collastname", "LastName");
            lstvchienpa.Columns.Add("colfirstname", "FirstName");
            lstvchienpa.Columns.Add("colphone", "Phone");


            lstvchienpa.Columns[0].Width = 150;
            lstvchienpa.Columns[1].Width = 150;
            lstvchienpa.Columns[2].Width = 150;

        }
        

        private void btnadd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.ImageKey = "collastname";      //

            item.Text = txtlastname.Text;
            item.SubItems.Add(txtfirstname.Text);
            item.SubItems.Add(txtphone.Text);
            lstvchienpa.Items.Add(item);

            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtphone.Text = "";
        }

        private void lstvchienpa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
