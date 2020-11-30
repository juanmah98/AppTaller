
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
            this.GrpBxDuenio = new System.Windows.Forms.GroupBox();
            this.LblDirec = new System.Windows.Forms.Label();
            this.TxtBxCelular = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TxtBxDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSQUEDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpBxDuenio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // GrpBxDuenio
            // 
            this.GrpBxDuenio.Controls.Add(this.LblDirec);
            this.GrpBxDuenio.Controls.Add(this.TxtBxCelular);
            this.GrpBxDuenio.Controls.Add(this.LblCelular);
            this.GrpBxDuenio.Controls.Add(this.TxtBxDNI);
            this.GrpBxDuenio.Controls.Add(this.LblDNI);
            this.GrpBxDuenio.Controls.Add(this.TxtBxApellido);
            this.GrpBxDuenio.Controls.Add(this.LblApellido);
            this.GrpBxDuenio.Controls.Add(this.LblName);
            this.GrpBxDuenio.Controls.Add(this.TxtBxName);
            this.GrpBxDuenio.Location = new System.Drawing.Point(12, 98);
            this.GrpBxDuenio.Name = "GrpBxDuenio";
            this.GrpBxDuenio.Size = new System.Drawing.Size(316, 234);
            this.GrpBxDuenio.TabIndex = 2;
            this.GrpBxDuenio.TabStop = false;
            this.GrpBxDuenio.Text = "Nuevo";
            // 
            // LblDirec
            // 
            this.LblDirec.AutoSize = true;
            this.LblDirec.Location = new System.Drawing.Point(6, 183);
            this.LblDirec.Name = "LblDirec";
            this.LblDirec.Size = new System.Drawing.Size(40, 13);
            this.LblDirec.TabIndex = 8;
            this.LblDirec.Text = "Fecha:";
            // 
            // TxtBxCelular
            // 
            this.TxtBxCelular.AutoCompleteCustomSource.AddRange(new string[] {
            "264-",
            "155-",
            "154-"});
            this.TxtBxCelular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBxCelular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtBxCelular.Location = new System.Drawing.Point(67, 140);
            this.TxtBxCelular.Name = "TxtBxCelular";
            this.TxtBxCelular.Size = new System.Drawing.Size(241, 20);
            this.TxtBxCelular.TabIndex = 3;
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(6, 144);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(50, 13);
            this.LblCelular.TabIndex = 6;
            this.LblCelular.Text = "Patente: ";
            this.LblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxDNI
            // 
            this.TxtBxDNI.Location = new System.Drawing.Point(67, 105);
            this.TxtBxDNI.Name = "TxtBxDNI";
            this.TxtBxDNI.Size = new System.Drawing.Size(241, 20);
            this.TxtBxDNI.TabIndex = 2;
            this.TxtBxDNI.TextChanged += new System.EventHandler(this.TxtBxDNI_TextChanged);
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(6, 111);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(54, 13);
            this.LblDNI.TabIndex = 4;
            this.LblDNI.Text = "Vehiluco: ";
            this.LblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxApellido
            // 
            this.TxtBxApellido.Location = new System.Drawing.Point(67, 70);
            this.TxtBxApellido.Name = "TxtBxApellido";
            this.TxtBxApellido.Size = new System.Drawing.Size(241, 20);
            this.TxtBxApellido.TabIndex = 1;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(6, 74);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(45, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Celular: ";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(6, 40);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Cliente: ";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(67, 35);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(241, 20);
            this.TxtBxName.TabIndex = 0;
            this.TxtBxName.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(366, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empleado";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "264-",
            "155-",
            "154-"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(88, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mano de obra ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Repuestos: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Repuestos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trabajos: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Tag = "";
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteCustomSource.AddRange(new string[] {
            "264-",
            "155-",
            "154-"});
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox5.Location = new System.Drawing.Point(66, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(241, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.bUSQUEDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            // 
            // bUSQUEDAToolStripMenuItem
            // 
            this.bUSQUEDAToolStripMenuItem.Name = "bUSQUEDAToolStripMenuItem";
            this.bUSQUEDAToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.bUSQUEDAToolStripMenuItem.Text = "BUSQUEDA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpBxDuenio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Taller";
            this.GrpBxDuenio.ResumeLayout(false);
            this.GrpBxDuenio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GrpBxDuenio;
        private System.Windows.Forms.TextBox TxtBxDNI;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.TextBox TxtBxApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxCelular;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblDirec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSQUEDAToolStripMenuItem;
    }
}

