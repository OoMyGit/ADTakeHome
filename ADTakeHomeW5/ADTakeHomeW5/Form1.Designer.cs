namespace ADTakeHomeW5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.dgvcategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonfilter = new System.Windows.Forms.Button();
            this.buttonall = new System.Windows.Forms.Button();
            this.combofilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonaddcategory = new System.Windows.Forms.Button();
            this.buttonremovecategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxnamaproduct = new System.Windows.Forms.TextBox();
            this.textboxcategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxhargaproduct = new System.Windows.Forms.TextBox();
            this.textboxstockproduct = new System.Windows.Forms.TextBox();
            this.combocategoryproduct = new System.Windows.Forms.ComboBox();
            this.buttonaddproduct = new System.Windows.Forms.Button();
            this.buttonremoveproduct = new System.Windows.Forms.Button();
            this.buttoneditproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproduct
            // 
            this.dgvproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.ColumnHeadersVisible = false;
            this.dgvproduct.Location = new System.Drawing.Point(12, 51);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersVisible = false;
            this.dgvproduct.RowHeadersWidth = 62;
            this.dgvproduct.RowTemplate.Height = 33;
            this.dgvproduct.Size = new System.Drawing.Size(543, 268);
            this.dgvproduct.TabIndex = 0;
            this.dgvproduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproduct_CellMouseClick);
            // 
            // dgvcategory
            // 
            this.dgvcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategory.Location = new System.Drawing.Point(629, 37);
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.RowHeadersWidth = 62;
            this.dgvcategory.RowTemplate.Height = 33;
            this.dgvcategory.Size = new System.Drawing.Size(360, 225);
            this.dgvcategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // buttonfilter
            // 
            this.buttonfilter.Location = new System.Drawing.Point(290, 14);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(112, 32);
            this.buttonfilter.TabIndex = 4;
            this.buttonfilter.Text = "Filter";
            this.buttonfilter.UseVisualStyleBackColor = true;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // buttonall
            // 
            this.buttonall.Location = new System.Drawing.Point(236, 15);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(48, 32);
            this.buttonall.TabIndex = 5;
            this.buttonall.Text = "All";
            this.buttonall.UseVisualStyleBackColor = true;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // combofilter
            // 
            this.combofilter.FormattingEnabled = true;
            this.combofilter.Location = new System.Drawing.Point(408, 15);
            this.combofilter.Name = "combofilter";
            this.combofilter.Size = new System.Drawing.Size(147, 33);
            this.combofilter.TabIndex = 6;
            this.combofilter.SelectionChangeCommitted += new System.EventHandler(this.combofilter_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Details";
            // 
            // buttonaddcategory
            // 
            this.buttonaddcategory.BackColor = System.Drawing.Color.Lime;
            this.buttonaddcategory.Location = new System.Drawing.Point(728, 303);
            this.buttonaddcategory.Name = "buttonaddcategory";
            this.buttonaddcategory.Size = new System.Drawing.Size(101, 74);
            this.buttonaddcategory.TabIndex = 8;
            this.buttonaddcategory.Text = "Add Category";
            this.buttonaddcategory.UseVisualStyleBackColor = false;
            this.buttonaddcategory.Click += new System.EventHandler(this.buttonaddcategory_Click);
            // 
            // buttonremovecategory
            // 
            this.buttonremovecategory.BackColor = System.Drawing.Color.Red;
            this.buttonremovecategory.Location = new System.Drawing.Point(844, 303);
            this.buttonremovecategory.Name = "buttonremovecategory";
            this.buttonremovecategory.Size = new System.Drawing.Size(101, 74);
            this.buttonremovecategory.TabIndex = 9;
            this.buttonremovecategory.Text = "Remove Category";
            this.buttonremovecategory.UseVisualStyleBackColor = false;
            this.buttonremovecategory.Click += new System.EventHandler(this.buttonremovecategory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama :";
            // 
            // textboxnamaproduct
            // 
            this.textboxnamaproduct.Location = new System.Drawing.Point(108, 346);
            this.textboxnamaproduct.Name = "textboxnamaproduct";
            this.textboxnamaproduct.Size = new System.Drawing.Size(447, 31);
            this.textboxnamaproduct.TabIndex = 12;
            // 
            // textboxcategory
            // 
            this.textboxcategory.Location = new System.Drawing.Point(703, 265);
            this.textboxcategory.Name = "textboxcategory";
            this.textboxcategory.Size = new System.Drawing.Size(286, 31);
            this.textboxcategory.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Harga :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Stock :";
            // 
            // textboxhargaproduct
            // 
            this.textboxhargaproduct.Location = new System.Drawing.Point(108, 454);
            this.textboxhargaproduct.Name = "textboxhargaproduct";
            this.textboxhargaproduct.Size = new System.Drawing.Size(150, 31);
            this.textboxhargaproduct.TabIndex = 17;
            this.textboxhargaproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxhargaproduct_KeyPress);
            // 
            // textboxstockproduct
            // 
            this.textboxstockproduct.Location = new System.Drawing.Point(108, 511);
            this.textboxstockproduct.Name = "textboxstockproduct";
            this.textboxstockproduct.Size = new System.Drawing.Size(150, 31);
            this.textboxstockproduct.TabIndex = 18;
            this.textboxstockproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxstockproduct_KeyPress);
            // 
            // combocategoryproduct
            // 
            this.combocategoryproduct.FormattingEnabled = true;
            this.combocategoryproduct.Location = new System.Drawing.Point(108, 400);
            this.combocategoryproduct.Name = "combocategoryproduct";
            this.combocategoryproduct.Size = new System.Drawing.Size(187, 33);
            this.combocategoryproduct.TabIndex = 19;
            // 
            // buttonaddproduct
            // 
            this.buttonaddproduct.BackColor = System.Drawing.Color.Lime;
            this.buttonaddproduct.Location = new System.Drawing.Point(279, 459);
            this.buttonaddproduct.Name = "buttonaddproduct";
            this.buttonaddproduct.Size = new System.Drawing.Size(93, 74);
            this.buttonaddproduct.TabIndex = 20;
            this.buttonaddproduct.Text = "Add Product";
            this.buttonaddproduct.UseVisualStyleBackColor = false;
            this.buttonaddproduct.Click += new System.EventHandler(this.buttonaddproduct_Click);
            // 
            // buttonremoveproduct
            // 
            this.buttonremoveproduct.BackColor = System.Drawing.Color.Red;
            this.buttonremoveproduct.Location = new System.Drawing.Point(477, 459);
            this.buttonremoveproduct.Name = "buttonremoveproduct";
            this.buttonremoveproduct.Size = new System.Drawing.Size(95, 74);
            this.buttonremoveproduct.TabIndex = 21;
            this.buttonremoveproduct.Text = "Remove Product";
            this.buttonremoveproduct.UseVisualStyleBackColor = false;
            this.buttonremoveproduct.Click += new System.EventHandler(this.buttonremoveproduct_Click);
            // 
            // buttoneditproduct
            // 
            this.buttoneditproduct.BackColor = System.Drawing.Color.Yellow;
            this.buttoneditproduct.Location = new System.Drawing.Point(378, 459);
            this.buttoneditproduct.Name = "buttoneditproduct";
            this.buttoneditproduct.Size = new System.Drawing.Size(93, 74);
            this.buttoneditproduct.TabIndex = 22;
            this.buttoneditproduct.Text = "Edit Product";
            this.buttoneditproduct.UseVisualStyleBackColor = false;
            this.buttoneditproduct.Click += new System.EventHandler(this.buttoneditproduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1001, 545);
            this.Controls.Add(this.buttoneditproduct);
            this.Controls.Add(this.buttonremoveproduct);
            this.Controls.Add(this.buttonaddproduct);
            this.Controls.Add(this.combocategoryproduct);
            this.Controls.Add(this.textboxstockproduct);
            this.Controls.Add(this.textboxhargaproduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxcategory);
            this.Controls.Add(this.textboxnamaproduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonremovecategory);
            this.Controls.Add(this.buttonaddcategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combofilter);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcategory);
            this.Controls.Add(this.dgvproduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvproduct;
        private DataGridView dgvcategory;
        private Label label1;
        private Label label2;
        private Button buttonfilter;
        private Button buttonall;
        private ComboBox combofilter;
        private Label label3;
        private Button buttonaddcategory;
        private Button buttonremovecategory;
        private Label label4;
        private Label label5;
        private TextBox textboxnamaproduct;
        private TextBox textboxcategory;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textboxhargaproduct;
        private TextBox textboxstockproduct;
        private ComboBox combocategoryproduct;
        private Button buttonaddproduct;
        private Button buttonremoveproduct;
        private Button buttoneditproduct;
    }
}