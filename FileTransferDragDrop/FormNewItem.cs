using Spire.PdfViewer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFDT3
{
    public partial class FormNewItem : Form
    {
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\FileTransferDragDrop\FileTransferDragDrop\SampleDatabase.mdf;Integrated Security=True";
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public FormNewItem()
        {
            InitializeComponent();
            //GetData("select * from items", this.dataGridView2, this.bindingSource1);
            //GetData("select * from countries;", this.dataGridView3, this.bindingSource2);
        }

        private void FormNewItem_Load(object sender, EventArgs e)
        {
            GetData("select * from items", this.dataGridViewItems, this.bindingSourceItems);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            GetData("select * from items", this.dataGridViewItems, this.bindingSourceCountries);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Update the database with changes.
            dataAdapter.Update((DataTable)bindingSourceItems.DataSource);
        }

        private void GetData(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            bs.DataSource = table;
            dgv.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = string.Empty;

            if (radioButtonCellex.Checked == true)
            {
                type = this.comboBoxCellexType.SelectedItem.ToString();
            }

            if (radioButtonMedex.Checked == true)
            {
                type = this.comboBoxMedexType.SelectedItem.ToString();
            }

            if (comboBoxCellexType.SelectedIndex > -1)
            {
                if (comboBoxCellexType.SelectedItem.ToString() == "Other")
                {
                    type = this.textBoxCellexOther.Text;
                }
            }

            if (comboBoxMedexType.SelectedIndex > -1)
            {
                if (comboBoxMedexType.SelectedItem.ToString() == "Other")
                {
                    type = this.textBoxMedexOther.Text;
                }
            }

            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;

            int intMedexChecked = this.radioButtonMedex.Checked ? 1 : 0;
            int intCellexChecked = this.radioButtonMedex.Checked ? 1 : 0;

            connection = new SqlConnection(connectionString);
            sql = "insert into Items (sofex_case, name, isSubItem, size, size_measurement, is_medex, is_cellex, type) "
                + "values('" + this.textBoxSofexCase.Text + "',"
                + "'" + this.textBoxName.Text + "',"
                + "'" + this.checkBoxSubItem.Checked + "',"
                + "'" + this.textBoxSize.Text + "',"
                + "'" + this.comboBoxSizeMeasurement.SelectedItem + "',"
                + intMedexChecked + ","
                + intCellexChecked + ","
                + "'" + type + "'" + "); ";
            try
            {
                connection.Open();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
                GetData("select * from items", this.dataGridViewItems, this.bindingSourceItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonOpenPDF_Click(object sender, EventArgs e)
        {
            ShowPDFDialog();
        }

        public void ShowPDFDialog()
        {
            string fileSource = string.Empty;
            PdfViewer pdfViewer = new PdfViewer() { Size = new Size(630, 630), Top = 50 };
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();
            Button brosweFolders = new Button() { Text = "Browse" };

            Form prompt = new Form()
            {
                Width = 650,
                Height = 650,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "SOF DT3 - PDF Viewer",
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Normal
            };

            brosweFolders.Click += (sender, e) =>
            {
                DialogResult result = fileBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdfViewer.LoadFromFile(fileBrowserDialog.FileName);
                }
            };

            prompt.Controls.Add(pdfViewer);
            prompt.Controls.Add(brosweFolders);
            prompt.AcceptButton = brosweFolders;
            prompt.ShowDialog();

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReloadCountries_Click(object sender, EventArgs e)
        {
            GetData("select * from countries;", this.dataGridViewCountries, this.bindingSourceCountries);
        }

        private void ButtonLoadCSV_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(connectionString);
            connection.Open();

            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(this.openFileDialog1.FileName))
            {
                string[] countries = File.ReadAllLines(this.openFileDialog1.FileName);

                foreach (string country in countries)
                {
                    string[] indivCtry = country.Split(';');
                    string name = indivCtry[0].ToString().Replace("'", "").Replace("^", "");
                    string trigram = indivCtry[1];
                    InsertCountry(name, trigram, connection, dataAdapter);
                }
                connection.Close();
                connection.Dispose();
            }

        }

        private void InsertCountry(string name, string trigram, SqlConnection cn, SqlDataAdapter adapter)
        {
            string sql = "insert into Countries (name, trigram) values('" + name + "','" + trigram + "');";

            try
            {
                adapter.InsertCommand = new SqlCommand(sql, cn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
