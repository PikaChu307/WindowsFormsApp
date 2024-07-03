namespace WindowsFormsApp1
{
    partial class frm_NhapMang
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
            this.btb_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_TongMangA = new System.Windows.Forms.TextBox();
            this.lbl_TongMangA = new System.Windows.Forms.Label();
            this.txt_TongChan = new System.Windows.Forms.TextBox();
            this.lbl_TongChan = new System.Windows.Forms.Label();
            this.txt_TongLe = new System.Windows.Forms.TextBox();
            this.lbl_TongLe = new System.Windows.Forms.Label();
            this.txtMangA = new System.Windows.Forms.TextBox();
            this.lbl_MangA = new System.Windows.Forms.Label();
            this.btn_TinhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btb_Thoat
            // 
            this.btb_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_Thoat.Location = new System.Drawing.Point(507, 384);
            this.btb_Thoat.Name = "btb_Thoat";
            this.btb_Thoat.Size = new System.Drawing.Size(137, 37);
            this.btb_Thoat.TabIndex = 25;
            this.btb_Thoat.Text = "Thoát";
            this.btb_Thoat.UseVisualStyleBackColor = true;
            this.btb_Thoat.Click += new System.EventHandler(this.btb_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(317, 384);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(137, 37);
            this.btn_LamMoi.TabIndex = 24;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_TongMangA
            // 
            this.txt_TongMangA.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongMangA.Location = new System.Drawing.Point(347, 289);
            this.txt_TongMangA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongMangA.Name = "txt_TongMangA";
            this.txt_TongMangA.Size = new System.Drawing.Size(254, 33);
            this.txt_TongMangA.TabIndex = 23;
            // 
            // lbl_TongMangA
            // 
            this.lbl_TongMangA.AutoSize = true;
            this.lbl_TongMangA.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongMangA.Location = new System.Drawing.Point(139, 297);
            this.lbl_TongMangA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TongMangA.Name = "lbl_TongMangA";
            this.lbl_TongMangA.Size = new System.Drawing.Size(197, 25);
            this.lbl_TongMangA.TabIndex = 22;
            this.lbl_TongMangA.Text = "Tổng các số mảng A ";
            // 
            // txt_TongChan
            // 
            this.txt_TongChan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongChan.Location = new System.Drawing.Point(347, 202);
            this.txt_TongChan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongChan.Name = "txt_TongChan";
            this.txt_TongChan.Size = new System.Drawing.Size(254, 33);
            this.txt_TongChan.TabIndex = 21;
            // 
            // lbl_TongChan
            // 
            this.lbl_TongChan.AutoSize = true;
            this.lbl_TongChan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongChan.Location = new System.Drawing.Point(139, 210);
            this.lbl_TongChan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TongChan.Name = "lbl_TongChan";
            this.lbl_TongChan.Size = new System.Drawing.Size(165, 25);
            this.lbl_TongChan.TabIndex = 20;
            this.lbl_TongChan.Text = "Tổng các số chẵn";
            // 
            // txt_TongLe
            // 
            this.txt_TongLe.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongLe.Location = new System.Drawing.Point(347, 131);
            this.txt_TongLe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongLe.Name = "txt_TongLe";
            this.txt_TongLe.Size = new System.Drawing.Size(254, 33);
            this.txt_TongLe.TabIndex = 19;
            // 
            // lbl_TongLe
            // 
            this.lbl_TongLe.AutoSize = true;
            this.lbl_TongLe.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongLe.Location = new System.Drawing.Point(139, 134);
            this.lbl_TongLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TongLe.Name = "lbl_TongLe";
            this.lbl_TongLe.Size = new System.Drawing.Size(141, 25);
            this.lbl_TongLe.TabIndex = 18;
            this.lbl_TongLe.Text = "Tổng các số lẻ";
            // 
            // txtMangA
            // 
            this.txtMangA.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMangA.Location = new System.Drawing.Point(347, 39);
            this.txtMangA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMangA.Name = "txtMangA";
            this.txtMangA.Size = new System.Drawing.Size(254, 33);
            this.txtMangA.TabIndex = 17;
            // 
            // lbl_MangA
            // 
            this.lbl_MangA.AutoSize = true;
            this.lbl_MangA.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MangA.Location = new System.Drawing.Point(139, 47);
            this.lbl_MangA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MangA.Name = "lbl_MangA";
            this.lbl_MangA.Size = new System.Drawing.Size(82, 25);
            this.lbl_MangA.TabIndex = 16;
            this.lbl_MangA.Text = "Mảng A";
            // 
            // btn_TinhToan
            // 
            this.btn_TinhToan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhToan.Location = new System.Drawing.Point(129, 384);
            this.btn_TinhToan.Name = "btn_TinhToan";
            this.btn_TinhToan.Size = new System.Drawing.Size(137, 37);
            this.btn_TinhToan.TabIndex = 26;
            this.btn_TinhToan.Text = "Tính Toán";
            this.btn_TinhToan.UseVisualStyleBackColor = true;
            this.btn_TinhToan.Click += new System.EventHandler(this.btn_TinhToan_Click);
            // 
            // frm_NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TinhToan);
            this.Controls.Add(this.btb_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.txt_TongMangA);
            this.Controls.Add(this.lbl_TongMangA);
            this.Controls.Add(this.txt_TongChan);
            this.Controls.Add(this.lbl_TongChan);
            this.Controls.Add(this.txt_TongLe);
            this.Controls.Add(this.lbl_TongLe);
            this.Controls.Add(this.txtMangA);
            this.Controls.Add(this.lbl_MangA);
            this.Name = "frm_NhapMang";
            this.Text = "frm_NhapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_TongMangA;
        private System.Windows.Forms.Label lbl_TongMangA;
        private System.Windows.Forms.TextBox txt_TongChan;
        private System.Windows.Forms.Label lbl_TongChan;
        private System.Windows.Forms.TextBox txt_TongLe;
        private System.Windows.Forms.Label lbl_TongLe;
        private System.Windows.Forms.TextBox txtMangA;
        private System.Windows.Forms.Label lbl_MangA;
        private System.Windows.Forms.Button btn_TinhToan;
    }
}