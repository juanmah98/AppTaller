
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Alineacion y balanceo (A y B)");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Service Completo");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpBxDuenio = new System.Windows.Forms.GroupBox();
            this.LblDirec = new System.Windows.Forms.Label();
            this.TxtBxDIrec = new System.Windows.Forms.TextBox();
            this.TxtBxCelular = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TxtBxDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.GrpBxVehic = new System.Windows.Forms.GroupBox();
            this.TxtBxPatente = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblProblema = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblPatente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrpBxPrecios = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpBxDuenio.SuspendLayout();
            this.GrpBxVehic.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GrpBxPrecios.SuspendLayout();
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
            // GrpBxDuenio
            // 
            this.GrpBxDuenio.Controls.Add(this.LblDirec);
            this.GrpBxDuenio.Controls.Add(this.TxtBxDIrec);
            this.GrpBxDuenio.Controls.Add(this.TxtBxCelular);
            this.GrpBxDuenio.Controls.Add(this.LblCelular);
            this.GrpBxDuenio.Controls.Add(this.TxtBxDNI);
            this.GrpBxDuenio.Controls.Add(this.LblDNI);
            this.GrpBxDuenio.Controls.Add(this.TxtBxApellido);
            this.GrpBxDuenio.Controls.Add(this.LblApellido);
            this.GrpBxDuenio.Controls.Add(this.LblName);
            this.GrpBxDuenio.Controls.Add(this.TxtBxName);
            this.GrpBxDuenio.Location = new System.Drawing.Point(3, 3);
            this.GrpBxDuenio.Name = "GrpBxDuenio";
            this.GrpBxDuenio.Size = new System.Drawing.Size(316, 213);
            this.GrpBxDuenio.TabIndex = 2;
            this.GrpBxDuenio.TabStop = false;
            this.GrpBxDuenio.Text = "Datos del Dueño";
            // 
            // LblDirec
            // 
            this.LblDirec.AutoSize = true;
            this.LblDirec.Location = new System.Drawing.Point(6, 183);
            this.LblDirec.Name = "LblDirec";
            this.LblDirec.Size = new System.Drawing.Size(55, 13);
            this.LblDirec.TabIndex = 8;
            this.LblDirec.Text = "Direccion:";
            // 
            // TxtBxDIrec
            // 
            this.TxtBxDIrec.Location = new System.Drawing.Point(67, 179);
            this.TxtBxDIrec.Name = "TxtBxDIrec";
            this.TxtBxDIrec.Size = new System.Drawing.Size(241, 20);
            this.TxtBxDIrec.TabIndex = 7;
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
            this.LblCelular.Size = new System.Drawing.Size(45, 13);
            this.LblCelular.TabIndex = 6;
            this.LblCelular.Text = "Celular: ";
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
            this.LblDNI.Size = new System.Drawing.Size(32, 13);
            this.LblDNI.TabIndex = 4;
            this.LblDNI.Text = "DNI: ";
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
            this.LblApellido.Size = new System.Drawing.Size(50, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido: ";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(6, 40);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre: ";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(67, 35);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(241, 20);
            this.TxtBxName.TabIndex = 0;
            this.TxtBxName.Tag = "";
            // 
            // GrpBxVehic
            // 
            this.GrpBxVehic.Controls.Add(this.TxtBxPatente);
            this.GrpBxVehic.Controls.Add(this.textBox3);
            this.GrpBxVehic.Controls.Add(this.textBox2);
            this.GrpBxVehic.Controls.Add(this.textBox1);
            this.GrpBxVehic.Controls.Add(this.LblProblema);
            this.GrpBxVehic.Controls.Add(this.LblModelo);
            this.GrpBxVehic.Controls.Add(this.LblMarca);
            this.GrpBxVehic.Controls.Add(this.LblPatente);
            this.GrpBxVehic.Location = new System.Drawing.Point(3, 235);
            this.GrpBxVehic.Name = "GrpBxVehic";
            this.GrpBxVehic.Size = new System.Drawing.Size(316, 226);
            this.GrpBxVehic.TabIndex = 3;
            this.GrpBxVehic.TabStop = false;
            this.GrpBxVehic.Text = "Datos del Vehiculo";
            // 
            // TxtBxPatente
            // 
            this.TxtBxPatente.Location = new System.Drawing.Point(67, 27);
            this.TxtBxPatente.Name = "TxtBxPatente";
            this.TxtBxPatente.Size = new System.Drawing.Size(241, 20);
            this.TxtBxPatente.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 137);
            this.textBox3.MinimumSize = new System.Drawing.Size(222, 80);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 80);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 5;
            // 
            // LblProblema
            // 
            this.LblProblema.AutoSize = true;
            this.LblProblema.Location = new System.Drawing.Point(6, 137);
            this.LblProblema.Name = "LblProblema";
            this.LblProblema.Size = new System.Drawing.Size(57, 13);
            this.LblProblema.TabIndex = 3;
            this.LblProblema.Text = "Problema: ";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(6, 99);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(48, 13);
            this.LblModelo.TabIndex = 2;
            this.LblModelo.Text = "Modelo: ";
            this.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(6, 62);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(43, 13);
            this.LblMarca.TabIndex = 1;
            this.LblMarca.Text = "Marca: ";
            // 
            // LblPatente
            // 
            this.LblPatente.AutoSize = true;
            this.LblPatente.Location = new System.Drawing.Point(6, 27);
            this.LblPatente.Name = "LblPatente";
            this.LblPatente.Size = new System.Drawing.Size(47, 13);
            this.LblPatente.TabIndex = 0;
            this.LblPatente.Text = "Patente:";
            this.LblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.35809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.64191F));
            this.tableLayoutPanel1.Controls.Add(this.GrpBxDuenio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GrpBxVehic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GrpBxPrecios, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.34025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65975F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 482);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // GrpBxPrecios
            // 
            this.GrpBxPrecios.Controls.Add(this.BtnRemove);
            this.GrpBxPrecios.Controls.Add(this.BtnAdd);
            this.GrpBxPrecios.Controls.Add(this.listView1);
            this.GrpBxPrecios.Location = new System.Drawing.Point(344, 3);
            this.GrpBxPrecios.Name = "GrpBxPrecios";
            this.GrpBxPrecios.Size = new System.Drawing.Size(401, 226);
            this.GrpBxPrecios.TabIndex = 4;
            this.GrpBxPrecios.TabStop = false;
            this.GrpBxPrecios.Text = "Lista de precios";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.Location = new System.Drawing.Point(16, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(152, 178);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(196, 35);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(46, 33);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(269, 35);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(46, 33);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "-";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Taller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpBxDuenio.ResumeLayout(false);
            this.GrpBxDuenio.PerformLayout();
            this.GrpBxVehic.ResumeLayout(false);
            this.GrpBxVehic.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GrpBxPrecios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox TxtBxDIrec;
        private System.Windows.Forms.GroupBox GrpBxVehic;
        private System.Windows.Forms.TextBox TxtBxPatente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblProblema;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblPatente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GrpBxPrecios;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView listView1;
    }
}

