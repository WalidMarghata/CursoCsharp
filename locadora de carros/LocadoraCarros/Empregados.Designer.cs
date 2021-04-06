namespace BethesdaCarRental1
{
    partial class Empregados
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
            this.colHourlySalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployeeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwEmpregados = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // colHourlySalary
            // 
            this.colHourlySalary.Text = "Salário Hora";
            this.colHourlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHourlySalary.Width = 95;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Titulo";
            this.colTitle.Width = 120;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(574, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.Location = new System.Drawing.Point(434, 220);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(134, 32);
            this.btnNewEmployee.TabIndex = 4;
            this.btnNewEmployee.Text = "&Novo Empregado";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // colFullName
            // 
            this.colFullName.Text = "Nome Completo";
            this.colFullName.Width = 160;
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.Text = "Codigo #";
            this.colEmployeeNumber.Width = 70;
            // 
            // lvwEmpregados
            // 
            this.lvwEmpregados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colFullName,
            this.colTitle,
            this.colHourlySalary});
            this.lvwEmpregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEmpregados.FullRowSelect = true;
            this.lvwEmpregados.GridLines = true;
            this.lvwEmpregados.Location = new System.Drawing.Point(11, 10);
            this.lvwEmpregados.Name = "lvwEmpregados";
            this.lvwEmpregados.Size = new System.Drawing.Size(638, 204);
            this.lvwEmpregados.TabIndex = 3;
            this.lvwEmpregados.UseCompatibleStateImageBehavior = false;
            this.lvwEmpregados.View = System.Windows.Forms.View.Details;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "Nome";
            this.colFirstName.Width = 80;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Sobrenome";
            this.colLastName.Width = 85;
            // 
            // Empregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 264);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lvwEmpregados);
            this.Name = "Empregados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empregados";
            this.Load += new System.EventHandler(this.Empregados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colHourlySalary;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colEmployeeNumber;
        private System.Windows.Forms.ListView lvwEmpregados;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
    }
}