
namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMultiply = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnClear = new Button();
            btnPow = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ScrollBars = ScrollBars.Horizontal;
            txtDisplay.Size = new Size(384, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 57);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 55);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(67, 57);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 55);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(122, 57);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 55);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 119);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 55);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(67, 119);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 55);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(122, 119);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 55);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(177, 57);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(49, 55);
            btnOpenParenthesis.TabIndex = 7;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += button7_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(232, 57);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(49, 55);
            btnCloseParenthesis.TabIndex = 8;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(287, 57);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 55);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 241);
            btn0.Name = "btn0";
            btn0.Size = new Size(104, 64);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(122, 241);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(49, 64);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += button11_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 180);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 55);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(67, 180);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 55);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(122, 180);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 55);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(177, 119);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(49, 55);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(177, 182);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(49, 53);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(232, 119);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(49, 55);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(232, 182);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(49, 53);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(287, 119);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 55);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(287, 182);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(108, 53);
            btnPow.TabIndex = 20;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(177, 241);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(218, 64);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(408, 329);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btn0;
        private Button btnDot;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMultiply;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnClear;
        private Button btnPow;
        private Button btnResult;
    }
}
