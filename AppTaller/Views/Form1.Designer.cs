
namespace AppTaller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBxCelular = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TxtBxDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxDIrec = new System.Windows.Forms.TextBox();
            this.LblDirec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDirec);
            this.groupBox1.Controls.Add(this.TxtBxDIrec);
            this.groupBox1.Controls.Add(this.TxtBxCelular);
            this.groupBox1.Controls.Add(this.LblCelular);
            this.groupBox1.Controls.Add(this.TxtBxDNI);
            this.groupBox1.Controls.Add(this.LblDNI);
            this.groupBox1.Controls.Add(this.TxtBxApellido);
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.TxtBxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Dueño";
            // 
            // TxtBxCelular
            // 
            this.TxtBxCelular.AutoCompleteCustomSource.AddRange(new string[] {
            "264-",
            "155-",
            "154-"});
            this.TxtBxCelular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBxCelular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtBxCelular.Location = new System.Drawing.Point(64, 140);
            this.TxtBxCelular.Name = "TxtBxCelular";
            this.TxtBxCelular.Size = new System.Drawing.Size(204, 20);
            this.TxtBxCelular.TabIndex = 3;
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(7, 144);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(45, 13);
            this.LblCelular.TabIndex = 6;
            this.LblCelular.Text = "Celular: ";
            this.LblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxDNI
            // 
            this.TxtBxDNI.Location = new System.Drawing.Point(64, 105);
            this.TxtBxDNI.Name = "TxtBxDNI";
            this.TxtBxDNI.Size = new System.Drawing.Size(204, 20);
            this.TxtBxDNI.TabIndex = 2;
            this.TxtBxDNI.TextChanged += new System.EventHandler(this.TxtBxDNI_TextChanged);
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(7, 111);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(32, 13);
            this.LblDNI.TabIndex = 4;
            this.LblDNI.Text = "DNI: ";
            this.LblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxApellido
            // 
            this.TxtBxApellido.Location = new System.Drawing.Point(64, 70);
            this.TxtBxApellido.Name = "TxtBxApellido";
            this.TxtBxApellido.Size = new System.Drawing.Size(204, 20);
            this.TxtBxApellido.TabIndex = 1;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(7, 74);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(50, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido: ";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(7, 40);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre: ";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(64, 35);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(204, 20);
            this.TxtBxName.TabIndex = 0;
            this.TxtBxName.Tag = "";
            // 
            // TxtBxDIrec
            // 
            this.TxtBxDIrec.Location = new System.Drawing.Point(64, 179);
            this.TxtBxDIrec.Name = "TxtBxDIrec";
            this.TxtBxDIrec.Size = new System.Drawing.Size(204, 20);
            this.TxtBxDIrec.TabIndex = 7;
            // 
            // LblDirec
            // 
            this.LblDirec.AutoSize = true;
            this.LblDirec.Location = new System.Drawing.Point(7, 183);
            this.LblDirec.Name = "LblDirec";
            this.LblDirec.Size = new System.Drawing.Size(55, 13);
            this.LblDirec.TabIndex = 8;
            this.LblDirec.Text = "Direccion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Taller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBxDNI;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.TextBox TxtBxApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxCelular;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblDirec;
        private System.Windows.Forms.TextBox TxtBxDIrec;
    }
}

