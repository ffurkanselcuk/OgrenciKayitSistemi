namespace WinFormsApp1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.lblTotalCoast = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.rdnBtn = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPayment.Location = new System.Drawing.Point(172, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(54, 15);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            this.lblPayment.Click += new System.EventHandler(this.lblCompletePayment_Click);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(14, 134);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(114, 15);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name And Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(138, 131);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(121, 23);
            this.cmbStudentName.TabIndex = 9;
            // 
            // lblTotalCoast
            // 
            this.lblTotalCoast.AutoSize = true;
            this.lblTotalCoast.Location = new System.Drawing.Point(14, 180);
            this.lblTotalCoast.Name = "lblTotalCoast";
            this.lblTotalCoast.Size = new System.Drawing.Size(65, 15);
            this.lblTotalCoast.TabIndex = 6;
            this.lblTotalCoast.Text = "Total Coast";
            this.lblTotalCoast.Click += new System.EventHandler(this.lblFee_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkGray;
            this.btnPay.Location = new System.Drawing.Point(254, 229);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(361, 229);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 70);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(79, 15);
            this.lblCourseName.TabIndex = 7;
            this.lblCourseName.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(138, 67);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(121, 23);
            this.cmbCourseName.TabIndex = 7;
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_SelectedIndexChanged);
            // 
            // rdnBtn
            // 
            this.rdnBtn.AutoSize = true;
            this.rdnBtn.Location = new System.Drawing.Point(265, 178);
            this.rdnBtn.Name = "rdnBtn";
            this.rdnBtn.Size = new System.Drawing.Size(54, 19);
            this.rdnBtn.TabIndex = 11;
            this.rdnBtn.TabStop = true;
            this.rdnBtn.Text = "Show";
            this.rdnBtn.UseVisualStyleBackColor = true;
            this.rdnBtn.CheckedChanged += new System.EventHandler(this.rdnBtn_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(179, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "********";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 283);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rdnBtn);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalCoast);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblPayment);
            this.Name = "Form7";
            this.Text = "Complete Payment";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.Label lblTotalCoast;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.RadioButton rdnBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblTotal;
    }
}