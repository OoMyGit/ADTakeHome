namespace ADTakeHomeW8
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelplayernum = new System.Windows.Forms.Label();
            this.labelnum = new System.Windows.Forms.Label();
            this.labelplayerteam = new System.Windows.Forms.Label();
            this.labelplayerpos = new System.Windows.Forms.Label();
            this.labelplayernat = new System.Windows.Forms.Label();
            this.labelteam = new System.Windows.Forms.Label();
            this.labelpos = new System.Windows.Forms.Label();
            this.labelnat = new System.Windows.Forms.Label();
            this.labelplayername = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.buttonfind = new System.Windows.Forms.Button();
            this.labelmatchdetail = new System.Windows.Forms.Label();
            this.labelaway = new System.Windows.Forms.Label();
            this.labelhome = new System.Windows.Forms.Label();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.labelplayerred = new System.Windows.Forms.Label();
            this.labelred = new System.Windows.Forms.Label();
            this.labelyellow = new System.Windows.Forms.Label();
            this.labelplayeryellow = new System.Windows.Forms.Label();
            this.labelgoal = new System.Windows.Forms.Label();
            this.labelplayergoal = new System.Windows.Forms.Label();
            this.labelpenalty = new System.Windows.Forms.Label();
            this.labelplayerpenalty = new System.Windows.Forms.Label();
            this.labelawayteam = new System.Windows.Forms.Label();
            this.labelhometeam = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 30);
            this.toolStripMenuItem1.Text = "Player Data";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 30);
            this.toolStripMenuItem2.Text = "Show Match";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(19, 84);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(432, 177);
            this.dgv1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // combo1
            // 
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(161, 10);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(222, 28);
            this.combo1.TabIndex = 3;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelhometeam);
            this.panel1.Controls.Add(this.labelawayteam);
            this.panel1.Controls.Add(this.labelplayeryellow);
            this.panel1.Controls.Add(this.labelplayerpenalty);
            this.panel1.Controls.Add(this.labelplayergoal);
            this.panel1.Controls.Add(this.labelplayerred);
            this.panel1.Controls.Add(this.labelyellow);
            this.panel1.Controls.Add(this.labelpenalty);
            this.panel1.Controls.Add(this.labelgoal);
            this.panel1.Controls.Add(this.labelred);
            this.panel1.Controls.Add(this.labelplayernum);
            this.panel1.Controls.Add(this.labelnum);
            this.panel1.Controls.Add(this.labelplayerteam);
            this.panel1.Controls.Add(this.labelplayerpos);
            this.panel1.Controls.Add(this.labelplayernat);
            this.panel1.Controls.Add(this.labelteam);
            this.panel1.Controls.Add(this.labelpos);
            this.panel1.Controls.Add(this.labelnat);
            this.panel1.Controls.Add(this.labelplayername);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.combo2);
            this.panel1.Controls.Add(this.buttonfind);
            this.panel1.Controls.Add(this.labelmatchdetail);
            this.panel1.Controls.Add(this.labelaway);
            this.panel1.Controls.Add(this.labelhome);
            this.panel1.Controls.Add(this.dgv3);
            this.panel1.Controls.Add(this.dgv2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.combo1);
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 463);
            this.panel1.TabIndex = 5;
            // 
            // labelplayernum
            // 
            this.labelplayernum.AutoSize = true;
            this.labelplayernum.Location = new System.Drawing.Point(174, 255);
            this.labelplayernum.Name = "labelplayernum";
            this.labelplayernum.Size = new System.Drawing.Size(51, 20);
            this.labelplayernum.TabIndex = 21;
            this.labelplayernum.Text = "label6";
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Location = new System.Drawing.Point(40, 255);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(128, 20);
            this.labelnum.TabIndex = 20;
            this.labelnum.Text = "Squad Number : ";
            // 
            // labelplayerteam
            // 
            this.labelplayerteam.AutoSize = true;
            this.labelplayerteam.Location = new System.Drawing.Point(174, 129);
            this.labelplayerteam.Name = "labelplayerteam";
            this.labelplayerteam.Size = new System.Drawing.Size(0, 20);
            this.labelplayerteam.TabIndex = 19;
            // 
            // labelplayerpos
            // 
            this.labelplayerpos.AutoSize = true;
            this.labelplayerpos.Location = new System.Drawing.Point(174, 167);
            this.labelplayerpos.Name = "labelplayerpos";
            this.labelplayerpos.Size = new System.Drawing.Size(0, 20);
            this.labelplayerpos.TabIndex = 18;
            // 
            // labelplayernat
            // 
            this.labelplayernat.AutoSize = true;
            this.labelplayernat.Location = new System.Drawing.Point(174, 210);
            this.labelplayernat.Name = "labelplayernat";
            this.labelplayernat.Size = new System.Drawing.Size(0, 20);
            this.labelplayernat.TabIndex = 17;
            // 
            // labelteam
            // 
            this.labelteam.AutoSize = true;
            this.labelteam.Location = new System.Drawing.Point(40, 129);
            this.labelteam.Name = "labelteam";
            this.labelteam.Size = new System.Drawing.Size(61, 20);
            this.labelteam.TabIndex = 16;
            this.labelteam.Text = "Team : ";
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(40, 167);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(77, 20);
            this.labelpos.TabIndex = 15;
            this.labelpos.Text = "Position : ";
            // 
            // labelnat
            // 
            this.labelnat.AutoSize = true;
            this.labelnat.Location = new System.Drawing.Point(40, 210);
            this.labelnat.Name = "labelnat";
            this.labelnat.Size = new System.Drawing.Size(94, 20);
            this.labelnat.TabIndex = 14;
            this.labelnat.Text = "Nationality : ";
            // 
            // labelplayername
            // 
            this.labelplayername.AutoSize = true;
            this.labelplayername.Location = new System.Drawing.Point(174, 93);
            this.labelplayername.Name = "labelplayername";
            this.labelplayername.Size = new System.Drawing.Size(0, 20);
            this.labelplayername.TabIndex = 13;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(40, 93);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(63, 20);
            this.labelname.TabIndex = 12;
            this.labelname.Text = "Name : ";
            // 
            // combo2
            // 
            this.combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(603, 10);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(220, 28);
            this.combo2.TabIndex = 11;
            this.combo2.SelectedIndexChanged += new System.EventHandler(this.combo2_SelectedIndexChanged);
            // 
            // buttonfind
            // 
            this.buttonfind.Location = new System.Drawing.Point(970, 13);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(84, 32);
            this.buttonfind.TabIndex = 10;
            this.buttonfind.Text = "Find";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // labelmatchdetail
            // 
            this.labelmatchdetail.AutoSize = true;
            this.labelmatchdetail.Location = new System.Drawing.Point(475, 61);
            this.labelmatchdetail.Name = "labelmatchdetail";
            this.labelmatchdetail.Size = new System.Drawing.Size(98, 20);
            this.labelmatchdetail.TabIndex = 9;
            this.labelmatchdetail.Text = "Match Detail";
            // 
            // labelaway
            // 
            this.labelaway.AutoSize = true;
            this.labelaway.Location = new System.Drawing.Point(10, 264);
            this.labelaway.Name = "labelaway";
            this.labelaway.Size = new System.Drawing.Size(91, 20);
            this.labelaway.TabIndex = 8;
            this.labelaway.Text = "Away Team";
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Location = new System.Drawing.Point(10, 61);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(96, 20);
            this.labelhome.TabIndex = 7;
            this.labelhome.Text = "Home Team";
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(479, 84);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersVisible = false;
            this.dgv3.RowHeadersWidth = 62;
            this.dgv3.RowTemplate.Height = 28;
            this.dgv3.Size = new System.Drawing.Size(607, 376);
            this.dgv3.TabIndex = 6;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(19, 287);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 28;
            this.dgv2.Size = new System.Drawing.Size(432, 173);
            this.dgv2.TabIndex = 5;
            // 
            // labelplayerred
            // 
            this.labelplayerred.AutoSize = true;
            this.labelplayerred.Location = new System.Drawing.Point(480, 129);
            this.labelplayerred.Name = "labelplayerred";
            this.labelplayerred.Size = new System.Drawing.Size(0, 20);
            this.labelplayerred.TabIndex = 23;
            // 
            // labelred
            // 
            this.labelred.AutoSize = true;
            this.labelred.Location = new System.Drawing.Point(346, 129);
            this.labelred.Name = "labelred";
            this.labelred.Size = new System.Drawing.Size(89, 20);
            this.labelred.TabIndex = 22;
            this.labelred.Text = "Red Card : ";
            // 
            // labelyellow
            // 
            this.labelyellow.AutoSize = true;
            this.labelyellow.Location = new System.Drawing.Point(346, 93);
            this.labelyellow.Name = "labelyellow";
            this.labelyellow.Size = new System.Drawing.Size(105, 20);
            this.labelyellow.TabIndex = 22;
            this.labelyellow.Text = "Yellow Card : ";
            // 
            // labelplayeryellow
            // 
            this.labelplayeryellow.AutoSize = true;
            this.labelplayeryellow.Location = new System.Drawing.Point(480, 93);
            this.labelplayeryellow.Name = "labelplayeryellow";
            this.labelplayeryellow.Size = new System.Drawing.Size(0, 20);
            this.labelplayeryellow.TabIndex = 23;
            // 
            // labelgoal
            // 
            this.labelgoal.AutoSize = true;
            this.labelgoal.Location = new System.Drawing.Point(346, 167);
            this.labelgoal.Name = "labelgoal";
            this.labelgoal.Size = new System.Drawing.Size(110, 20);
            this.labelgoal.TabIndex = 22;
            this.labelgoal.Text = "Goal Scored : ";
            // 
            // labelplayergoal
            // 
            this.labelplayergoal.AutoSize = true;
            this.labelplayergoal.Location = new System.Drawing.Point(480, 167);
            this.labelplayergoal.Name = "labelplayergoal";
            this.labelplayergoal.Size = new System.Drawing.Size(0, 20);
            this.labelplayergoal.TabIndex = 23;
            // 
            // labelpenalty
            // 
            this.labelpenalty.AutoSize = true;
            this.labelpenalty.Location = new System.Drawing.Point(346, 210);
            this.labelpenalty.Name = "labelpenalty";
            this.labelpenalty.Size = new System.Drawing.Size(127, 20);
            this.labelpenalty.TabIndex = 22;
            this.labelpenalty.Text = "Penalty Missed : ";
            // 
            // labelplayerpenalty
            // 
            this.labelplayerpenalty.AutoSize = true;
            this.labelplayerpenalty.Location = new System.Drawing.Point(480, 210);
            this.labelplayerpenalty.Name = "labelplayerpenalty";
            this.labelplayerpenalty.Size = new System.Drawing.Size(0, 20);
            this.labelplayerpenalty.TabIndex = 23;
            // 
            // labelawayteam
            // 
            this.labelawayteam.AutoSize = true;
            this.labelawayteam.Location = new System.Drawing.Point(143, 264);
            this.labelawayteam.Name = "labelawayteam";
            this.labelawayteam.Size = new System.Drawing.Size(0, 20);
            this.labelawayteam.TabIndex = 24;
            // 
            // labelhometeam
            // 
            this.labelhometeam.AutoSize = true;
            this.labelhometeam.Location = new System.Drawing.Point(143, 61);
            this.labelhometeam.Name = "labelhometeam";
            this.labelhometeam.Size = new System.Drawing.Size(0, 20);
            this.labelhometeam.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.Label labelmatchdetail;
        private System.Windows.Forms.Label labelaway;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label labelplayernum;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.Label labelplayerteam;
        private System.Windows.Forms.Label labelplayerpos;
        private System.Windows.Forms.Label labelplayernat;
        private System.Windows.Forms.Label labelteam;
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Label labelnat;
        private System.Windows.Forms.Label labelplayername;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelplayeryellow;
        private System.Windows.Forms.Label labelplayerpenalty;
        private System.Windows.Forms.Label labelplayergoal;
        private System.Windows.Forms.Label labelplayerred;
        private System.Windows.Forms.Label labelyellow;
        private System.Windows.Forms.Label labelpenalty;
        private System.Windows.Forms.Label labelgoal;
        private System.Windows.Forms.Label labelred;
        private System.Windows.Forms.Label labelhometeam;
        private System.Windows.Forms.Label labelawayteam;
    }
}

