using Spire.PdfViewer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        }

        private void FormNewItem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource2;
            GetData("select * from items");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            GetData("select * from items");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Update the database with changes.
            dataAdapter.Update((DataTable)bindingSource2.DataSource);
        }

        private void GetData(string selectCommand)
        {
            //this.dataGridView2.Dock = DockStyle.Fill;
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            bindingSource2.DataSource = table;
            dataGridView2.DataSource = bindingSource2;
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
                WindowState = FormWindowState.Maximized
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
    }
}
