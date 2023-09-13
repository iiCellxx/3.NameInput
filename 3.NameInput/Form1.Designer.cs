namespace _3.NameInput
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            enterB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            fnameTB = new TextBox();
            mnameTB = new TextBox();
            lnameTB = new TextBox();
            barangayTB = new TextBox();
            municipalityTB = new TextBox();
            provinceTB = new TextBox();
            monthTB = new TextBox();
            dayTB = new TextBox();
            yearTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // enterB
            // 
            enterB.BackColor = Color.Silver;
            enterB.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterB.Location = new Point(124, 445);
            enterB.Name = "enterB";
            enterB.Size = new Size(145, 46);
            enterB.TabIndex = 1;
            enterB.Text = "Enter";
            enterB.UseVisualStyleBackColor = false;
            enterB.Click += enterB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 208);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 2;
            label1.Text = "FirstName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 3;
            label2.Text = "MiddleName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 315);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 5;
            label4.Text = "Barangay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 349);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 6;
            label5.Text = "Municipality:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 385);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 7;
            label6.Text = "Province:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(293, 9);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 8;
            label7.Text = "Birthdate:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(293, 45);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 9;
            label8.Text = "Month:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(293, 79);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 10;
            label9.Text = "Day:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(293, 115);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(56, 25);
            label10.TabIndex = 11;
            label10.Text = "Year:";
            // 
            // fnameTB
            // 
            fnameTB.Location = new Point(156, 208);
            fnameTB.Name = "fnameTB";
            fnameTB.Size = new Size(214, 23);
            fnameTB.TabIndex = 12;
            // 
            // mnameTB
            // 
            mnameTB.Location = new Point(156, 245);
            mnameTB.Name = "mnameTB";
            mnameTB.Size = new Size(214, 23);
            mnameTB.TabIndex = 13;
            // 
            // lnameTB
            // 
            lnameTB.Location = new Point(156, 284);
            lnameTB.Name = "lnameTB";
            lnameTB.Size = new Size(214, 23);
            lnameTB.TabIndex = 14;
            // 
            // barangayTB
            // 
            barangayTB.Location = new Point(156, 317);
            barangayTB.Name = "barangayTB";
            barangayTB.Size = new Size(214, 23);
            barangayTB.TabIndex = 15;
            // 
            // municipalityTB
            // 
            municipalityTB.Location = new Point(156, 354);
            municipalityTB.Name = "municipalityTB";
            municipalityTB.Size = new Size(214, 23);
            municipalityTB.TabIndex = 16;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(156, 387);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(214, 23);
            provinceTB.TabIndex = 17;
            // 
            // monthTB
            // 
            monthTB.Location = new Point(376, 47);
            monthTB.Name = "monthTB";
            monthTB.Size = new Size(118, 23);
            monthTB.TabIndex = 18;
            // 
            // dayTB
            // 
            dayTB.Location = new Point(376, 84);
            dayTB.Name = "dayTB";
            dayTB.Size = new Size(118, 23);
            dayTB.TabIndex = 19;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(376, 120);
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(118, 23);
            yearTB.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 503);
            Controls.Add(yearTB);
            Controls.Add(dayTB);
            Controls.Add(monthTB);
            Controls.Add(provinceTB);
            Controls.Add(municipalityTB);
            Controls.Add(barangayTB);
            Controls.Add(lnameTB);
            Controls.Add(mnameTB);
            Controls.Add(fnameTB);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enterB);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button enterB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox fnameTB;
        private TextBox mnameTB;
        private TextBox lnameTB;
        private TextBox barangayTB;
        private TextBox municipalityTB;
        private TextBox provinceTB;
        private TextBox monthTB;
        private TextBox dayTB;
        private TextBox yearTB;
    }
}