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
    public partial class BAI10 : Form
    {
        public BAI10()
        {
            InitializeComponent();
        }

        private void lblcountry_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbcountry.SelectedIndex == 0)
            {
                txtcity.Text = "Hồ chí minh" + "\r\n" + "Hà nội" + "\r\n" + "Đà nẵng";
            }
            else
            {
                txtcity.Text = "Bangkok" + "\r\n" + "Chiang Mai" + "\r\n" + "Phuket";
            }
        }

        private void BAI10_Load(object sender, EventArgs e)
        {
             cbbcountry.Items.Add("Vietnam");
            cbbcountry.Items.Add("Thai Lan");


            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "" || mastxtdate.Text ==""||txtaddress.Text == ""|| cbbcountry.Text == ""||txtqualy.Text == "" || txtemail.Text == "" || txtcity.Text == ""||mastxtphone.Text == ""||dtpkchienpa.Text == "" || dtpkchienpa.Text == "")
            {
                errorProvider1.SetError(txtname, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(mastxtdate, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtaddress, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(cbbcountry, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtqualy, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtemail, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtcity, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(mastxtphone, "Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(dtpkchienpa, "Vui lòng nhập đầy đủ thông tin");


                
            }
            string message = " EMPLOYEE INFORMATION " + "\r\n" + "Name: " + txtname.Text + "\r\n" + "Date of Birth: " + mastxtdate.Text + "\r\n" + "Address: " + txtaddress.Text + "\r\n" + "Country: " + cbbcountry.Text + "\r\n" + "Qualification: " + txtqualy.Text + "\r\n" + "Email: " + txtemail.Text + "\r\n" + "City: " + txtcity.Text + "\r\n" + "Phone: " + mastxtphone.Text + "\r\n" + "Start Date: " + dtpkchienpa.Text + "\r\n" + "End Date: " + dtpkchienpa.Text;

            MessageBox.Show(message, "Employee Details");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
