namespace PlayGame
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.CountDown1 = new System.Windows.Forms.Label();
            this.CountDown2 = new System.Windows.Forms.Label();
            this.CountDown3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "start ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.player1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1.Location = new System.Drawing.Point(286, 150);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(218, 36);
            this.player1.TabIndex = 1;
            this.player1.Text = "Ready Player 1";
            // 
            // CountDown1
            // 
            this.CountDown1.AutoSize = true;
            this.CountDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountDown1.Location = new System.Drawing.Point(160, 54);
            this.CountDown1.Name = "CountDown1";
            this.CountDown1.Size = new System.Drawing.Size(20, 24);
            this.CountDown1.TabIndex = 2;
            this.CountDown1.Text = "1";
            // 
            // CountDown2
            // 
            this.CountDown2.AutoSize = true;
            this.CountDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountDown2.Location = new System.Drawing.Point(383, 54);
            this.CountDown2.Name = "CountDown2";
            this.CountDown2.Size = new System.Drawing.Size(20, 24);
            this.CountDown2.TabIndex = 3;
            this.CountDown2.Text = "2";
            // 
            // CountDown3
            // 
            this.CountDown3.AutoSize = true;
            this.CountDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountDown3.Location = new System.Drawing.Point(607, 54);
            this.CountDown3.Name = "CountDown3";
            this.CountDown3.Size = new System.Drawing.Size(20, 24);
            this.CountDown3.TabIndex = 4;
            this.CountDown3.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountDown3);
            this.Controls.Add(this.CountDown2);
            this.Controls.Add(this.CountDown1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label CountDown1;
        private System.Windows.Forms.Label CountDown2;
        private System.Windows.Forms.Label CountDown3;
    }
}

