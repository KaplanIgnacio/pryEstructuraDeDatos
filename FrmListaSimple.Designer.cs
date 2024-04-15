namespace pryEstructuraDeDatos
{
    partial class FrmListaSimple
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
            this.marcoNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.marcoElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodi = new System.Windows.Forms.Label();
            this.marcoLIstayGrilla = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marcoNuevoElemento.SuspendLayout();
            this.marcoElementoEliminado.SuspendLayout();
            this.marcoLIstayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // marcoNuevoElemento
            // 
            this.marcoNuevoElemento.Controls.Add(this.txtTramite);
            this.marcoNuevoElemento.Controls.Add(this.txtNombre);
            this.marcoNuevoElemento.Controls.Add(this.txtCodigo);
            this.marcoNuevoElemento.Controls.Add(this.btnAgregar3);
            this.marcoNuevoElemento.Controls.Add(this.lblTram);
            this.marcoNuevoElemento.Controls.Add(this.lblNom);
            this.marcoNuevoElemento.Controls.Add(this.lblCod);
            this.marcoNuevoElemento.Location = new System.Drawing.Point(323, 33);
            this.marcoNuevoElemento.Name = "marcoNuevoElemento";
            this.marcoNuevoElemento.Size = new System.Drawing.Size(182, 192);
            this.marcoNuevoElemento.TabIndex = 2;
            this.marcoNuevoElemento.TabStop = false;
            this.marcoNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(89, 110);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(68, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(68, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.Location = new System.Drawing.Point(32, 149);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar3.TabIndex = 3;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = true;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // lblTram
            // 
            this.lblTram.AutoSize = true;
            this.lblTram.Location = new System.Drawing.Point(22, 112);
            this.lblTram.Name = "lblTram";
            this.lblTram.Size = new System.Drawing.Size(45, 13);
            this.lblTram.TabIndex = 2;
            this.lblTram.Text = "Trámite:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 76);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(22, 41);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // marcoElementoEliminado
            // 
            this.marcoElementoEliminado.Controls.Add(this.btnEliminar);
            this.marcoElementoEliminado.Controls.Add(this.lblCodi);
            this.marcoElementoEliminado.Location = new System.Drawing.Point(588, 33);
            this.marcoElementoEliminado.Name = "marcoElementoEliminado";
            this.marcoElementoEliminado.Size = new System.Drawing.Size(182, 192);
            this.marcoElementoEliminado.TabIndex = 3;
            this.marcoElementoEliminado.TabStop = false;
            this.marcoElementoEliminado.Text = "Elemento a eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(40, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 29);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Location = new System.Drawing.Point(26, 108);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(43, 13);
            this.lblCodi.TabIndex = 1;
            this.lblCodi.Text = "Código:";
            // 
            // marcoLIstayGrilla
            // 
            this.marcoLIstayGrilla.Controls.Add(this.lstCola);
            this.marcoLIstayGrilla.Controls.Add(this.dgvCola);
            this.marcoLIstayGrilla.Location = new System.Drawing.Point(33, 252);
            this.marcoLIstayGrilla.Name = "marcoLIstayGrilla";
            this.marcoLIstayGrilla.Size = new System.Drawing.Size(737, 250);
            this.marcoLIstayGrilla.TabIndex = 4;
            this.marcoLIstayGrilla.TabStop = false;
            this.marcoLIstayGrilla.Text = "Listado en una Lista y Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(43, 32);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(246, 186);
            this.lstCola.TabIndex = 2;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Tramite});
            this.dgvCola.Location = new System.Drawing.Point(352, 31);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(339, 192);
            this.dgvCola.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            // 
            // btnVolver4
            // 
            this.btnVolver4.Location = new System.Drawing.Point(33, 517);
            this.btnVolver4.Name = "btnVolver4";
            this.btnVolver4.Size = new System.Drawing.Size(76, 26);
            this.btnVolver4.TabIndex = 5;
            this.btnVolver4.Text = "Volver";
            this.btnVolver4.UseVisualStyleBackColor = true;
            this.btnVolver4.Click += new System.EventHandler(this.btnVolver4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources.insercion;
            this.pictureBox1.Location = new System.Drawing.Point(33, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnVolver4);
            this.Controls.Add(this.marcoLIstayGrilla);
            this.Controls.Add(this.marcoElementoEliminado);
            this.Controls.Add(this.marcoNuevoElemento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaSimple";
            this.marcoNuevoElemento.ResumeLayout(false);
            this.marcoNuevoElemento.PerformLayout();
            this.marcoElementoEliminado.ResumeLayout(false);
            this.marcoElementoEliminado.PerformLayout();
            this.marcoLIstayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox marcoNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox marcoElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.GroupBox marcoLIstayGrilla;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Button btnVolver4;
    }
}