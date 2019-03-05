namespace TicTac
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 72);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 90);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 72);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 168);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 72);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(93, 168);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 72);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(93, 90);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 72);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(93, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 72);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(174, 168);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 72);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(174, 90);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 72);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(174, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 72);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(259, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 264);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 264);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 25);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // XWin
            // 
            this.XWin.AutoSize = true;
            this.XWin.Location = new System.Drawing.Point(284, 42);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(35, 13);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.AutoSize = true;
            this.OWin.Location = new System.Drawing.Point(284, 121);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(35, 13);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(284, 198);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(35, 13);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 350);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
    }
}

