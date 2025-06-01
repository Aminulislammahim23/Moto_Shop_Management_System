using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBG;

namespace Chain___Gear.Admin
{
    public partial class ProductUpdate1 : UserControl
    {
        private DataAccess Da { get; set; }

        private string selectedFilePath = string.Empty;
        public ProductUpdate1()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulateGridView();

            this.dataGridView1.ClearSelection();
            this.AutoIdGenerate();

        }

        private void PopulateGridView(string sql = "select * from Productlist")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }
        private void clearAll()
        {
            this.productNameTxt.Clear();
            this.productSerialTxt.Clear();
            this.brandNameTxt.Clear();
            this.quantityTxt.Clear();
            this.productCategoryTxt.SelectedItem = null;

            this.dataGridView1.ClearSelection();
            this.AutoIdGenerate();


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }
        private void AutoIdGenerate()
        {
            var sql = "SELECT Productserial FROM Productlist ORDER BY Productserial DESC;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int n1 = Convert.ToInt32(temp[1]);
            string newId = "p-" + (++n1).ToString("d3");
            this.productSerialTxt.Text = newId;
        }





        private void saveBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                // Check if record exists
                var sql = "SELECT * FROM Productlist WHERE Productserial = '" + this.productSerialTxt.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                string query = null;

                // Save image to folder
                string destinationFolderPath = Path.Combine(Application.StartupPath, "PDimages");
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedFilePath);
                string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                File.Copy(selectedFilePath, destinationFilePath, true);

                // Save relative path to DB (optional: you can store only the filename if needed)
                string imagePathForDb = destinationFilePath;

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // Update
                    query = "UPDATE Productlist SET " +
                            "Productserial = '" + this.productSerialTxt.Text + "', " +
                            "Productname = '" + this.productNameTxt.Text + "', " +
                            "brandname = '" + this.brandNameTxt.Text + "', " +
                            "quantity = '" + this.quantityTxt.Text + "', " +
                            "productcategory = '" + this.productCategoryTxt.SelectedItem.ToString() + "', " +
                            "Productprice = '" + this.priceTxt.Text + "', " +
                            "Dateandtime = '" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "Pimage = '" + imagePathForDb + "' " + // no comma before WHERE
                            "WHERE Productserial = '" + this.productSerialTxt.Text + "';";
                }
                else
                {
                    // Insert
                    query = "INSERT INTO Productlist (Productserial, Productname, brandname, quantity, productcategory, Productprice, Dateandtime, Pimage) VALUES (" +
                            "'" + this.productSerialTxt.Text + "', " +
                            "'" + this.productNameTxt.Text + "', " +
                            "'" + this.brandNameTxt.Text + "', " +
                            "'" + this.quantityTxt.Text + "', " +
                            "'" + this.productCategoryTxt.SelectedItem.ToString() + "', " +
                            "'" + this.priceTxt.Text + "', " +
                            "'" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + imagePathForDb + "');";
                }

                var count = this.Da.ExecuteDMLQuery(query);
                if (count == 1)
                {
                    MessageBox.Show(ds.Tables[0].Rows.Count == 1 ? "Data Updated Successfully" : "Data Added Successfully");
                }
                else
                {
                    MessageBox.Show("Operation failed, please check!!!");
                }

                this.AutoIdGenerate();
                this.PopulateGridView();
                this.clearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }

        


        private bool IsValidToSave()
        {
            if (string.IsNullOrWhiteSpace(this.productSerialTxt.Text) ||
                string.IsNullOrWhiteSpace(this.productNameTxt.Text) ||
                string.IsNullOrWhiteSpace(this.brandNameTxt.Text) ||
                string.IsNullOrWhiteSpace(this.quantityTxt.Text) ||
                this.productCategoryTxt.SelectedItem == null ||
                string.IsNullOrWhiteSpace(this.priceTxt.Text))
            {
                return false;
            }

            return true;
        }


        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        { 
            try
            {
                this.productSerialTxt.Text = this.dataGridView1.CurrentRow.Cells["Productserial"].Value.ToString();
                this.productNameTxt.Text = this.dataGridView1.CurrentRow.Cells["Productname"].Value.ToString();
                this.brandNameTxt.Text = this.dataGridView1.CurrentRow.Cells["brandname"].Value.ToString();
                this.quantityTxt.Text = this.dataGridView1.CurrentRow.Cells["quantity"].Value.ToString();
                this.priceTxt.Text = this.dataGridView1.CurrentRow.Cells["Productprice"].Value.ToString();
                this.productCategoryTxt.SelectedItem = this.dataGridView1.CurrentRow.Cells["productcategory"].Value.ToString();
                this.dateTimePicker1.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["Dateandtime"].Value);

                // Load picture from file path
                string imagePath = this.dataGridView1.CurrentRow.Cells["Pimage"].Value.ToString();

                if (File.Exists(imagePath))
                {
                    this.pbxPhoto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    this.pbxPhoto.Image = null; // or a default image
                    MessageBox.Show("Image file not found at:\n" + imagePath);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                DialogResult result = MessageBox.Show("Are you sure to delete this Item?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;


                var pID = this.dataGridView1.CurrentRow.Cells["Productserial"].Value.ToString();
                var query = "delete from Productlist where Productserial = '" + pID + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count > 0)
                    MessageBox.Show("Data remove successfully");
                else
                    MessageBox.Show("Data not remove please check!!!");

                this.clearAll();
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = this.searchTxt.Text.ToLower();

            string query = "SELECT * FROM Productlist WHERE " +
                           "LOWER(Productserial) LIKE '%" + searchText + "%' OR " +
                           "LOWER(Productname) LIKE '%" + searchText + "%' OR " +
                           "LOWER(brandname) LIKE '%" + searchText + "%' OR " +
                           "LOWER(quantity) LIKE '%" + searchText + "%' OR " +
                           "LOWER(productcategory) LIKE '%" + searchText + "%' OR " +
                           "LOWER(Productprice) LIKE '%" + searchText + "%' OR " +
                           "LOWER(Dateandtime) LIKE '%" + searchText + "%';";

            var ds = this.Da.ExecuteQuery(query);
            this.dataGridView1.DataSource = ds.Tables[0];


        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    openFileDialog.Title = "Select a Profile Photo";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFilePath = openFileDialog.FileName;

                        pbxPhoto.Image = Image.FromFile(selectedFilePath);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "this error happened");
            }
        }
    }
    }

