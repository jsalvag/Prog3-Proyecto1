namespace Prog3_Proyecto1
{
    partial class Reportes
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
            this.miDGV = new System.Windows.Forms.DataGridView();
            this.ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.miDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miDGV
            // 
            this.miDGV.AllowUserToOrderColumns = true;
            this.miDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ci,
            this.nom,
            this.ape,
            this.dir,
            this.telf});
            this.miDGV.Location = new System.Drawing.Point(20, 67);
            this.miDGV.Name = "miDGV";
            this.miDGV.Size = new System.Drawing.Size(547, 150);
            this.miDGV.TabIndex = 2;
            // 
            // ci
            // 
            this.ci.Frozen = true;
            this.ci.HeaderText = "Cédula";
            this.ci.Name = "ci";
            this.ci.ReadOnly = true;
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
            // 
            // telf
            // 
            this.telf.Frozen = true;
            this.telf.HeaderText = "Teléfono";
            this.telf.Name = "telf";
            this.telf.ReadOnly = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 386);
            this.Controls.Add(this.miDGV);
            this.Controls.Add(this.button1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.miDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView miDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn telf;
    }
}