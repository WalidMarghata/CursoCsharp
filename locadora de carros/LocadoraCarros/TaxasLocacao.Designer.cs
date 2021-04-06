namespace BethesdaCarRental1
{
    partial class TaxasLocacao
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Econômica",
            "35.95",
            "32.75",
            "28.95",
            "24.95"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Compacto",
            "39.95",
            "35.75",
            "32.95",
            "28.95"}, -1, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Padrão",
            "45.95",
            "39.75",
            "35.95",
            "32.95"}, -1, System.Drawing.Color.Yellow, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Grande",
            "49.95",
            "42.75",
            "38.95",
            "35.95"}, -1, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mini Van",
            "55.95",
            "50.75",
            "45.95",
            "42.95"}, -1, System.Drawing.Color.Yellow, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "SUV",
            "55.95",
            "50.75",
            "45.95",
            "42.95"}, -1, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Truck",
            "42.75",
            "38.75",
            "35.95",
            "32.95"}, -1, System.Drawing.Color.Yellow, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Van",
            "69.95",
            "62.75",
            "55.95",
            "52.95"}, -1, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), null);
            this.lvTaxas = new System.Windows.Forms.ListView();
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDaily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTaxas
            // 
            this.lvTaxas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCategory,
            this.colDaily,
            this.colWeekly,
            this.colMonthly,
            this.colWeekend});
            this.lvTaxas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTaxas.FullRowSelect = true;
            this.lvTaxas.GridLines = true;
            this.lvTaxas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvTaxas.Location = new System.Drawing.Point(0, -1);
            this.lvTaxas.Name = "lvTaxas";
            this.lvTaxas.Size = new System.Drawing.Size(400, 186);
            this.lvTaxas.TabIndex = 1;
            this.lvTaxas.UseCompatibleStateImageBehavior = false;
            this.lvTaxas.View = System.Windows.Forms.View.Details;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Categoria";
            this.colCategory.Width = 80;
            // 
            // colDaily
            // 
            this.colDaily.Text = "Diária";
            this.colDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colWeekly
            // 
            this.colWeekly.Text = "Semanal";
            this.colWeekly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colWeekly.Width = 80;
            // 
            // colMonthly
            // 
            this.colMonthly.Text = "Mensal";
            this.colMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMonthly.Width = 70;
            // 
            // colWeekend
            // 
            this.colWeekend.Text = "Fim de Semana";
            this.colWeekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colWeekend.Width = 85;
            // 
            // TaxasLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 187);
            this.Controls.Add(this.lvTaxas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaxasLocacao";
            this.Text = "Taxas para Locação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTaxas;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDaily;
        private System.Windows.Forms.ColumnHeader colWeekly;
        private System.Windows.Forms.ColumnHeader colMonthly;
        private System.Windows.Forms.ColumnHeader colWeekend;
    }
}