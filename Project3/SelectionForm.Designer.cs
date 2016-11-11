namespace Project3
{
    partial class SelectionForm
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
            this.ListBoxCurrentMovies = new System.Windows.Forms.ListBox();
            this.LabelCurrentMovies = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.GroupBoxSelection = new System.Windows.Forms.GroupBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelMovieTitle = new System.Windows.Forms.Label();
            this.PictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.GroupBoxSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxCurrentMovies
            // 
            this.ListBoxCurrentMovies.FormattingEnabled = true;
            this.ListBoxCurrentMovies.Items.AddRange(new object[] {
            ""});
            this.ListBoxCurrentMovies.Location = new System.Drawing.Point(33, 104);
            this.ListBoxCurrentMovies.Name = "ListBoxCurrentMovies";
            this.ListBoxCurrentMovies.ScrollAlwaysVisible = true;
            this.ListBoxCurrentMovies.Size = new System.Drawing.Size(186, 225);
            this.ListBoxCurrentMovies.TabIndex = 1;
            this.ListBoxCurrentMovies.SelectedIndexChanged += new System.EventHandler(this.ListBoxCurrentMovies_SelectedIndexChanged);
            // 
            // LabelCurrentMovies
            // 
            this.LabelCurrentMovies.AutoSize = true;
            this.LabelCurrentMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentMovies.Location = new System.Drawing.Point(30, 76);
            this.LabelCurrentMovies.Name = "LabelCurrentMovies";
            this.LabelCurrentMovies.Size = new System.Drawing.Size(100, 16);
            this.LabelCurrentMovies.TabIndex = 2;
            this.LabelCurrentMovies.Text = "Current Movies:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(138, 35);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(427, 24);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Choose the movie to STREAM from the list below!";
            // 
            // GroupBoxSelection
            // 
            this.GroupBoxSelection.Controls.Add(this.PictureBoxMovie);
            this.GroupBoxSelection.Controls.Add(this.TextBoxCost);
            this.GroupBoxSelection.Controls.Add(this.TextBoxTitle);
            this.GroupBoxSelection.Controls.Add(this.TextBoxCategory);
            this.GroupBoxSelection.Controls.Add(this.LabelCost);
            this.GroupBoxSelection.Controls.Add(this.LabelCategory);
            this.GroupBoxSelection.Controls.Add(this.LabelMovieTitle);
            this.GroupBoxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSelection.Location = new System.Drawing.Point(244, 98);
            this.GroupBoxSelection.Name = "GroupBoxSelection";
            this.GroupBoxSelection.Size = new System.Drawing.Size(479, 243);
            this.GroupBoxSelection.TabIndex = 4;
            this.GroupBoxSelection.TabStop = false;
            this.GroupBoxSelection.Text = "Your Selection";
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(351, 123);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.ReadOnly = true;
            this.TextBoxCost.Size = new System.Drawing.Size(95, 22);
            this.TextBoxCost.TabIndex = 6;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(174, 52);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.ReadOnly = true;
            this.TextBoxTitle.Size = new System.Drawing.Size(272, 22);
            this.TextBoxTitle.TabIndex = 5;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(174, 123);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.ReadOnly = true;
            this.TextBoxCategory.Size = new System.Drawing.Size(147, 22);
            this.TextBoxCategory.TabIndex = 4;
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(359, 104);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(35, 16);
            this.LabelCost.TabIndex = 3;
            this.LabelCost.Text = "Cost";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(189, 104);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(63, 16);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Category";
            // 
            // LabelMovieTitle
            // 
            this.LabelMovieTitle.AutoSize = true;
            this.LabelMovieTitle.Location = new System.Drawing.Point(189, 33);
            this.LabelMovieTitle.Name = "LabelMovieTitle";
            this.LabelMovieTitle.Size = new System.Drawing.Size(34, 16);
            this.LabelMovieTitle.TabIndex = 1;
            this.LabelMovieTitle.Text = "Title";
            // 
            // PictureBoxMovie
            // 
            this.PictureBoxMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxMovie.Location = new System.Drawing.Point(6, 24);
            this.PictureBoxMovie.Name = "PictureBoxMovie";
            this.PictureBoxMovie.Size = new System.Drawing.Size(153, 193);
            this.PictureBoxMovie.TabIndex = 7;
            this.PictureBoxMovie.TabStop = false;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Enabled = false;
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(595, 350);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(95, 23);
            this.ButtonNext.TabIndex = 5;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 385);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.GroupBoxSelection);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelCurrentMovies);
            this.Controls.Add(this.ListBoxCurrentMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notflix the Streaming Service";
            this.GroupBoxSelection.ResumeLayout(false);
            this.GroupBoxSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxCurrentMovies;
        private System.Windows.Forms.Label LabelCurrentMovies;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.GroupBox GroupBoxSelection;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelMovieTitle;
        private System.Windows.Forms.PictureBox PictureBoxMovie;
        private System.Windows.Forms.Button ButtonNext;
    }
}

