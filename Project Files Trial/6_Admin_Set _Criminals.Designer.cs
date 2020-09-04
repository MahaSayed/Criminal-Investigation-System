namespace Project_Files_Trial
{
    partial class _6_Admin_Set__Criminals
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
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nameee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locationn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picturee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pointss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Officer_Page_Admin_Panel_btn = new System.Windows.Forms.Button();
            this.Officer_Page_Criminal_Panel_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Officer_Page_Case_Panel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Points_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 30);
            this.label7.TabIndex = 72;
            this.label7.Text = "Criminal";
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(607, 620);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(167, 42);
            this.Add.TabIndex = 71;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(841, 620);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(167, 42);
            this.Edit.TabIndex = 70;
            this.Edit.Text = "Update";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1084, 620);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(167, 42);
            this.Delete.TabIndex = 69;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDd,
            this.Nameee,
            this.Agee,
            this.Locationn,
            this.Picturee,
            this.Pointss});
            this.dataGridView1.Location = new System.Drawing.Point(599, 249);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 276);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // IDd
            // 
            this.IDd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDd.HeaderText = "ID";
            this.IDd.Name = "IDd";
            // 
            // Nameee
            // 
            this.Nameee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nameee.HeaderText = "Name";
            this.Nameee.Name = "Nameee";
            // 
            // Agee
            // 
            this.Agee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Agee.HeaderText = "Age";
            this.Agee.Name = "Agee";
            // 
            // Locationn
            // 
            this.Locationn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Locationn.HeaderText = "Location";
            this.Locationn.Name = "Locationn";
            // 
            // Picturee
            // 
            this.Picturee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Picturee.HeaderText = "Picture";
            this.Picturee.Name = "Picturee";
            // 
            // Pointss
            // 
            this.Pointss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pointss.HeaderText = "Points";
            this.Pointss.Name = "Pointss";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(923, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 42);
            this.button1.TabIndex = 66;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(311, 452);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(329, 297);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(243, 22);
            this.Name_txt.TabIndex = 64;
            // 
            // Age_txt
            // 
            this.Age_txt.Location = new System.Drawing.Point(328, 345);
            this.Age_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.Size = new System.Drawing.Size(243, 22);
            this.Age_txt.TabIndex = 63;
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(329, 393);
            this.Location_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(243, 22);
            this.Location_txt.TabIndex = 62;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(433, 177);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(468, 22);
            this.Search.TabIndex = 61;
            // 
            // ID_txt
            // 
            this.ID_txt.Enabled = false;
            this.ID_txt.Location = new System.Drawing.Point(329, 250);
            this.ID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(243, 22);
            this.ID_txt.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "Image:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.Officer_Page_Admin_Panel_btn);
            this.panel3.Controls.Add(this.Officer_Page_Criminal_Panel_btn);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.Officer_Page_Case_Panel_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 540);
            this.panel3.TabIndex = 54;
            // 
            // Officer_Page_Admin_Panel_btn
            // 
            this.Officer_Page_Admin_Panel_btn.FlatAppearance.BorderSize = 0;
            this.Officer_Page_Admin_Panel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Officer_Page_Admin_Panel_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officer_Page_Admin_Panel_btn.Location = new System.Drawing.Point(0, 187);
            this.Officer_Page_Admin_Panel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Officer_Page_Admin_Panel_btn.Name = "Officer_Page_Admin_Panel_btn";
            this.Officer_Page_Admin_Panel_btn.Size = new System.Drawing.Size(196, 65);
            this.Officer_Page_Admin_Panel_btn.TabIndex = 7;
            this.Officer_Page_Admin_Panel_btn.Text = "Officer";
            this.Officer_Page_Admin_Panel_btn.UseVisualStyleBackColor = true;
            this.Officer_Page_Admin_Panel_btn.Click += new System.EventHandler(this.Officer_Page_Admin_Panel_btn_Click);
            // 
            // Officer_Page_Criminal_Panel_btn
            // 
            this.Officer_Page_Criminal_Panel_btn.FlatAppearance.BorderSize = 0;
            this.Officer_Page_Criminal_Panel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Officer_Page_Criminal_Panel_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officer_Page_Criminal_Panel_btn.Location = new System.Drawing.Point(0, 260);
            this.Officer_Page_Criminal_Panel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Officer_Page_Criminal_Panel_btn.Name = "Officer_Page_Criminal_Panel_btn";
            this.Officer_Page_Criminal_Panel_btn.Size = new System.Drawing.Size(196, 65);
            this.Officer_Page_Criminal_Panel_btn.TabIndex = 6;
            this.Officer_Page_Criminal_Panel_btn.Text = "Admin";
            this.Officer_Page_Criminal_Panel_btn.UseVisualStyleBackColor = true;
            this.Officer_Page_Criminal_Panel_btn.Click += new System.EventHandler(this.Officer_Page_Criminal_Panel_btn_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 112);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 65);
            this.button4.TabIndex = 5;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Officer_Page_Case_Panel_btn
            // 
            this.Officer_Page_Case_Panel_btn.FlatAppearance.BorderSize = 0;
            this.Officer_Page_Case_Panel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Officer_Page_Case_Panel_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officer_Page_Case_Panel_btn.Location = new System.Drawing.Point(0, 332);
            this.Officer_Page_Case_Panel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Officer_Page_Case_Panel_btn.Name = "Officer_Page_Case_Panel_btn";
            this.Officer_Page_Case_Panel_btn.Size = new System.Drawing.Size(196, 65);
            this.Officer_Page_Case_Panel_btn.TabIndex = 4;
            this.Officer_Page_Case_Panel_btn.Text = "Case";
            this.Officer_Page_Case_Panel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Officer_Page_Case_Panel_btn.UseVisualStyleBackColor = true;
            this.Officer_Page_Case_Panel_btn.Click += new System.EventHandler(this.Officer_Page_Case_Panel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 137);
            this.panel1.TabIndex = 53;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1189, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1293, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(381, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crime Investigation";
            // 
            // Upload
            // 
            this.Upload.FlatAppearance.BorderSize = 0;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(353, 620);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(167, 42);
            this.Upload.TabIndex = 73;
            this.Upload.Text = "Upload Pic";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Points_textBox
            // 
            this.Points_textBox.Location = new System.Drawing.Point(765, 560);
            this.Points_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Points_textBox.Name = "Points_textBox";
            this.Points_textBox.Size = new System.Drawing.Size(243, 22);
            this.Points_textBox.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 559);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 74;
            this.label8.Text = "Points:";
            // 
            // _6_Admin_Set__Criminals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 677);
            this.Controls.Add(this.Points_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Age_txt);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_6_Admin_Set__Criminals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_6_Admin_Set__Criminals";
            this.Load += new System.EventHandler(this._6_Admin_Set__Criminals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Officer_Page_Admin_Panel_btn;
        private System.Windows.Forms.Button Officer_Page_Criminal_Panel_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Officer_Page_Case_Panel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Points_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locationn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picturee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pointss;
    }
}