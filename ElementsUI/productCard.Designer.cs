namespace informationSystem.ElementsUI
{
    partial class productCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productDisc = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productManufacture = new System.Windows.Forms.Label();
            this.productCost = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.productWarehouse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // productDisc
            // 
            this.productDisc.AutoEllipsis = true;
            this.productDisc.AutoSize = true;
            this.productDisc.Location = new System.Drawing.Point(230, 48);
            this.productDisc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productDisc.Name = "productDisc";
            this.productDisc.Size = new System.Drawing.Size(46, 18);
            this.productDisc.TabIndex = 1;
            this.productDisc.Text = "label2";
            // 
            // productName
            // 
            this.productName.AutoEllipsis = true;
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(230, 16);
            this.productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(44, 18);
            this.productName.TabIndex = 2;
            this.productName.Text = "label1";
            // 
            // productManufacture
            // 
            this.productManufacture.AutoEllipsis = true;
            this.productManufacture.AutoSize = true;
            this.productManufacture.Location = new System.Drawing.Point(230, 129);
            this.productManufacture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productManufacture.Name = "productManufacture";
            this.productManufacture.Size = new System.Drawing.Size(46, 18);
            this.productManufacture.TabIndex = 3;
            this.productManufacture.Text = "label3";
            // 
            // productCost
            // 
            this.productCost.AutoEllipsis = true;
            this.productCost.AutoSize = true;
            this.productCost.Location = new System.Drawing.Point(230, 95);
            this.productCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(46, 18);
            this.productCost.TabIndex = 4;
            this.productCost.Text = "label4";
            // 
            // productPicture
            // 
            this.productPicture.Image = global::informationSystem.Properties.Resources.picture;
            this.productPicture.Location = new System.Drawing.Point(20, 16);
            this.productPicture.Margin = new System.Windows.Forms.Padding(2);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(130, 117);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicture.TabIndex = 5;
            this.productPicture.TabStop = false;
            // 
            // productWarehouse
            // 
            this.productWarehouse.AutoEllipsis = true;
            this.productWarehouse.AutoSize = true;
            this.productWarehouse.Location = new System.Drawing.Point(418, 95);
            this.productWarehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productWarehouse.Name = "productWarehouse";
            this.productWarehouse.Size = new System.Drawing.Size(46, 18);
            this.productWarehouse.TabIndex = 6;
            this.productWarehouse.Text = "label5";
            // 
            // productCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.productWarehouse);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.productCost);
            this.Controls.Add(this.productManufacture);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productDisc);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "productCard";
            this.Size = new System.Drawing.Size(545, 171);
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productDisc;
        public System.Windows.Forms.Label productName;
        public System.Windows.Forms.Label productManufacture;
        public System.Windows.Forms.Label productCost;
        public System.Windows.Forms.PictureBox productPicture;
        public System.Windows.Forms.Label productWarehouse;
    }
}
