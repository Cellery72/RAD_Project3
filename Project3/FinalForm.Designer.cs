namespace Project3
{
    partial class FinalForm
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
            this.LabelMessage = new System.Windows.Forms.Label();
            this.LabelMovie = new System.Windows.Forms.Label();
            this.LabelPurchase = new System.Windows.Forms.Label();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(142, 25);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(189, 16);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.Text = "Thank you for choosing Notflix!";
            // 
            // LabelMovie
            // 
            this.LabelMovie.AutoSize = true;
            this.LabelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMovie.Location = new System.Drawing.Point(119, 104);
            this.LabelMovie.Name = "LabelMovie";
            this.LabelMovie.Size = new System.Drawing.Size(222, 16);
            this.LabelMovie.TabIndex = 1;
            this.LabelMovie.Text = "Your movie is going to begin shortly!";
            // 
            // LabelPurchase
            // 
            this.LabelPurchase.AutoSize = true;
            this.LabelPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPurchase.Location = new System.Drawing.Point(100, 61);
            this.LabelPurchase.Name = "LabelPurchase";
            this.LabelPurchase.Size = new System.Drawing.Size(264, 16);
            this.LabelPurchase.TabIndex = 2;
            this.LabelPurchase.Text = "We have succesfully charged your card for ";
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.Location = new System.Drawing.Point(178, 157);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(104, 34);
            this.ButtonPlay.TabIndex = 3;
            this.ButtonPlay.Text = "Play!";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(451, 219);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.LabelPurchase);
            this.Controls.Add(this.LabelMovie);
            this.Controls.Add(this.LabelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Movie is About to Start!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label LabelMovie;
        private System.Windows.Forms.Label LabelPurchase;
        private System.Windows.Forms.Button ButtonPlay;
    }
}