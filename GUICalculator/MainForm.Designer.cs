namespace GUICalculator
{
    partial class MainForm
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
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.equalsButton = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.asinButton = new System.Windows.Forms.Button();
            this.acosButton = new System.Windows.Forms.Button();
            this.atanButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.ExpButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.historyDisplay1 = new GUICalculator.HistoryDisplay();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(12, 220);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(504, 20);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTextBox_KeyDown);
            this.mainTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainTextBox_PreviewKeyDown);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(175, 411);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(74, 62);
            this.equalsButton.TabIndex = 1;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(12, 356);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(74, 49);
            this.btnNum1.TabIndex = 2;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.BtnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(92, 356);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(76, 49);
            this.btnNum2.TabIndex = 3;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.BtnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(174, 356);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 49);
            this.btnNum3.TabIndex = 4;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.BtnNum3_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(12, 301);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 49);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.BtnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(93, 301);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(75, 49);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.BtnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(175, 301);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(74, 49);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.BtnNum6_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(12, 246);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 49);
            this.btnNum7.TabIndex = 8;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.BtnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(94, 246);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 49);
            this.btnNum8.TabIndex = 9;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.BtnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(174, 246);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 50);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.BtnNum9_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(12, 411);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(156, 62);
            this.btnNum0.TabIndex = 11;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.BtnNum0_Click);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(359, 246);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(75, 25);
            this.sinButton.TabIndex = 13;
            this.sinButton.Text = "sin()";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(359, 271);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(75, 23);
            this.cosButton.TabIndex = 14;
            this.cosButton.Text = "cos()";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.Location = new System.Drawing.Point(359, 301);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(75, 23);
            this.tanButton.TabIndex = 15;
            this.tanButton.Text = "tan()";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // asinButton
            // 
            this.asinButton.Location = new System.Drawing.Point(359, 326);
            this.asinButton.Name = "asinButton";
            this.asinButton.Size = new System.Drawing.Size(75, 23);
            this.asinButton.TabIndex = 16;
            this.asinButton.Text = "asin()";
            this.asinButton.UseVisualStyleBackColor = true;
            this.asinButton.Click += new System.EventHandler(this.AsinButton_Click);
            // 
            // acosButton
            // 
            this.acosButton.Location = new System.Drawing.Point(359, 355);
            this.acosButton.Name = "acosButton";
            this.acosButton.Size = new System.Drawing.Size(75, 23);
            this.acosButton.TabIndex = 17;
            this.acosButton.Text = "acos()";
            this.acosButton.UseVisualStyleBackColor = true;
            this.acosButton.Click += new System.EventHandler(this.AcosButton_Click);
            // 
            // atanButton
            // 
            this.atanButton.Location = new System.Drawing.Point(359, 381);
            this.atanButton.Name = "atanButton";
            this.atanButton.Size = new System.Drawing.Size(75, 23);
            this.atanButton.TabIndex = 18;
            this.atanButton.Text = "atan()";
            this.atanButton.UseVisualStyleBackColor = true;
            this.atanButton.Click += new System.EventHandler(this.AtanButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(440, 246);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 23);
            this.sqrtButton.TabIndex = 19;
            this.sqrtButton.Text = "sqrt()";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // ExpButton
            // 
            this.ExpButton.Location = new System.Drawing.Point(256, 356);
            this.ExpButton.Name = "ExpButton";
            this.ExpButton.Size = new System.Drawing.Size(75, 23);
            this.ExpButton.TabIndex = 20;
            this.ExpButton.Text = "^";
            this.ExpButton.UseVisualStyleBackColor = true;
            this.ExpButton.Click += new System.EventHandler(this.ExpButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(256, 246);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 23);
            this.PlusButton.TabIndex = 21;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(256, 272);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 22;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(256, 301);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplicationButton.TabIndex = 23;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(256, 327);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(75, 23);
            this.DivisionButton.TabIndex = 24;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // historyDisplay1
            // 
            this.historyDisplay1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.historyDisplay1.Location = new System.Drawing.Point(13, 13);
            this.historyDisplay1.Name = "historyDisplay1";
            this.historyDisplay1.Size = new System.Drawing.Size(503, 201);
            this.historyDisplay1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 494);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.ExpButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.atanButton);
            this.Controls.Add(this.acosButton);
            this.Controls.Add(this.asinButton);
            this.Controls.Add(this.tanButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.historyDisplay1);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.mainTextBox);
            this.Name = "MainForm";
            this.Text = "GUICalc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum0;
        private HistoryDisplay historyDisplay1;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button asinButton;
        private System.Windows.Forms.Button acosButton;
        private System.Windows.Forms.Button atanButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button ExpButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivisionButton;
    }
}

