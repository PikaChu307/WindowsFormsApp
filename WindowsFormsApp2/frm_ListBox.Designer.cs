﻿namespace WindowsFormsApp2
{
    partial class frm_ListBox
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
            this.lib_A = new System.Windows.Forms.ListBox();
            this.lib_B = new System.Windows.Forms.ListBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.cb_Ho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lib_A
            // 
            this.lib_A.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lib_A.FormattingEnabled = true;
            this.lib_A.ItemHeight = 26;
            this.lib_A.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Văn B",
            "Trần Văn C",
            "Trần Văn D",
            "Lê Phước Ý",
            "Lê Phước Tùng"});
            this.lib_A.Location = new System.Drawing.Point(135, 121);
            this.lib_A.Name = "lib_A";
            this.lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lib_A.Size = new System.Drawing.Size(199, 186);
            this.lib_A.TabIndex = 0;
            // 
            // lib_B
            // 
            this.lib_B.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lib_B.FormattingEnabled = true;
            this.lib_B.ItemHeight = 26;
            this.lib_B.Location = new System.Drawing.Point(479, 121);
            this.lib_B.Name = "lib_B";
            this.lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lib_B.Size = new System.Drawing.Size(204, 186);
            this.lib_B.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(368, 121);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 35);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(368, 173);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 35);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(368, 225);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 35);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(368, 272);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 35);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // cb_Ho
            // 
            this.cb_Ho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ho.FormattingEnabled = true;
            this.cb_Ho.Location = new System.Drawing.Point(87, 41);
            this.cb_Ho.Name = "cb_Ho";
            this.cb_Ho.Size = new System.Drawing.Size(118, 34);
            this.cb_Ho.TabIndex = 6;
            this.cb_Ho.SelectedIndexChanged += new System.EventHandler(this.cb_Ho_SelectedIndexChanged);
            // 
            // frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Ho);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lib_B);
            this.Controls.Add(this.lib_A);
            this.Name = "frm_ListBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_ListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lib_A;
        private System.Windows.Forms.ListBox lib_B;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.ComboBox cb_Ho;
    }
}
