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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LabelCurrentMovies = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.GroupBoxSelection = new System.Windows.Forms.GroupBox();
            this.ListBoxSelected = new System.Windows.Forms.ListBox();
            this.LabelMovieTitle = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.GroupBoxSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Season of the Witch",
            "The Green Hornet",
            "The Dilemma ",
            "Death Race 2 ",
            "Company Men ",
            "No Strings Attached ",
            "The Way Back ",
            "The Mechanic ",
            "The Rite ",
            "Sanctum ",
            "The Other Woman ",
            "The Roommate ",
            "Waiting for Forever ",
            "Cedar Rapids ",
            "Gnomeo and Juliet ",
            "Just Go With It ",
            "The Eagle ",
            "I am Number Four ",
            "Footloose ",
            "Real Steel"});
            this.listBox1.Location = new System.Drawing.Point(54, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(140, 212);
            this.listBox1.TabIndex = 1;
            // 
            // LabelCurrentMovies
            // 
            this.LabelCurrentMovies.AutoSize = true;
            this.LabelCurrentMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentMovies.Location = new System.Drawing.Point(79, 98);
            this.LabelCurrentMovies.Name = "LabelCurrentMovies";
            this.LabelCurrentMovies.Size = new System.Drawing.Size(97, 16);
            this.LabelCurrentMovies.TabIndex = 2;
            this.LabelCurrentMovies.Text = "Current Movies";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(57, 19);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(436, 24);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Choose the movies to STREAM from the list below!";
            // 
            // GroupBoxSelection
            // 
            this.GroupBoxSelection.Controls.Add(this.TextBoxCost);
            this.GroupBoxSelection.Controls.Add(this.TextBoxTitle);
            this.GroupBoxSelection.Controls.Add(this.TextBoxCategory);
            this.GroupBoxSelection.Controls.Add(this.LabelCost);
            this.GroupBoxSelection.Controls.Add(this.LabelCategory);
            this.GroupBoxSelection.Controls.Add(this.LabelMovieTitle);
            this.GroupBoxSelection.Controls.Add(this.ListBoxSelected);
            this.GroupBoxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSelection.Location = new System.Drawing.Point(244, 98);
            this.GroupBoxSelection.Name = "GroupBoxSelection";
            this.GroupBoxSelection.Size = new System.Drawing.Size(464, 246);
            this.GroupBoxSelection.TabIndex = 4;
            this.GroupBoxSelection.TabStop = false;
            this.GroupBoxSelection.Text = "Your Selection";
            // 
            // ListBoxSelected
            // 
            this.ListBoxSelected.FormattingEnabled = true;
            this.ListBoxSelected.ItemHeight = 16;
            this.ListBoxSelected.Location = new System.Drawing.Point(6, 33);
            this.ListBoxSelected.Name = "ListBoxSelected";
            this.ListBoxSelected.Size = new System.Drawing.Size(129, 196);
            this.ListBoxSelected.TabIndex = 0;
            // 
            // LabelMovieTitle
            // 
            this.LabelMovieTitle.AutoSize = true;
            this.LabelMovieTitle.Location = new System.Drawing.Point(172, 33);
            this.LabelMovieTitle.Name = "LabelMovieTitle";
            this.LabelMovieTitle.Size = new System.Drawing.Size(34, 16);
            this.LabelMovieTitle.TabIndex = 1;
            this.LabelMovieTitle.Text = "Title";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(172, 104);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(63, 16);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Category";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(342, 104);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(35, 16);
            this.LabelCost.TabIndex = 3;
            this.LabelCost.Text = "Cost";
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(157, 123);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(147, 22);
            this.TextBoxCategory.TabIndex = 4;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(157, 52);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(272, 22);
            this.TextBoxTitle.TabIndex = 5;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(334, 123);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.Size = new System.Drawing.Size(95, 22);
            this.TextBoxCost.TabIndex = 6;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 496);
            this.Controls.Add(this.GroupBoxSelection);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelCurrentMovies);
            this.Controls.Add(this.listBox1);
            this.Name = "SelectionForm";
            this.Text = "Notflix";
            this.GroupBoxSelection.ResumeLayout(false);
            this.GroupBoxSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LabelCurrentMovies;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.GroupBox GroupBoxSelection;
        private System.Windows.Forms.ListBox ListBoxSelected;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelMovieTitle;
    }
}

