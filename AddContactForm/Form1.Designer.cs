namespace AddContactForm
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLuu_Click = new System.Windows.Forms.Button();
            this.btnThemLienHe_Click = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(159, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(159, 95);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(100, 22);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại";
            // 
            // BtnLuu_Click
            // 
            this.BtnLuu_Click.Location = new System.Drawing.Point(75, 146);
            this.BtnLuu_Click.Name = "BtnLuu_Click";
            this.BtnLuu_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnLuu_Click.TabIndex = 4;
            this.BtnLuu_Click.Text = "Lưu";
            this.BtnLuu_Click.UseVisualStyleBackColor = true;
            this.BtnLuu_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemLienHe_Click
            // 
            this.btnThemLienHe_Click.Location = new System.Drawing.Point(222, 146);
            this.btnThemLienHe_Click.Name = "btnThemLienHe_Click";
            this.btnThemLienHe_Click.Size = new System.Drawing.Size(103, 23);
            this.btnThemLienHe_Click.TabIndex = 5;
            this.btnThemLienHe_Click.Text = "Thêm liên hệ";
            this.btnThemLienHe_Click.UseVisualStyleBackColor = true;
            this.btnThemLienHe_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(368, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(415, 59);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 22);
            this.txt_Email.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnThemLienHe_Click);
            this.Controls.Add(this.BtnLuu_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLuu_Click;
        private System.Windows.Forms.Button btnThemLienHe_Click;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_Email;
    }
}

