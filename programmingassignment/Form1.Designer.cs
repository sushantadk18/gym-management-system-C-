namespace programmingassignment
{
    partial class BestFitness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestFitness));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblfinalcost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbswimmingno = new System.Windows.Forms.RadioButton();
            this.rdbswimingyes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbsaunano = new System.Windows.Forms.RadioButton();
            this.rdbsaunayes = new System.Windows.Forms.RadioButton();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numPrivateHours = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.txttargetweight = new System.Windows.Forms.TextBox();
            this.txtcurrentweight = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrivateHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(363, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best Fitness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(375, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bharatpur-10 ,Chitwan";
            // 
            // pbimage
            // 
            this.pbimage.BackColor = System.Drawing.Color.White;
            this.pbimage.Image = ((System.Drawing.Image)(resources.GetObject("pbimage.Image")));
            this.pbimage.Location = new System.Drawing.Point(800, 75);
            this.pbimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(176, 164);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 20;
            this.pbimage.TabStop = false;
            this.pbimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(800, 248);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(176, 46);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetails.ColumnHeadersHeight = 29;
            this.dgvDetails.GridColor = System.Drawing.Color.Black;
            this.dgvDetails.Location = new System.Drawing.Point(12, 297);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 20;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(743, 226);
            this.dgvDetails.TabIndex = 22;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(800, 362);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 57);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(800, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total Cost";
            // 
            // lblfinalcost
            // 
            this.lblfinalcost.AutoSize = true;
            this.lblfinalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblfinalcost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblfinalcost.Location = new System.Drawing.Point(887, 446);
            this.lblfinalcost.Name = "lblfinalcost";
            this.lblfinalcost.Size = new System.Drawing.Size(16, 18);
            this.lblfinalcost.TabIndex = 29;
            this.lblfinalcost.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numPrivateHours);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbList);
            this.groupBox1.Controls.Add(this.txttargetweight);
            this.groupBox1.Controls.Add(this.txtcurrentweight);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 181);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please fill all the details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbswimmingno);
            this.panel2.Controls.Add(this.rdbswimingyes);
            this.panel2.Location = new System.Drawing.Point(554, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 28);
            this.panel2.TabIndex = 53;
            // 
            // rdbswimmingno
            // 
            this.rdbswimmingno.AutoSize = true;
            this.rdbswimmingno.Location = new System.Drawing.Point(105, 4);
            this.rdbswimmingno.Name = "rdbswimmingno";
            this.rdbswimmingno.Size = new System.Drawing.Size(46, 20);
            this.rdbswimmingno.TabIndex = 1;
            this.rdbswimmingno.TabStop = true;
            this.rdbswimmingno.Text = "No";
            this.rdbswimmingno.UseVisualStyleBackColor = true;
            this.rdbswimmingno.CheckedChanged += new System.EventHandler(this.rdbswimmingno_CheckedChanged);
            // 
            // rdbswimingyes
            // 
            this.rdbswimingyes.AutoSize = true;
            this.rdbswimingyes.Location = new System.Drawing.Point(5, 4);
            this.rdbswimingyes.Name = "rdbswimingyes";
            this.rdbswimingyes.Size = new System.Drawing.Size(52, 20);
            this.rdbswimingyes.TabIndex = 0;
            this.rdbswimingyes.TabStop = true;
            this.rdbswimingyes.Text = "Yes";
            this.rdbswimingyes.UseVisualStyleBackColor = true;
            this.rdbswimingyes.CheckedChanged += new System.EventHandler(this.rdbswimingyes_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbsaunano);
            this.panel1.Controls.Add(this.rdbsaunayes);
            this.panel1.Location = new System.Drawing.Point(552, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 28);
            this.panel1.TabIndex = 52;
            // 
            // rdbsaunano
            // 
            this.rdbsaunano.AutoSize = true;
            this.rdbsaunano.Location = new System.Drawing.Point(105, 5);
            this.rdbsaunano.Name = "rdbsaunano";
            this.rdbsaunano.Size = new System.Drawing.Size(46, 20);
            this.rdbsaunano.TabIndex = 1;
            this.rdbsaunano.TabStop = true;
            this.rdbsaunano.Text = "No";
            this.rdbsaunano.UseVisualStyleBackColor = true;
            this.rdbsaunano.CheckedChanged += new System.EventHandler(this.rdbsaunano_CheckedChanged);
            // 
            // rdbsaunayes
            // 
            this.rdbsaunayes.AutoSize = true;
            this.rdbsaunayes.Location = new System.Drawing.Point(7, 5);
            this.rdbsaunayes.Name = "rdbsaunayes";
            this.rdbsaunayes.Size = new System.Drawing.Size(52, 20);
            this.rdbsaunayes.TabIndex = 0;
            this.rdbsaunayes.TabStop = true;
            this.rdbsaunayes.Text = "Yes";
            this.rdbsaunayes.UseVisualStyleBackColor = true;
            this.rdbsaunayes.CheckedChanged += new System.EventHandler(this.rdbsaunayes_CheckedChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(554, 149);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(179, 22);
            this.txtCost.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(446, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Cost";
            // 
            // numPrivateHours
            // 
            this.numPrivateHours.Location = new System.Drawing.Point(552, 49);
            this.numPrivateHours.Name = "numPrivateHours";
            this.numPrivateHours.Size = new System.Drawing.Size(180, 22);
            this.numPrivateHours.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(444, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Swimming";
            // 
            // cbList
            // 
            this.cbList.FormattingEnabled = true;
            this.cbList.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.cbList.Location = new System.Drawing.Point(120, 112);
            this.cbList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(193, 24);
            this.cbList.TabIndex = 45;
            // 
            // txttargetweight
            // 
            this.txttargetweight.Location = new System.Drawing.Point(552, 17);
            this.txttargetweight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttargetweight.Name = "txttargetweight";
            this.txttargetweight.Size = new System.Drawing.Size(181, 22);
            this.txttargetweight.TabIndex = 41;
            // 
            // txtcurrentweight
            // 
            this.txtcurrentweight.Location = new System.Drawing.Point(120, 144);
            this.txtcurrentweight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcurrentweight.Name = "txtcurrentweight";
            this.txtcurrentweight.Size = new System.Drawing.Size(193, 22);
            this.txtcurrentweight.TabIndex = 40;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(120, 80);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(193, 22);
            this.txtContact.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 49);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 38;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 17);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(193, 22);
            this.txtCustomerName.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(442, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Private Trainer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(444, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Sauna Option";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(444, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Target Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(-1, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Current Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(-1, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Training Plan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(-1, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Contact :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(-1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(-1, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Customer Name";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(133, 81);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(192, 22);
            this.txtSearchCustomer.TabIndex = 39;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(12, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Customer Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(368, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 27);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(468, 79);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(91, 27);
            this.btncreate.TabIndex = 41;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(565, 79);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(91, 27);
            this.btnedit.TabIndex = 42;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(662, 80);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 27);
            this.btndelete.TabIndex = 43;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(800, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 45);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BestFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(996, 544);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblfinalcost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbimage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BestFitness";
            this.Text = "BestFitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrivateHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblfinalcost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.TextBox txttargetweight;
        private System.Windows.Forms.TextBox txtcurrentweight;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPrivateHours;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbswimmingno;
        private System.Windows.Forms.RadioButton rdbswimingyes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbsaunano;
        private System.Windows.Forms.RadioButton rdbsaunayes;
        private System.Windows.Forms.Button btnClear;
    }
}

