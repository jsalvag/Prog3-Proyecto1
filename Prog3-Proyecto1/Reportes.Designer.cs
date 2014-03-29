namespace Prog3_Proyecto1
{
    partial class Listados
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cliDGV = new System.Windows.Forms.DataGridView();
            this.vehiDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alqDGV = new System.Windows.Forms.DataGridView();
            this.alq_btn = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_alq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cliDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alqDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cliDGV
            // 
            this.cliDGV.AllowUserToOrderColumns = true;
            this.cliDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cliDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ci,
            this.nom,
            this.ape,
            this.dir,
            this.telf});
            this.cliDGV.Location = new System.Drawing.Point(10, 63);
            this.cliDGV.Name = "cliDGV";
            this.cliDGV.Size = new System.Drawing.Size(672, 311);
            this.cliDGV.TabIndex = 2;
            this.cliDGV.Visible = false;
            // 
            // vehiDGV
            // 
            this.vehiDGV.AllowUserToOrderColumns = true;
            this.vehiDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.marca,
            this.modelo,
            this.anio,
            this.km,
            this.condi,
            this.estado,
            this.precioDia,
            this.precioSeguro});
            this.vehiDGV.Location = new System.Drawing.Point(10, 63);
            this.vehiDGV.Name = "vehiDGV";
            this.vehiDGV.Size = new System.Drawing.Size(672, 311);
            this.vehiDGV.TabIndex = 3;
            this.vehiDGV.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vehiculos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // placa
            // 
            this.placa.Frozen = true;
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Width = 40;
            // 
            // marca
            // 
            this.marca.Frozen = true;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 80;
            // 
            // modelo
            // 
            this.modelo.Frozen = true;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 80;
            // 
            // anio
            // 
            this.anio.Frozen = true;
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 50;
            // 
            // km
            // 
            this.km.Frozen = true;
            this.km.HeaderText = "Kilimetraje";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            this.km.Width = 60;
            // 
            // condi
            // 
            this.condi.Frozen = true;
            this.condi.HeaderText = "Condición";
            this.condi.Name = "condi";
            this.condi.ReadOnly = true;
            this.condi.Width = 70;
            // 
            // estado
            // 
            this.estado.Frozen = true;
            this.estado.HeaderText = "Disponibilidad";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // precioDia
            // 
            this.precioDia.HeaderText = "Precio Día";
            this.precioDia.Name = "precioDia";
            this.precioDia.Width = 90;
            // 
            // precioSeguro
            // 
            this.precioSeguro.HeaderText = "Seguro";
            this.precioSeguro.Name = "precioSeguro";
            this.precioSeguro.Width = 65;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.alq_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 30);
            this.panel1.TabIndex = 5;
            // 
            // ci
            // 
            this.ci.Frozen = true;
            this.ci.HeaderText = "Cédula";
            this.ci.Name = "ci";
            this.ci.ReadOnly = true;
            this.ci.Width = 60;
            // 
            // nom
            // 
            this.nom.Frozen = true;
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // ape
            // 
            this.ape.Frozen = true;
            this.ape.HeaderText = "Apellido";
            this.ape.Name = "ape";
            this.ape.ReadOnly = true;
            // 
            // dir
            // 
            this.dir.Frozen = true;
            this.dir.HeaderText = "Dirección";
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            this.dir.Width = 250;
            // 
            // telf
            // 
            this.telf.Frozen = true;
            this.telf.HeaderText = "Teléfono";
            this.telf.Name = "telf";
            this.telf.ReadOnly = true;
            // 
            // alqDGV
            // 
            this.alqDGV.AllowUserToOrderColumns = true;
            this.alqDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.alqDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alqDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client,
            this.car,
            this.f_alq,
            this.dias,
            this.monto});
            this.alqDGV.Location = new System.Drawing.Point(10, 63);
            this.alqDGV.Name = "alqDGV";
            this.alqDGV.Size = new System.Drawing.Size(672, 311);
            this.alqDGV.TabIndex = 6;
            this.alqDGV.Visible = false;
            // 
            // alq_btn
            // 
            this.alq_btn.Location = new System.Drawing.Point(174, 4);
            this.alq_btn.Name = "alq_btn";
            this.alq_btn.Size = new System.Drawing.Size(75, 23);
            this.alq_btn.TabIndex = 5;
            this.alq_btn.Text = "Alquileres";
            this.alq_btn.UseVisualStyleBackColor = true;
            this.alq_btn.Click += new System.EventHandler(this.alq_btn_Click);
            // 
            // client
            // 
            this.client.Frozen = true;
            this.client.HeaderText = "Cliente";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // car
            // 
            this.car.Frozen = true;
            this.car.HeaderText = "Vehiculo";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            // 
            // f_alq
            // 
            this.f_alq.Frozen = true;
            this.f_alq.HeaderText = "Fecha Alquiler";
            this.f_alq.Name = "f_alq";
            this.f_alq.ReadOnly = true;
            // 
            // dias
            // 
            this.dias.Frozen = true;
            this.dias.HeaderText = "Días Alquiler";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.Frozen = true;
            this.monto.HeaderText = "Monto Alquiler";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 386);
            this.Controls.Add(this.alqDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vehiDGV);
            this.Controls.Add(this.cliDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            ((System.ComponentModel.ISupportInitialize)(this.cliDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alqDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cliDGV;
        private System.Windows.Forms.DataGridView vehiDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn condi;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSeguro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn telf;
        private System.Windows.Forms.Button alq_btn;
        private System.Windows.Forms.DataGridView alqDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_alq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}