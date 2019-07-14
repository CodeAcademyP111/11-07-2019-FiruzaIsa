using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugList
{
    public partial class MainPage : Form
    {
        Pharmacy drugstore = new Pharmacy("Zeferan", "Semed Vurgun Bagi ");
        public MainPage()
        {
            InitializeComponent();
            dgvList.DataSource = drugstore.GetMedicine();
            

        }

      

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string type = txtType.Text.Trim();
            string name = txtName.Text.Trim();
            if (type == " " || name == "" || txtPrice.Text == null)
            {
                MessageBox.Show("Please enter the type,name or price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price = Convert.ToDouble(txtPrice.Text);
            txtPrice.Text = price.ToString();


            Drug drug = new Drug { Type = type, Name = name, Price = price };
            drugstore.AddDrug(drug);
            dgvList.DataSource = null;
            dgvList.DataSource = drugstore.GetMedicine();

            txtType.Text = null;
            txtName.Text = null;
            txtPrice.Text = null;







        }
        private int id = 0;
        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          int choosen=(int)dgvList.Rows[e.RowIndex].Cells[0].Value;
            id = choosen;
            Drug drug = drugstore.PressDrug(id);
            txtType.Text = drug.Type;
            txtName.Text = drug.Name;
            txtPrice.Text = drug.Price.ToString();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string type = txtType.Text.Trim();
            string name = txtName.Text.Trim();
            if (type == " " || name == "" || txtPrice.Text == null)
            {
                MessageBox.Show("Please enter the type,name or price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price = Convert.ToDouble(txtPrice.Text);
            txtPrice.Text = price.ToString();

            drugstore.UpdateDrug(id, type, name, price);
            dgvList.DataSource = null;
            dgvList.DataSource = drugstore.GetMedicine();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
            //drugstore.DeleteID(id);
            //dgvList.DataSource = null;
            //dgvList.DataSource = drugstore.GetMedicine();


        }
    }
}
