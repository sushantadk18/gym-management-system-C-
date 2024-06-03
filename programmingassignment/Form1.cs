using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingassignment
{
    public partial class BestFitness : System.Windows.Forms.Form
    {
        public BestFitness()
        {
            InitializeComponent();
           
            dgvDetails.DataSource = sc.getAllSubscription();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        String sauna, swimming;

        public void btnCalculate_Click(object sender, EventArgs e)
        {
           

        }
            int Id = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public  void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                pbimage.ImageLocation = imagePath;
                pbimage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void btncreate_Click(object sender, EventArgs e)
        {
            
            try 
            
            {
                bool rs = sc.manageSuscription(Id,
                    txtCustomerName.Text,
                    txtAddress.Text,
                    txtContact.Text,
                    cbList.Text,
                    Double.Parse(txtcurrentweight.Text),
                    Double.Parse(txttargetweight.Text),
                    int.Parse(numPrivateHours.Text),
                    sauna,
                    swimming,
                    Double.Parse(txtCost.Text),
                    1);
                if (rs == true)
                {
                    MessageBox.Show("Information SuccessFully Saved");
                    dgvDetails.DataSource = sc.getAllSubscription();
                    clear();

                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        Database.suscription sc = new Database.suscription();

        private void btnSearch_Click(object sender, EventArgs e)
        {
           dgvDetails.DataSource=sc.SearchSubscription(txtSearchCustomer.Text);
            
        }

        private void rdbsaunayes_CheckedChanged(object sender, EventArgs e)
        {
            sauna = "Yes";
        }

        private void rdbsaunano_CheckedChanged(object sender, EventArgs e)
        {
            sauna = "No";

        }

        private void rdbswimingyes_CheckedChanged(object sender, EventArgs e)
        {
            swimming = "Yes";
        }
        private void rdbswimmingno_CheckedChanged(object sender, EventArgs e)
        {
            swimming = "No";
        }



        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dgvDetails.SelectedRows[0].Cells["Id"].Value.ToString());
            txtCustomerName.Text = dgvDetails.SelectedRows[0].Cells["CustomerName"].Value.ToString();   
            txtAddress.Text= dgvDetails.SelectedRows[0].Cells["Address"].Value.ToString();
            txtContact.Text= dgvDetails.SelectedRows[0].Cells["contact"].Value.ToString();
            cbList.Text= dgvDetails.SelectedRows[0].Cells["trainingplan"].Value.ToString();
            txtcurrentweight.Text= dgvDetails.SelectedRows[0].Cells["currentweight"].Value.ToString();
            txttargetweight.Text= dgvDetails.SelectedRows[0].Cells["targetweight"].Value.ToString();
            numPrivateHours.Text= dgvDetails.SelectedRows[0].Cells["privatetraining"].Value.ToString();
            sauna= dgvDetails.SelectedRows[0].Cells["sauna"].Value.ToString();
            swimming= dgvDetails.SelectedRows[0].Cells["swimming"].Value.ToString();
            txtCost.Text= dgvDetails.SelectedRows[0].Cells["Cost"].Value.ToString();
            if (sauna == "Yes")
            {
                rdbsaunayes.Checked= true;
            }
            else
            {
                rdbsaunano.Checked= true;
            }
            if (swimming == "Yes")
            {
                rdbswimingyes.Checked= true;
            }
            else
            {
                rdbswimmingno.Checked= true;
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            {

                try

                {
                    bool rs = sc.manageSuscription(Id,
                        txtCustomerName.Text,
                        txtAddress.Text,
                        txtContact.Text,
                        cbList.Text,
                        Double.Parse(txtcurrentweight.Text),
                        Double.Parse(txttargetweight.Text),
                        int.Parse(numPrivateHours.Text),
                        sauna,
                        swimming,
                        Double.Parse(txtCost.Text),
                        2);
                    if (rs == true)
                    {
                        MessageBox.Show("Information Updated SuccessFully ");
                        dgvDetails.DataSource = sc.getAllSubscription();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error in performing the required operation!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            {

                try

                {
                    bool rs = sc.manageSuscription(Id,
                        txtCustomerName.Text,
                        txtAddress.Text,
                        txtContact.Text,
                        cbList.Text,
                        Double.Parse(txtcurrentweight.Text),
                        Double.Parse(txttargetweight.Text),
                        int.Parse(numPrivateHours.Text),
                        sauna,
                        swimming,
                        Double.Parse(txtCost.Text),
                        3);
                    if (rs == true)
                    {
                        MessageBox.Show("Information Deleted SuccessFully");
                        dgvDetails.DataSource = sc.getAllSubscription();
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Error in performing the required operation!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = sc.searchwithCustomerName(txtSearchCustomer.Text);

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            double targetweight = double.Parse(txttargetweight.Text);
            double currentweight = double.Parse(txtcurrentweight.Text);

           // double serialnumber = 0;
            double totalcost = 0;
            double price = 0;
            double extracost = 0;
            string list1 = cbList.Text;
            double pthours = (double)numPrivateHours.Value;

            // string Swimmingincluded = "No";
            // string Saunaincluded = "No";

            if (list1.Equals("Beginner"))
            {
                price = 1000;
            }
            else if (list1.Equals("Intermediate"))
            {
                price = 2000;
            }
            else if (list1.Equals("Elite"))
            {
                price = 3000;
            }
            else
            {
                MessageBox.Show("Please select a membership level.");
                return;
            }
            {
                if (rdbsaunayes.Checked || rdbsaunano.Checked)
                {
                    if (rdbsaunayes.Checked)
                    {
                        extracost += 1500;
                        sauna = "Yes";
                    }
                    else
                    {
                        sauna = "No";
                    }
                }
                else
                {
                    MessageBox.Show("Please select one sauna option.");
                    return;
                }

                if (rdbswimingyes.Checked || rdbswimmingno.Checked)
                {
                    if (rdbswimingyes.Checked)
                    {
                        extracost += 500;
                        swimming = "Yes";
                    }
                    else
                    {
                        swimming = "No";
                    }
                }
                else
                {
                    MessageBox.Show("Please select one swimming option.");
                    return;
                }

            }


            extracost = extracost + (pthours * 500);
            totalcost = price + extracost;
            double finalcost = totalcost;
            lblfinalcost.Text = finalcost.ToString();
            txtCost.Text = totalcost.ToString();
            double cmprwt = targetweight - currentweight;
            string compareweight = $"you need to gain {cmprwt} kg more.";

            //    serialnumber=serialnumber + 1;
            //    //dgvDetails.Rows.Add(serialnumber,
            //    //   name, address, contact, list1, Swimmingincluded, Saunaincluded, totalcost, compareweight);





        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            cbList.SelectedIndex = -1;
            txtcurrentweight.Clear();
            txttargetweight.Clear();
            numPrivateHours.ResetText();
            rdbswimmingno.Checked = false;
            rdbswimingyes.Checked = false;
            rdbsaunayes.Checked = false;
            rdbsaunano.Checked = false;
                        txtCost.Clear() ;
            lblfinalcost.Text = "";

        }

      
    }

}
