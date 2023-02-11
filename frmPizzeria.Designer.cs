namespace pizzeria
{
    partial class frmPizzeria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzeria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFamiliar = new System.Windows.Forms.RadioButton();
            this.rdbMesdiana = new System.Windows.Forms.RadioButton();
            this.rdbMFamiliar = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMasa = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbVegatareiana = new System.Windows.Forms.RadioButton();
            this.rdbItaliana = new System.Windows.Forms.RadioButton();
            this.rdbAntioquena = new System.Windows.Forms.RadioButton();
            this.rdbHawiana = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cheTocineta = new System.Windows.Forms.CheckBox();
            this.chePeperoni = new System.Windows.Forms.CheckBox();
            this.cheJalapeno = new System.Windows.Forms.CheckBox();
            this.cheQueso = new System.Windows.Forms.CheckBox();
            this.chePina = new System.Windows.Forms.CheckBox();
            this.cheChanpinones = new System.Windows.Forms.CheckBox();
            this.cheAceitunas = new System.Windows.Forms.CheckBox();
            this.chePollo = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFamiliar);
            this.groupBox1.Controls.Add(this.rdbMesdiana);
            this.groupBox1.Controls.Add(this.rdbMFamiliar);
            this.groupBox1.Controls.Add(this.rdbPersonal);
            this.groupBox1.Location = new System.Drawing.Point(164, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño";
            // 
            // rdbFamiliar
            // 
            this.rdbFamiliar.AutoSize = true;
            this.rdbFamiliar.Location = new System.Drawing.Point(6, 62);
            this.rdbFamiliar.Name = "rdbFamiliar";
            this.rdbFamiliar.Size = new System.Drawing.Size(60, 17);
            this.rdbFamiliar.TabIndex = 3;
            this.rdbFamiliar.TabStop = true;
            this.rdbFamiliar.Text = "Familiar";
            this.rdbFamiliar.UseVisualStyleBackColor = true;
            // 
            // rdbMesdiana
            // 
            this.rdbMesdiana.AutoSize = true;
            this.rdbMesdiana.Location = new System.Drawing.Point(248, 19);
            this.rdbMesdiana.Name = "rdbMesdiana";
            this.rdbMesdiana.Size = new System.Drawing.Size(66, 17);
            this.rdbMesdiana.TabIndex = 2;
            this.rdbMesdiana.TabStop = true;
            this.rdbMesdiana.Text = "Mediana";
            this.rdbMesdiana.UseVisualStyleBackColor = true;
            // 
            // rdbMFamiliar
            // 
            this.rdbMFamiliar.AutoSize = true;
            this.rdbMFamiliar.Location = new System.Drawing.Point(248, 62);
            this.rdbMFamiliar.Name = "rdbMFamiliar";
            this.rdbMFamiliar.Size = new System.Drawing.Size(90, 17);
            this.rdbMFamiliar.TabIndex = 1;
            this.rdbMFamiliar.TabStop = true;
            this.rdbMFamiliar.Text = "Mega Familiar";
            this.rdbMFamiliar.UseVisualStyleBackColor = true;
            // 
            // rdbPersonal
            // 
            this.rdbPersonal.AutoSize = true;
            this.rdbPersonal.Location = new System.Drawing.Point(6, 19);
            this.rdbPersonal.Name = "rdbPersonal";
            this.rdbPersonal.Size = new System.Drawing.Size(66, 17);
            this.rdbPersonal.TabIndex = 0;
            this.rdbPersonal.TabStop = true;
            this.rdbPersonal.Text = "Personal";
            this.rdbPersonal.UseVisualStyleBackColor = true;
            this.rdbPersonal.CheckedChanged += new System.EventHandler(this.rdbPersonal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMasa);
            this.groupBox2.Location = new System.Drawing.Point(164, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de mesa";
            // 
            // cmbMasa
            // 
            this.cmbMasa.FormattingEnabled = true;
            this.cmbMasa.Items.AddRange(new object[] {
            "Delgada ",
            "Tradicional",
            "Borde de queso"});
            this.cmbMasa.Location = new System.Drawing.Point(32, 29);
            this.cmbMasa.Name = "cmbMasa";
            this.cmbMasa.Size = new System.Drawing.Size(173, 21);
            this.cmbMasa.TabIndex = 0;
            this.cmbMasa.Text = "Seleccionar tipo de Masa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbVegatareiana);
            this.groupBox3.Controls.Add(this.rdbItaliana);
            this.groupBox3.Controls.Add(this.rdbAntioquena);
            this.groupBox3.Controls.Add(this.rdbHawiana);
            this.groupBox3.Location = new System.Drawing.Point(164, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sabores";
            // 
            // rdbVegatareiana
            // 
            this.rdbVegatareiana.AutoSize = true;
            this.rdbVegatareiana.Location = new System.Drawing.Point(6, 62);
            this.rdbVegatareiana.Name = "rdbVegatareiana";
            this.rdbVegatareiana.Size = new System.Drawing.Size(82, 17);
            this.rdbVegatareiana.TabIndex = 3;
            this.rdbVegatareiana.TabStop = true;
            this.rdbVegatareiana.Text = "Vegetariana";
            this.rdbVegatareiana.UseVisualStyleBackColor = true;
            // 
            // rdbItaliana
            // 
            this.rdbItaliana.AutoSize = true;
            this.rdbItaliana.Location = new System.Drawing.Point(248, 19);
            this.rdbItaliana.Name = "rdbItaliana";
            this.rdbItaliana.Size = new System.Drawing.Size(59, 17);
            this.rdbItaliana.TabIndex = 2;
            this.rdbItaliana.TabStop = true;
            this.rdbItaliana.Text = "Italiana";
            this.rdbItaliana.UseVisualStyleBackColor = true;
            // 
            // rdbAntioquena
            // 
            this.rdbAntioquena.AutoSize = true;
            this.rdbAntioquena.Location = new System.Drawing.Point(248, 62);
            this.rdbAntioquena.Name = "rdbAntioquena";
            this.rdbAntioquena.Size = new System.Drawing.Size(79, 17);
            this.rdbAntioquena.TabIndex = 1;
            this.rdbAntioquena.TabStop = true;
            this.rdbAntioquena.Text = "Antioqueña";
            this.rdbAntioquena.UseVisualStyleBackColor = true;
            // 
            // rdbHawiana
            // 
            this.rdbHawiana.AutoSize = true;
            this.rdbHawiana.Location = new System.Drawing.Point(6, 19);
            this.rdbHawiana.Name = "rdbHawiana";
            this.rdbHawiana.Size = new System.Drawing.Size(67, 17);
            this.rdbHawiana.TabIndex = 0;
            this.rdbHawiana.TabStop = true;
            this.rdbHawiana.Text = "Hawiana";
            this.rdbHawiana.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(257, 766);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(234, 31);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(303, 675);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 32);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cheTocineta);
            this.groupBox4.Controls.Add(this.chePeperoni);
            this.groupBox4.Controls.Add(this.cheJalapeno);
            this.groupBox4.Controls.Add(this.cheQueso);
            this.groupBox4.Controls.Add(this.chePina);
            this.groupBox4.Controls.Add(this.cheChanpinones);
            this.groupBox4.Controls.Add(this.cheAceitunas);
            this.groupBox4.Controls.Add(this.chePollo);
            this.groupBox4.Location = new System.Drawing.Point(164, 497);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 152);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adiciones";
            // 
            // cheTocineta
            // 
            this.cheTocineta.AutoSize = true;
            this.cheTocineta.Location = new System.Drawing.Point(183, 30);
            this.cheTocineta.Name = "cheTocineta";
            this.cheTocineta.Size = new System.Drawing.Size(68, 17);
            this.cheTocineta.TabIndex = 7;
            this.cheTocineta.Text = "Tocineta";
            this.cheTocineta.UseVisualStyleBackColor = true;
            // 
            // chePeperoni
            // 
            this.chePeperoni.AutoSize = true;
            this.chePeperoni.Location = new System.Drawing.Point(183, 99);
            this.chePeperoni.Name = "chePeperoni";
            this.chePeperoni.Size = new System.Drawing.Size(74, 17);
            this.chePeperoni.TabIndex = 6;
            this.chePeperoni.Text = "Pepperoni";
            this.chePeperoni.UseVisualStyleBackColor = true;
            // 
            // cheJalapeno
            // 
            this.cheJalapeno.AutoSize = true;
            this.cheJalapeno.Location = new System.Drawing.Point(183, 76);
            this.cheJalapeno.Name = "cheJalapeno";
            this.cheJalapeno.Size = new System.Drawing.Size(74, 17);
            this.cheJalapeno.TabIndex = 5;
            this.cheJalapeno.Text = "Jalapeños";
            this.cheJalapeno.UseVisualStyleBackColor = true;
            // 
            // cheQueso
            // 
            this.cheQueso.AutoSize = true;
            this.cheQueso.Location = new System.Drawing.Point(183, 53);
            this.cheQueso.Name = "cheQueso";
            this.cheQueso.Size = new System.Drawing.Size(57, 17);
            this.cheQueso.TabIndex = 4;
            this.cheQueso.Text = "Queso";
            this.cheQueso.UseVisualStyleBackColor = true;
            // 
            // chePina
            // 
            this.chePina.AutoSize = true;
            this.chePina.Location = new System.Drawing.Point(17, 53);
            this.chePina.Name = "chePina";
            this.chePina.Size = new System.Drawing.Size(47, 17);
            this.chePina.TabIndex = 3;
            this.chePina.Text = "Piña";
            this.chePina.UseVisualStyleBackColor = true;
            // 
            // cheChanpinones
            // 
            this.cheChanpinones.AutoSize = true;
            this.cheChanpinones.Location = new System.Drawing.Point(17, 76);
            this.cheChanpinones.Name = "cheChanpinones";
            this.cheChanpinones.Size = new System.Drawing.Size(90, 17);
            this.cheChanpinones.TabIndex = 2;
            this.cheChanpinones.Text = "Champiñones";
            this.cheChanpinones.UseVisualStyleBackColor = true;
            // 
            // cheAceitunas
            // 
            this.cheAceitunas.AutoSize = true;
            this.cheAceitunas.Location = new System.Drawing.Point(15, 99);
            this.cheAceitunas.Name = "cheAceitunas";
            this.cheAceitunas.Size = new System.Drawing.Size(73, 17);
            this.cheAceitunas.TabIndex = 1;
            this.cheAceitunas.Text = "Aceitunas";
            this.cheAceitunas.UseVisualStyleBackColor = true;
            // 
            // chePollo
            // 
            this.chePollo.AutoSize = true;
            this.chePollo.Location = new System.Drawing.Point(17, 30);
            this.chePollo.Name = "chePollo";
            this.chePollo.Size = new System.Drawing.Size(49, 17);
            this.chePollo.TabIndex = 0;
            this.chePollo.Text = "Pollo";
            this.chePollo.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pizzas Itagüi";
            // 
            // frmPizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 872);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPizzeria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPizzeria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFamiliar;
        private System.Windows.Forms.RadioButton rdbMesdiana;
        private System.Windows.Forms.RadioButton rdbMFamiliar;
        private System.Windows.Forms.RadioButton rdbPersonal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMasa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbVegatareiana;
        private System.Windows.Forms.RadioButton rdbItaliana;
        private System.Windows.Forms.RadioButton rdbAntioquena;
        private System.Windows.Forms.RadioButton rdbHawiana;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cheTocineta;
        private System.Windows.Forms.CheckBox chePeperoni;
        private System.Windows.Forms.CheckBox cheJalapeno;
        private System.Windows.Forms.CheckBox cheQueso;
        private System.Windows.Forms.CheckBox chePina;
        private System.Windows.Forms.CheckBox cheChanpinones;
        private System.Windows.Forms.CheckBox cheAceitunas;
        private System.Windows.Forms.CheckBox chePollo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
    }
}

