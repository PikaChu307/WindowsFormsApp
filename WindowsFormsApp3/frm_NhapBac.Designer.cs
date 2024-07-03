namespace WindowsFormsApp3
{
    partial class frm_NhapBac
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
            this.lbl_NhapBac = new System.Windows.Forms.Label();
            this.btn_NhapBac = new System.Windows.Forms.Button();
            this.txt_NhapBac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_NhapBac
            // 
            this.lbl_NhapBac.AutoSize = true;
            this.lbl_NhapBac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapBac.Location = new System.Drawing.Point(35, 62);
            this.lbl_NhapBac.Name = "lbl_NhapBac";
            this.lbl_NhapBac.Size = new System.Drawing.Size(267, 26);
            this.lbl_NhapBac.TabIndex = 0;
            this.lbl_NhapBac.Text = "Nhập vào bậc phương trình";
            // 
            // btn_NhapBac
            // 
            this.btn_NhapBac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapBac.Location = new System.Drawing.Point(199, 153);
            this.btn_NhapBac.Name = "btn_NhapBac";
            this.btn_NhapBac.Size = new System.Drawing.Size(114, 57);
            this.btn_NhapBac.TabIndex = 1;
            this.btn_NhapBac.Text = "OK";
            this.btn_NhapBac.UseVisualStyleBackColor = true;
            this.btn_NhapBac.Click += new System.EventHandler(this.btn_NhapBac_Click);
            // 
            // txt_NhapBac
            // 
            this.txt_NhapBac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapBac.Location = new System.Drawing.Point(357, 62);
            this.txt_NhapBac.Name = "txt_NhapBac";
            this.txt_NhapBac.Size = new System.Drawing.Size(100, 34);
            this.txt_NhapBac.TabIndex = 2;
            // 
            // frm_NhapBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 263);
            this.Controls.Add(this.txt_NhapBac);
            this.Controls.Add(this.btn_NhapBac);
            this.Controls.Add(this.lbl_NhapBac);
            this.Name = "frm_NhapBac";
            this.Text = "Nhập Bậc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NhapBac;
        private System.Windows.Forms.Button btn_NhapBac;
        private System.Windows.Forms.TextBox txt_NhapBac;
    }
}

