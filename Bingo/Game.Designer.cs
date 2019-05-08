namespace Bingo
{
    partial class Game
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
            this.GetBoardBtn = new System.Windows.Forms.Button();
            this.GetNumberBtn = new System.Windows.Forms.Button();
            this.ShowNumberTextBox = new System.Windows.Forms.TextBox();
            this.newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetBoardBtn
            // 
            this.GetBoardBtn.BackColor = System.Drawing.Color.Orange;
            this.GetBoardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetBoardBtn.Location = new System.Drawing.Point(15, 207);
            this.GetBoardBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.GetBoardBtn.Name = "GetBoardBtn";
            this.GetBoardBtn.Size = new System.Drawing.Size(230, 90);
            this.GetBoardBtn.TabIndex = 0;
            this.GetBoardBtn.Text = "Get Bingo board";
            this.GetBoardBtn.UseVisualStyleBackColor = false;
            this.GetBoardBtn.Click += new System.EventHandler(this.GetBoardBtn_Click);
            // 
            // GetNumberBtn
            // 
            this.GetNumberBtn.BackColor = System.Drawing.Color.Orange;
            this.GetNumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNumberBtn.Location = new System.Drawing.Point(605, 207);
            this.GetNumberBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.GetNumberBtn.Name = "GetNumberBtn";
            this.GetNumberBtn.Size = new System.Drawing.Size(260, 90);
            this.GetNumberBtn.TabIndex = 1;
            this.GetNumberBtn.Text = "Get Number";
            this.GetNumberBtn.UseVisualStyleBackColor = false;
            this.GetNumberBtn.Click += new System.EventHandler(this.GetNumberBtn_Click);
            // 
            // ShowNumberTextBox
            // 
            this.ShowNumberTextBox.BackColor = System.Drawing.Color.DarkCyan;
            this.ShowNumberTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ShowNumberTextBox.Location = new System.Drawing.Point(252, 43);
            this.ShowNumberTextBox.Name = "ShowNumberTextBox";
            this.ShowNumberTextBox.Size = new System.Drawing.Size(345, 41);
            this.ShowNumberTextBox.TabIndex = 3;
            this.ShowNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newGame.Location = new System.Drawing.Point(19, 41);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(225, 43);
            this.newGame.TabIndex = 5;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.ShowNumberTextBox);
            this.Controls.Add(this.GetNumberBtn);
            this.Controls.Add(this.GetBoardBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetBoardBtn;
        private System.Windows.Forms.Button GetNumberBtn;
        private System.Windows.Forms.TextBox ShowNumberTextBox;
        private System.Windows.Forms.Button newGame;
    }
}