namespace Chess
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.WhiteTimeDisplay = new System.Windows.Forms.Label();
            this.BlackTimeDisplay = new System.Windows.Forms.Label();
            this.P1Name = new System.Windows.Forms.Label();
            this.P2Name = new System.Windows.Forms.Label();
            this.ResignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhiteTimeDisplay
            // 
            this.WhiteTimeDisplay.AutoSize = true;
            this.WhiteTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteTimeDisplay.Location = new System.Drawing.Point(580, 55);
            this.WhiteTimeDisplay.Name = "WhiteTimeDisplay";
            this.WhiteTimeDisplay.Size = new System.Drawing.Size(22, 31);
            this.WhiteTimeDisplay.TabIndex = 0;
            this.WhiteTimeDisplay.Text = ".";
            // 
            // BlackTimeDisplay
            // 
            this.BlackTimeDisplay.AutoSize = true;
            this.BlackTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackTimeDisplay.Location = new System.Drawing.Point(580, 755);
            this.BlackTimeDisplay.Name = "BlackTimeDisplay";
            this.BlackTimeDisplay.Size = new System.Drawing.Size(22, 31);
            this.BlackTimeDisplay.TabIndex = 1;
            this.BlackTimeDisplay.Text = ".";
            // 
            // P1Name
            // 
            this.P1Name.AutoSize = true;
            this.P1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Name.Location = new System.Drawing.Point(20, 755);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(113, 31);
            this.P1Name.TabIndex = 4;
            this.P1Name.Text = "Player 1";
            // 
            // P2Name
            // 
            this.P2Name.AutoSize = true;
            this.P2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Name.Location = new System.Drawing.Point(20, 55);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(113, 31);
            this.P2Name.TabIndex = 5;
            this.P2Name.Text = "Player 2";
            // 
            // ResignButton
            // 
            this.ResignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResignButton.ForeColor = System.Drawing.Color.Black;
            this.ResignButton.Location = new System.Drawing.Point(784, 753);
            this.ResignButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResignButton.Name = "ResignButton";
            this.ResignButton.Size = new System.Drawing.Size(102, 48);
            this.ResignButton.TabIndex = 7;
            this.ResignButton.Text = "Resign";
            this.ResignButton.UseVisualStyleBackColor = false;
            this.ResignButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 853);
            this.Controls.Add(this.ResignButton);
            this.Controls.Add(this.P2Name);
            this.Controls.Add(this.P1Name);
            this.Controls.Add(this.BlackTimeDisplay);
            this.Controls.Add(this.WhiteTimeDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(999, 899);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label P1Name;
        private System.Windows.Forms.Label P2Name;
        private System.Windows.Forms.Button ResignButton;
        public System.Windows.Forms.Label WhiteTimeDisplay;
        public System.Windows.Forms.Label BlackTimeDisplay;
    }
}