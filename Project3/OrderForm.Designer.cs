namespace Project3
{
    partial class OrderForm
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
            this.GroupBoxSelectedMovie = new System.Windows.Forms.GroupBox();
            this.PictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelMovieTitle = new System.Windows.Forms.Label();
            this.GroupBoxOrder = new System.Windows.Forms.GroupBox();
            this.TextBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.LabelGrandTotal = new System.Windows.Forms.Label();
            this.TextBoxSalesTax = new System.Windows.Forms.TextBox();
            this.LabelSalesTax = new System.Windows.Forms.Label();
            this.TextBoxSubTotal = new System.Windows.Forms.TextBox();
            this.LabelSubTotal = new System.Windows.Forms.Label();
            this.TextBoxDVD = new System.Windows.Forms.TextBox();
            this.LabelDVD = new System.Windows.Forms.Label();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ButtonStream = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.CheckboxDVD = new System.Windows.Forms.CheckBox();
            this.GroupBoxSelectedMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPoster)).BeginInit();
            this.GroupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSelectedMovie
            // 
            this.GroupBoxSelectedMovie.Controls.Add(this.PictureBoxPoster);
            this.GroupBoxSelectedMovie.Controls.Add(this.TextBoxTitle);
            this.GroupBoxSelectedMovie.Controls.Add(this.TextBoxCategory);
            this.GroupBoxSelectedMovie.Controls.Add(this.LabelCategory);
            this.GroupBoxSelectedMovie.Controls.Add(this.LabelMovieTitle);
            this.GroupBoxSelectedMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSelectedMovie.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxSelectedMovie.Name = "GroupBoxSelectedMovie";
            this.GroupBoxSelectedMovie.Size = new System.Drawing.Size(333, 346);
            this.GroupBoxSelectedMovie.TabIndex = 0;
            this.GroupBoxSelectedMovie.TabStop = false;
            this.GroupBoxSelectedMovie.Text = "Your Movie of Choice!";
            // 
            // PictureBoxPoster
            // 
            this.PictureBoxPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxPoster.Location = new System.Drawing.Point(101, 74);
            this.PictureBoxPoster.Name = "PictureBoxPoster";
            this.PictureBoxPoster.Size = new System.Drawing.Size(226, 266);
            this.PictureBoxPoster.TabIndex = 10;
            this.PictureBoxPoster.TabStop = false;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(9, 46);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.ReadOnly = true;
            this.TextBoxTitle.Size = new System.Drawing.Size(318, 22);
            this.TextBoxTitle.TabIndex = 9;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(9, 103);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.ReadOnly = true;
            this.TextBoxCategory.Size = new System.Drawing.Size(86, 22);
            this.TextBoxCategory.TabIndex = 8;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(6, 84);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(63, 16);
            this.LabelCategory.TabIndex = 7;
            this.LabelCategory.Text = "Category";
            // 
            // LabelMovieTitle
            // 
            this.LabelMovieTitle.AutoSize = true;
            this.LabelMovieTitle.Location = new System.Drawing.Point(6, 27);
            this.LabelMovieTitle.Name = "LabelMovieTitle";
            this.LabelMovieTitle.Size = new System.Drawing.Size(34, 16);
            this.LabelMovieTitle.TabIndex = 6;
            this.LabelMovieTitle.Text = "Title";
            // 
            // GroupBoxOrder
            // 
            this.GroupBoxOrder.Controls.Add(this.TextBoxGrandTotal);
            this.GroupBoxOrder.Controls.Add(this.LabelGrandTotal);
            this.GroupBoxOrder.Controls.Add(this.TextBoxSalesTax);
            this.GroupBoxOrder.Controls.Add(this.LabelSalesTax);
            this.GroupBoxOrder.Controls.Add(this.TextBoxSubTotal);
            this.GroupBoxOrder.Controls.Add(this.LabelSubTotal);
            this.GroupBoxOrder.Controls.Add(this.TextBoxDVD);
            this.GroupBoxOrder.Controls.Add(this.LabelDVD);
            this.GroupBoxOrder.Controls.Add(this.TextBoxCost);
            this.GroupBoxOrder.Controls.Add(this.LabelPrice);
            this.GroupBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxOrder.Location = new System.Drawing.Point(402, 27);
            this.GroupBoxOrder.Name = "GroupBoxOrder";
            this.GroupBoxOrder.Size = new System.Drawing.Size(342, 255);
            this.GroupBoxOrder.TabIndex = 1;
            this.GroupBoxOrder.TabStop = false;
            this.GroupBoxOrder.Text = "Your Order Total";
            // 
            // TextBoxGrandTotal
            // 
            this.TextBoxGrandTotal.Location = new System.Drawing.Point(160, 215);
            this.TextBoxGrandTotal.Name = "TextBoxGrandTotal";
            this.TextBoxGrandTotal.ReadOnly = true;
            this.TextBoxGrandTotal.Size = new System.Drawing.Size(100, 22);
            this.TextBoxGrandTotal.TabIndex = 9;
            // 
            // LabelGrandTotal
            // 
            this.LabelGrandTotal.AutoSize = true;
            this.LabelGrandTotal.Location = new System.Drawing.Point(59, 218);
            this.LabelGrandTotal.Name = "LabelGrandTotal";
            this.LabelGrandTotal.Size = new System.Drawing.Size(82, 16);
            this.LabelGrandTotal.TabIndex = 8;
            this.LabelGrandTotal.Text = "Grand Total:";
            // 
            // TextBoxSalesTax
            // 
            this.TextBoxSalesTax.Location = new System.Drawing.Point(160, 182);
            this.TextBoxSalesTax.Name = "TextBoxSalesTax";
            this.TextBoxSalesTax.ReadOnly = true;
            this.TextBoxSalesTax.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSalesTax.TabIndex = 7;
            // 
            // LabelSalesTax
            // 
            this.LabelSalesTax.AutoSize = true;
            this.LabelSalesTax.Location = new System.Drawing.Point(34, 185);
            this.LabelSalesTax.Name = "LabelSalesTax";
            this.LabelSalesTax.Size = new System.Drawing.Size(109, 16);
            this.LabelSalesTax.TabIndex = 6;
            this.LabelSalesTax.Text = "Sales Tax (13%):";
            // 
            // TextBoxSubTotal
            // 
            this.TextBoxSubTotal.Location = new System.Drawing.Point(160, 122);
            this.TextBoxSubTotal.Name = "TextBoxSubTotal";
            this.TextBoxSubTotal.ReadOnly = true;
            this.TextBoxSubTotal.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSubTotal.TabIndex = 5;
            // 
            // LabelSubTotal
            // 
            this.LabelSubTotal.AutoSize = true;
            this.LabelSubTotal.Location = new System.Drawing.Point(80, 125);
            this.LabelSubTotal.Name = "LabelSubTotal";
            this.LabelSubTotal.Size = new System.Drawing.Size(66, 16);
            this.LabelSubTotal.TabIndex = 4;
            this.LabelSubTotal.Text = "SubTotal:";
            // 
            // TextBoxDVD
            // 
            this.TextBoxDVD.Location = new System.Drawing.Point(160, 84);
            this.TextBoxDVD.Name = "TextBoxDVD";
            this.TextBoxDVD.ReadOnly = true;
            this.TextBoxDVD.Size = new System.Drawing.Size(100, 22);
            this.TextBoxDVD.TabIndex = 3;
            this.TextBoxDVD.Visible = false;
            // 
            // LabelDVD
            // 
            this.LabelDVD.AutoSize = true;
            this.LabelDVD.Location = new System.Drawing.Point(103, 87);
            this.LabelDVD.Name = "LabelDVD";
            this.LabelDVD.Size = new System.Drawing.Size(40, 16);
            this.LabelDVD.TabIndex = 2;
            this.LabelDVD.Text = "DVD:";
            this.LabelDVD.Visible = false;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Location = new System.Drawing.Point(160, 46);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.ReadOnly = true;
            this.TextBoxCost.Size = new System.Drawing.Size(100, 22);
            this.TextBoxCost.TabIndex = 1;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(103, 49);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(38, 16);
            this.LabelPrice.TabIndex = 0;
            this.LabelPrice.Text = "Cost:";
            // 
            // ButtonStream
            // 
            this.ButtonStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStream.Location = new System.Drawing.Point(640, 350);
            this.ButtonStream.Name = "ButtonStream";
            this.ButtonStream.Size = new System.Drawing.Size(95, 23);
            this.ButtonStream.TabIndex = 1;
            this.ButtonStream.Text = "Stream";
            this.ButtonStream.UseVisualStyleBackColor = true;
            this.ButtonStream.Click += new System.EventHandler(this.ButtonStream_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(539, 350);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(95, 23);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(402, 350);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(95, 23);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CheckboxDVD
            // 
            this.CheckboxDVD.AutoSize = true;
            this.CheckboxDVD.Location = new System.Drawing.Point(527, 288);
            this.CheckboxDVD.Name = "CheckboxDVD";
            this.CheckboxDVD.Size = new System.Drawing.Size(135, 17);
            this.CheckboxDVD.TabIndex = 10;
            this.CheckboxDVD.Text = "Order the DVD ( +10$ )";
            this.CheckboxDVD.UseVisualStyleBackColor = true;
            this.CheckboxDVD.CheckedChanged += new System.EventHandler(this.CheckboxDVD_CheckedChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 385);
            this.Controls.Add(this.CheckboxDVD);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonStream);
            this.Controls.Add(this.GroupBoxOrder);
            this.Controls.Add(this.GroupBoxSelectedMovie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.GroupBoxSelectedMovie.ResumeLayout(false);
            this.GroupBoxSelectedMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPoster)).EndInit();
            this.GroupBoxOrder.ResumeLayout(false);
            this.GroupBoxOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSelectedMovie;
        private System.Windows.Forms.GroupBox GroupBoxOrder;
        private System.Windows.Forms.Button ButtonStream;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelMovieTitle;
        private System.Windows.Forms.PictureBox PictureBoxPoster;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.TextBox TextBoxDVD;
        private System.Windows.Forms.Label LabelDVD;
        private System.Windows.Forms.TextBox TextBoxSubTotal;
        private System.Windows.Forms.Label LabelSubTotal;
        private System.Windows.Forms.TextBox TextBoxSalesTax;
        private System.Windows.Forms.Label LabelSalesTax;
        private System.Windows.Forms.TextBox TextBoxGrandTotal;
        private System.Windows.Forms.Label LabelGrandTotal;
        private System.Windows.Forms.CheckBox CheckboxDVD;
    }
}