namespace GuessTheNumberWF
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
            this.triedNumbers = new System.Windows.Forms.Label();
            this.you = new System.Windows.Forms.Label();
            this.opponent = new System.Windows.Forms.Label();
            this.youScore = new System.Windows.Forms.Label();
            this.opponentScore = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.userNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // triedNumbers
            // 
            this.triedNumbers.BackColor = System.Drawing.Color.Navy;
            this.triedNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.triedNumbers.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triedNumbers.ForeColor = System.Drawing.Color.White;
            this.triedNumbers.Location = new System.Drawing.Point(0, 0);
            this.triedNumbers.Name = "triedNumbers";
            this.triedNumbers.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.triedNumbers.Size = new System.Drawing.Size(762, 62);
            this.triedNumbers.TabIndex = 0;
            this.triedNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // you
            // 
            this.you.AutoSize = true;
            this.you.Font = new System.Drawing.Font("Calibri", 14F);
            this.you.Location = new System.Drawing.Point(141, 226);
            this.you.Name = "you";
            this.you.Size = new System.Drawing.Size(43, 23);
            this.you.TabIndex = 1;
            this.you.Text = "You:";
            // 
            // opponent
            // 
            this.opponent.AutoSize = true;
            this.opponent.Font = new System.Drawing.Font("Calibri", 14F);
            this.opponent.Location = new System.Drawing.Point(91, 276);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(93, 23);
            this.opponent.TabIndex = 2;
            this.opponent.Text = "Opponent:";
            // 
            // youScore
            // 
            this.youScore.AutoSize = true;
            this.youScore.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.youScore.Location = new System.Drawing.Point(203, 225);
            this.youScore.Name = "youScore";
            this.youScore.Size = new System.Drawing.Size(20, 24);
            this.youScore.TabIndex = 3;
            this.youScore.Text = "0";
            // 
            // opponentScore
            // 
            this.opponentScore.AutoSize = true;
            this.opponentScore.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.opponentScore.Location = new System.Drawing.Point(203, 276);
            this.opponentScore.Name = "opponentScore";
            this.opponentScore.Size = new System.Drawing.Size(20, 24);
            this.opponentScore.TabIndex = 4;
            this.opponentScore.Text = "0";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.counter.ForeColor = System.Drawing.Color.Black;
            this.counter.Location = new System.Drawing.Point(426, 177);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(23, 27);
            this.counter.TabIndex = 5;
            this.counter.Text = "5";
            // 
            // userNumber
            // 
            this.userNumber.Font = new System.Drawing.Font("Calibri", 15F);
            this.userNumber.Location = new System.Drawing.Point(431, 225);
            this.userNumber.MaxLength = 3;
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(189, 32);
            this.userNumber.TabIndex = 6;
            this.userNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(431, 276);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(189, 39);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check Number";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Orange;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.Location = new System.Drawing.Point(431, 276);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(189, 39);
            this.restart.TabIndex = 8;
            this.restart.Text = "Play Again";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // status
            // 
            this.status.Dock = System.Windows.Forms.DockStyle.Top;
            this.status.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.status.Location = new System.Drawing.Point(0, 62);
            this.status.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.status.Size = new System.Drawing.Size(762, 39);
            this.status.TabIndex = 9;
            this.status.Text = "Enter a number between 1 and 100.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 452);
            this.Controls.Add(this.status);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.triedNumbers);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.userNumber);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.opponentScore);
            this.Controls.Add(this.youScore);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.you);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Funny Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label triedNumbers;
        private System.Windows.Forms.Label you;
        private System.Windows.Forms.Label opponent;
        private System.Windows.Forms.Label youScore;
        private System.Windows.Forms.Label opponentScore;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.TextBox userNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label status;
    }
}

