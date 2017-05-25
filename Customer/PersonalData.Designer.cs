namespace Customer
{
    partial class PersonalData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.pncTxt = new System.Windows.Forms.TextBox();
            this.rentDate = new System.Windows.Forms.DateTimePicker();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PNC";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(102, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // pncTxt
            // 
            this.pncTxt.Location = new System.Drawing.Point(102, 108);
            this.pncTxt.Name = "pncTxt";
            this.pncTxt.Size = new System.Drawing.Size(100, 20);
            this.pncTxt.TabIndex = 4;
            // 
            // rentDate
            // 
            this.rentDate.Location = new System.Drawing.Point(57, 178);
            this.rentDate.Name = "rentDate";
            this.rentDate.Size = new System.Drawing.Size(200, 20);
            this.rentDate.TabIndex = 5;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(111, 267);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Return Date";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(57, 231);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 20);
            this.returnDate.TabIndex = 8;
            // 
            // PersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.rentDate);
            this.Controls.Add(this.pncTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalData";
            this.Text = "PersonalData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox pncTxt;
        private System.Windows.Forms.DateTimePicker rentDate;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker returnDate;
    }
}