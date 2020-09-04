namespace Project_Files_Trial
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
            this.label3 = new System.Windows.Forms.Label();
            this.welcome_officer_btn = new System.Windows.Forms.Button();
            this.welcome_admin_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcome_Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome_groupbox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.Welcome_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome to Crime Investigation.\r\n";
            // 
            // welcome_officer_btn
            // 
            this.welcome_officer_btn.FlatAppearance.BorderSize = 0;
            this.welcome_officer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_officer_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_officer_btn.Location = new System.Drawing.Point(532, 98);
            this.welcome_officer_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.welcome_officer_btn.Name = "welcome_officer_btn";
            this.welcome_officer_btn.Size = new System.Drawing.Size(127, 50);
            this.welcome_officer_btn.TabIndex = 8;
            this.welcome_officer_btn.Text = "Officer";
            this.welcome_officer_btn.UseVisualStyleBackColor = true;
            this.welcome_officer_btn.Click += new System.EventHandler(this.welcome_officer_btn_Click);
            // 
            // welcome_admin_btn
            // 
            this.welcome_admin_btn.FlatAppearance.BorderSize = 0;
            this.welcome_admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_admin_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_admin_btn.Location = new System.Drawing.Point(4, 98);
            this.welcome_admin_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.welcome_admin_btn.Name = "welcome_admin_btn";
            this.welcome_admin_btn.Size = new System.Drawing.Size(127, 50);
            this.welcome_admin_btn.TabIndex = 7;
            this.welcome_admin_btn.Text = "Admin";
            this.welcome_admin_btn.UseVisualStyleBackColor = true;
            this.welcome_admin_btn.Click += new System.EventHandler(this.welcome_admin_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Are you an Admin or an Officer?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Welcome_Close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 137);
            this.panel1.TabIndex = 5;
            // 
            // Welcome_Close_btn
            // 
            this.Welcome_Close_btn.FlatAppearance.BorderSize = 0;
            this.Welcome_Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Welcome_Close_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Close_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Welcome_Close_btn.Location = new System.Drawing.Point(1099, 15);
            this.Welcome_Close_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Welcome_Close_btn.Name = "Welcome_Close_btn";
            this.Welcome_Close_btn.Size = new System.Drawing.Size(40, 37);
            this.Welcome_Close_btn.TabIndex = 18;
            this.Welcome_Close_btn.Text = "X";
            this.Welcome_Close_btn.UseVisualStyleBackColor = true;
            this.Welcome_Close_btn.Click += new System.EventHandler(this.Welcome_Close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(352, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crime Investigation";
            // 
            // Welcome_groupbox
            // 
            this.Welcome_groupbox.Controls.Add(this.welcome_officer_btn);
            this.Welcome_groupbox.Controls.Add(this.welcome_admin_btn);
            this.Welcome_groupbox.Controls.Add(this.label2);
            this.Welcome_groupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_groupbox.Location = new System.Drawing.Point(225, 310);
            this.Welcome_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Welcome_groupbox.Name = "Welcome_groupbox";
            this.Welcome_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Welcome_groupbox.Size = new System.Drawing.Size(671, 183);
            this.Welcome_groupbox.TabIndex = 10;
            this.Welcome_groupbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 677);
            this.Controls.Add(this.Welcome_groupbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Welcome_groupbox.ResumeLayout(false);
            this.Welcome_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button welcome_officer_btn;
        private System.Windows.Forms.Button welcome_admin_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Welcome_Close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Welcome_groupbox;
    }
}

