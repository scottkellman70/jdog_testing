namespace SOFDT3
{
    partial class FormNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxSubItem = new System.Windows.Forms.CheckBox();
            this.comboBoxParentItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.comboBoxSizeMeasurement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerialNum = new System.Windows.Forms.TextBox();
            this.radioButtonMedex = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonCellex = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxMedexType = new System.Windows.Forms.ComboBox();
            this.textBoxMedexOther = new System.Windows.Forms.TextBox();
            this.textBoxCellexOther = new System.Windows.Forms.TextBox();
            this.comboBoxCellexType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.textBoxSofexCase = new System.Windows.Forms.TextBox();
            this.ButtonOpenPDF = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.ButtonSubmitCountry = new System.Windows.Forms.Button();
            this.ButtonReloadCountries = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonLoadCSV = new System.Windows.Forms.Button();
            this.bindingSourceItems = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCountries = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSubItem
            // 
            this.checkBoxSubItem.AutoSize = true;
            this.checkBoxSubItem.Location = new System.Drawing.Point(12, 16);
            this.checkBoxSubItem.Name = "checkBoxSubItem";
            this.checkBoxSubItem.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSubItem.TabIndex = 0;
            this.checkBoxSubItem.Text = "Sub Item?";
            this.checkBoxSubItem.UseVisualStyleBackColor = true;
            // 
            // comboBoxParentItem
            // 
            this.comboBoxParentItem.FormattingEnabled = true;
            this.comboBoxParentItem.Location = new System.Drawing.Point(12, 39);
            this.comboBoxParentItem.Name = "comboBoxParentItem";
            this.comboBoxParentItem.Size = new System.Drawing.Size(161, 21);
            this.comboBoxParentItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Make and Model";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Size";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(12, 139);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(30, 20);
            this.textBoxSize.TabIndex = 5;
            // 
            // comboBoxSizeMeasurement
            // 
            this.comboBoxSizeMeasurement.FormattingEnabled = true;
            this.comboBoxSizeMeasurement.Items.AddRange(new object[] {
            "kb",
            "mb",
            "gb",
            "tb",
            "pb",
            "none"});
            this.comboBoxSizeMeasurement.Location = new System.Drawing.Point(48, 139);
            this.comboBoxSizeMeasurement.Name = "comboBoxSizeMeasurement";
            this.comboBoxSizeMeasurement.Size = new System.Drawing.Size(47, 21);
            this.comboBoxSizeMeasurement.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serial/IMEI/ICCID";
            // 
            // textBoxSerialNum
            // 
            this.textBoxSerialNum.Location = new System.Drawing.Point(12, 191);
            this.textBoxSerialNum.Name = "textBoxSerialNum";
            this.textBoxSerialNum.Size = new System.Drawing.Size(205, 20);
            this.textBoxSerialNum.TabIndex = 8;
            // 
            // radioButtonMedex
            // 
            this.radioButtonMedex.AutoSize = true;
            this.radioButtonMedex.Location = new System.Drawing.Point(11, 227);
            this.radioButtonMedex.Name = "radioButtonMedex";
            this.radioButtonMedex.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMedex.TabIndex = 9;
            this.radioButtonMedex.TabStop = true;
            this.radioButtonMedex.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonCellex
            // 
            this.radioButtonCellex.AutoSize = true;
            this.radioButtonCellex.Location = new System.Drawing.Point(11, 293);
            this.radioButtonCellex.Name = "radioButtonCellex";
            this.radioButtonCellex.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCellex.TabIndex = 11;
            this.radioButtonCellex.TabStop = true;
            this.radioButtonCellex.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxMedexType
            // 
            this.comboBoxMedexType.FormattingEnabled = true;
            this.comboBoxMedexType.Items.AddRange(new object[] {
            "HDD",
            "SSDD",
            "Thumb Drive",
            "SD Card",
            "CD/DVD",
            "Other"});
            this.comboBoxMedexType.Location = new System.Drawing.Point(31, 255);
            this.comboBoxMedexType.Name = "comboBoxMedexType";
            this.comboBoxMedexType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedexType.TabIndex = 13;
            // 
            // textBoxMedexOther
            // 
            this.textBoxMedexOther.Location = new System.Drawing.Point(158, 255);
            this.textBoxMedexOther.Name = "textBoxMedexOther";
            this.textBoxMedexOther.Size = new System.Drawing.Size(121, 20);
            this.textBoxMedexOther.TabIndex = 15;
            // 
            // textBoxCellexOther
            // 
            this.textBoxCellexOther.Location = new System.Drawing.Point(158, 324);
            this.textBoxCellexOther.Name = "textBoxCellexOther";
            this.textBoxCellexOther.Size = new System.Drawing.Size(121, 20);
            this.textBoxCellexOther.TabIndex = 18;
            // 
            // comboBoxCellexType
            // 
            this.comboBoxCellexType.FormattingEnabled = true;
            this.comboBoxCellexType.Items.AddRange(new object[] {
            "Phone",
            "Tablet",
            "SIM Card",
            "Drone",
            "Other"});
            this.comboBoxCellexType.Location = new System.Drawing.Point(31, 323);
            this.comboBoxCellexType.Name = "comboBoxCellexType";
            this.comboBoxCellexType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCellexType.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.AutoGenerateColumns = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.DataSource = this.bindingSourceItems;
            this.dataGridViewItems.Location = new System.Drawing.Point(297, 69);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 10;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewItems.Size = new System.Drawing.Size(812, 285);
            this.dataGridViewItems.TabIndex = 21;
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(1115, 65);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadButton.TabIndex = 22;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(1115, 91);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // textBoxSofexCase
            // 
            this.textBoxSofexCase.Location = new System.Drawing.Point(192, 40);
            this.textBoxSofexCase.Name = "textBoxSofexCase";
            this.textBoxSofexCase.Size = new System.Drawing.Size(100, 20);
            this.textBoxSofexCase.TabIndex = 24;
            // 
            // ButtonOpenPDF
            // 
            this.ButtonOpenPDF.Location = new System.Drawing.Point(319, 40);
            this.ButtonOpenPDF.Name = "ButtonOpenPDF";
            this.ButtonOpenPDF.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenPDF.TabIndex = 25;
            this.ButtonOpenPDF.Text = "Open PDF";
            this.ButtonOpenPDF.UseVisualStyleBackColor = true;
            this.ButtonOpenPDF.Click += new System.EventHandler(this.ButtonOpenPDF_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 696);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 26;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AllowUserToOrderColumns = true;
            this.dataGridViewCountries.AllowUserToResizeRows = false;
            this.dataGridViewCountries.AutoGenerateColumns = false;
            this.dataGridViewCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCountries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCountries.DataSource = this.bindingSourceCountries;
            this.dataGridViewCountries.Location = new System.Drawing.Point(297, 370);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowHeadersWidth = 10;
            this.dataGridViewCountries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCountries.Size = new System.Drawing.Size(567, 314);
            this.dataGridViewCountries.TabIndex = 27;
            // 
            // ButtonSubmitCountry
            // 
            this.ButtonSubmitCountry.Location = new System.Drawing.Point(870, 428);
            this.ButtonSubmitCountry.Name = "ButtonSubmitCountry";
            this.ButtonSubmitCountry.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmitCountry.TabIndex = 29;
            this.ButtonSubmitCountry.Text = "Submit";
            this.ButtonSubmitCountry.UseVisualStyleBackColor = true;
            // 
            // ButtonReloadCountries
            // 
            this.ButtonReloadCountries.Location = new System.Drawing.Point(870, 399);
            this.ButtonReloadCountries.Name = "ButtonReloadCountries";
            this.ButtonReloadCountries.Size = new System.Drawing.Size(75, 23);
            this.ButtonReloadCountries.TabIndex = 28;
            this.ButtonReloadCountries.Text = "Reload";
            this.ButtonReloadCountries.UseVisualStyleBackColor = true;
            this.ButtonReloadCountries.Click += new System.EventHandler(this.ButtonReloadCountries_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonLoadCSV
            // 
            this.ButtonLoadCSV.Location = new System.Drawing.Point(870, 370);
            this.ButtonLoadCSV.Name = "ButtonLoadCSV";
            this.ButtonLoadCSV.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadCSV.TabIndex = 30;
            this.ButtonLoadCSV.Text = "Load CSV";
            this.ButtonLoadCSV.UseVisualStyleBackColor = true;
            this.ButtonLoadCSV.Click += new System.EventHandler(this.ButtonLoadCSV_Click);
            // 
            // FormNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 731);
            this.Controls.Add(this.ButtonLoadCSV);
            this.Controls.Add(this.ButtonSubmitCountry);
            this.Controls.Add(this.ButtonReloadCountries);
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonOpenPDF);
            this.Controls.Add(this.textBoxSofexCase);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCellexOther);
            this.Controls.Add(this.comboBoxCellexType);
            this.Controls.Add(this.textBoxMedexOther);
            this.Controls.Add(this.comboBoxMedexType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioButtonCellex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonMedex);
            this.Controls.Add(this.textBoxSerialNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSizeMeasurement);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxParentItem);
            this.Controls.Add(this.checkBoxSubItem);
            this.Name = "FormNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSubItem;
        private System.Windows.Forms.ComboBox comboBoxParentItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.ComboBox comboBoxSizeMeasurement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerialNum;
        private System.Windows.Forms.RadioButton radioButtonMedex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonCellex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxMedexType;
        private System.Windows.Forms.TextBox textBoxMedexOther;
        private System.Windows.Forms.TextBox textBoxCellexOther;
        private System.Windows.Forms.ComboBox comboBoxCellexType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox textBoxSofexCase;
        private System.Windows.Forms.Button ButtonOpenPDF;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Button ButtonSubmitCountry;
        private System.Windows.Forms.Button ButtonReloadCountries;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonLoadCSV;
        private System.Windows.Forms.BindingSource bindingSourceItems;
        private System.Windows.Forms.BindingSource bindingSourceCountries;
    }
}