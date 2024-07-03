namespace WindowsFormsApp1
{
    partial class frm_TimThu
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
            this.lbl_Thu = new System.Windows.Forms.Label();
            this.txt_Thu = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Thu
            // 
            this.lbl_Thu.AutoSize = true;
            this.lbl_Thu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thu.Location = new System.Drawing.Point(74, 88);
            this.lbl_Thu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Thu.Name = "lbl_Thu";
            this.lbl_Thu.Size = new System.Drawing.Size(48, 25);
            this.lbl_Thu.TabIndex = 0;
            this.lbl_Thu.Text = "Thứ";
            // 
            // txt_Thu
            // 
            this.txt_Thu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thu.Location = new System.Drawing.Point(221, 93);
            this.txt_Thu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Thu.Name = "txt_Thu";
            this.txt_Thu.Size = new System.Drawing.Size(254, 33);
            this.txt_Thu.TabIndex = 1;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(221, 237);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(256, 45);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // frm_TimThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Thu);
            this.Controls.Add(this.lbl_Thu);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_TimThu";
            this.Text = "frm_TimThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Thu;
        private System.Windows.Forms.TextBox txt_Thu;
        private System.Windows.Forms.Button btn_Tim;
    }
}