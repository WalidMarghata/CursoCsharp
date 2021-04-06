namespace BethesdaCarRental1
{
    partial class CarroEditor
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPictureName = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkCDPlayer = new System.Windows.Forms.CheckBox();
            this.chkDVDPlayer = new System.Windows.Forms.CheckBox();
            this.pbxCar = new System.Windows.Forms.PictureBox();
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTagNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(284, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 32);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Submeter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPictureName
            // 
            this.lblPictureName.AutoSize = true;
            this.lblPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureName.Location = new System.Drawing.Point(10, 291);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(116, 16);
            this.lblPictureName.TabIndex = 35;
            this.lblPictureName.Text = "Nome da Imagem";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailable.Location = new System.Drawing.Point(16, 219);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(154, 20);
            this.chkAvailable.TabIndex = 34;
            this.chkAvailable.Text = "Veículo Disponível     ";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(438, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 32);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // chkCDPlayer
            // 
            this.chkCDPlayer.AutoSize = true;
            this.chkCDPlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCDPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCDPlayer.Location = new System.Drawing.Point(13, 180);
            this.chkCDPlayer.Name = "chkCDPlayer";
            this.chkCDPlayer.Size = new System.Drawing.Size(103, 20);
            this.chkCDPlayer.TabIndex = 30;
            this.chkCDPlayer.Text = "C&D Player     ";
            this.chkCDPlayer.UseVisualStyleBackColor = true;
            // 
            // chkDVDPlayer
            // 
            this.chkDVDPlayer.AutoSize = true;
            this.chkDVDPlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDVDPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDVDPlayer.Location = new System.Drawing.Point(180, 180);
            this.chkDVDPlayer.Name = "chkDVDPlayer";
            this.chkDVDPlayer.Size = new System.Drawing.Size(98, 20);
            this.chkDVDPlayer.TabIndex = 29;
            this.chkDVDPlayer.Text = "D&VD Player";
            this.chkDVDPlayer.UseVisualStyleBackColor = true;
            // 
            // pbxCar
            // 
            this.pbxCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxCar.Location = new System.Drawing.Point(284, 12);
            this.pbxCar.Name = "pbxCar";
            this.pbxCar.Size = new System.Drawing.Size(304, 181);
            this.pbxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCar.TabIndex = 31;
            this.pbxCar.TabStop = false;
            // 
            // dlgPicture
            // 
            this.dlgPicture.DefaultExt = "jpg";
            this.dlgPicture.Filter = "JPEG Files (*.jpg,*.jpeg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bm" +
    "p|PNG Files (*.png)|*.png";
            this.dlgPicture.Title = "Select Item Picture";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicture.Location = new System.Drawing.Point(284, 203);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(304, 33);
            this.btnSelectPicture.TabIndex = 32;
            this.btnSelectPicture.Text = "&Selecione a Imagem do Carro...";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Items.AddRange(new object[] {
            "Econômica",
            "Compacto",
            "Padrão",
            "Grande",
            "Mini Van",
            "SUV",
            "Truck",
            "Van"});
            this.cbxCategories.Location = new System.Drawing.Point(105, 139);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(173, 24);
            this.cbxCategories.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "&Categoria:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(105, 108);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(173, 22);
            this.txtYear.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "&Ano:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(105, 77);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(173, 22);
            this.txtModel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "M&odelo:";
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(105, 46);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(173, 22);
            this.txtMake.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "&Fabricante:";
            // 
            // txtTagNumber
            // 
            this.txtTagNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNumber.Location = new System.Drawing.Point(105, 15);
            this.txtTagNumber.Name = "txtTagNumber";
            this.txtTagNumber.Size = new System.Drawing.Size(173, 22);
            this.txtTagNumber.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "&Número :";
            // 
            // CarroEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 316);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPictureName);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkCDPlayer);
            this.Controls.Add(this.chkDVDPlayer);
            this.Controls.Add(this.pbxCar);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTagNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarroEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor de Carros";
            this.Load += new System.EventHandler(this.CarroEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.Label lblPictureName;
        public System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.CheckBox chkCDPlayer;
        public System.Windows.Forms.CheckBox chkDVDPlayer;
        private System.Windows.Forms.PictureBox pbxCar;
        private System.Windows.Forms.OpenFileDialog dlgPicture;
        private System.Windows.Forms.Button btnSelectPicture;
        public System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTagNumber;
        private System.Windows.Forms.Label label1;
    }
}