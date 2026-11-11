namespace Calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btndot = new Button();
            btnsubtract = new Button();
            btnadd = new Button();
            btnmultiply = new Button();
            btndivide = new Button();
            txtdisplay = new TextBox();
            btnclear = new Button();
            btnclearentry = new Button();
            btnequals = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(223, 248);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 52);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(275, 248);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 52);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(327, 248);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 52);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(223, 190);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 52);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(327, 190);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 52);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(275, 132);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 52);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(223, 306);
            btn0.Name = "btn0";
            btn0.Size = new Size(98, 52);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(327, 132);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 52);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(223, 132);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 52);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(275, 190);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 52);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndot.Location = new Point(327, 306);
            btndot.Name = "btndot";
            btndot.Size = new Size(46, 52);
            btndot.TabIndex = 10;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btnsubtract
            // 
            btnsubtract.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsubtract.Location = new Point(379, 248);
            btnsubtract.Name = "btnsubtract";
            btnsubtract.Size = new Size(46, 52);
            btnsubtract.TabIndex = 13;
            btnsubtract.Text = "-";
            btnsubtract.UseVisualStyleBackColor = true;
            btnsubtract.Click += button3_Click_1;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(379, 306);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(46, 52);
            btnadd.TabIndex = 14;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmultiply.Location = new Point(379, 190);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(46, 52);
            btnmultiply.TabIndex = 15;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btnmultiply_Click_1;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndivide.Location = new Point(379, 132);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(46, 52);
            btndivide.TabIndex = 16;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click_1;
            // 
            // txtdisplay
            // 
            txtdisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdisplay.Location = new Point(223, 88);
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(262, 38);
            txtdisplay.TabIndex = 17;
            txtdisplay.Text = "0";
            txtdisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(431, 132);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(54, 52);
            btnclear.TabIndex = 18;
            btnclear.Text = "CE";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnclearentry
            // 
            btnclearentry.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclearentry.Location = new Point(431, 190);
            btnclearentry.Name = "btnclearentry";
            btnclearentry.Size = new Size(54, 52);
            btnclearentry.TabIndex = 19;
            btnclearentry.Text = "C";
            btnclearentry.UseVisualStyleBackColor = true;
            btnclearentry.Click += btnclearentry_Click;
            // 
            // btnequals
            // 
            btnequals.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnequals.Location = new Point(431, 248);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(54, 110);
            btnequals.TabIndex = 20;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = true;
            btnequals.Click += btnequals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnequals);
            Controls.Add(btnclearentry);
            Controls.Add(btnclear);
            Controls.Add(txtdisplay);
            Controls.Add(btndivide);
            Controls.Add(btnmultiply);
            Controls.Add(btnadd);
            Controls.Add(btnsubtract);
            Controls.Add(btndot);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn6;
        private Button btn8;
        private Button btn0;
        private Button btn9;
        private Button btn7;
        private Button btn5;
        private Button btndot;
        private Button btnclearentry;
        private Button button2;
        private Button btnsubtract;
        private Button btnadd;
        private Button btnmultiply;
        private Button btndivide;
        private TextBox txtdisplay;
        private Button btnclear;
        private Button btnequals;
    }
}
