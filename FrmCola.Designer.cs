namespace pryEstructuraDeDatos
{
    partial class FrmCola
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
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.marcoElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodi = new System.Windows.Forms.Label();
            this.marcoLIstayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.pctImagenCola = new System.Windows.Forms.PictureBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.marcoNuevoElemento.SuspendLayout();
            this.marcoElementoEliminado.SuspendLayout();
            this.marcoLIstayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenCola)).BeginInit();
            this.SuspendLayout();
            // 
            // marcoNuevoElemento
            // 
            this.marcoNuevoElemento.Controls.Add(this.txtTramite);
            this.marcoNuevoElemento.Controls.Add(this.txtNombre);
            this.marcoNuevoElemento.Controls.Add(this.txtCodigo);
            this.marcoNuevoElemento.Controls.Add(this.btnAgregar1);
            this.marcoNuevoElemento.Controls.Add(this.lblTram);
            this.marcoNuevoElemento.Controls.Add(this.lblNom);
            this.marcoNuevoElemento.Controls.Add(this.lblCod);
            this.marcoNuevoElemento.Location = new System.Drawing.Point(311, 27);
            this.marcoNuevoElemento.Name = "marcoNuevoElemento";
            this.marcoNuevoElemento.Size = new System.Drawing.Size(182, 192);
            this.marcoNuevoElemento.TabIndex = 1;
            this.marcoNuevoElemento.TabStop = false;
            this.marcoNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(32, 149);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar1.TabIndex = 3;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
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
            this.marcoElementoEliminado.Controls.Add(this.lblCodigo);
            this.marcoElementoEliminado.Controls.Add(this.lblNombre);
            this.marcoElementoEliminado.Controls.Add(this.lblTramite);
            this.marcoElementoEliminado.Controls.Add(this.btnEliminar);
            this.marcoElementoEliminado.Controls.Add(this.label2);
            this.marcoElementoEliminado.Controls.Add(this.label1);
            this.marcoElementoEliminado.Controls.Add(this.lblCodi);
            this.marcoElementoEliminado.Location = new System.Drawing.Point(578, 27);
            this.marcoElementoEliminado.Name = "marcoElementoEliminado";
            this.marcoElementoEliminado.Size = new System.Drawing.Size(182, 192);
            this.marcoElementoEliminado.TabIndex = 2;
            this.marcoElementoEliminado.TabStop = false;
            this.marcoElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(84, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 19);
            this.lblCodigo.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(84, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 6;
            // 
            // lblTramite
            // 
            this.lblTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite.Location = new System.Drawing.Point(84, 111);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(69, 19);
            this.lblTramite.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(40, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 29);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trámite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Location = new System.Drawing.Point(26, 41);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(43, 13);
            this.lblCodi.TabIndex = 1;
            this.lblCodi.Text = "Código:";
            // 
            // marcoLIstayGrilla
            // 
            this.marcoLIstayGrilla.Controls.Add(this.lstCola);
            this.marcoLIstayGrilla.Controls.Add(this.dgvCola);
            this.marcoLIstayGrilla.Location = new System.Drawing.Point(22, 248);
            this.marcoLIstayGrilla.Name = "marcoLIstayGrilla";
            this.marcoLIstayGrilla.Size = new System.Drawing.Size(737, 250);
            this.marcoLIstayGrilla.TabIndex = 3;
            this.marcoLIstayGrilla.TabStop = false;
            this.marcoLIstayGrilla.Text = "Listado en una Lista y Grilla";
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
            // btnVolver2
            // 
            this.btnVolver2.Location = new System.Drawing.Point(22, 504);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(76, 26);
            this.btnVolver2.TabIndex = 4;
            this.btnVolver2.Text = "Volver";
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // pctImagenCola
            // 
            this.pctImagenCola.Image = global::pryEstructuraDeDatos.Properties.Resources.cola;
            this.pctImagenCola.Location = new System.Drawing.Point(22, 14);
            this.pctImagenCola.Name = "pctImagenCola";
            this.pctImagenCola.Size = new System.Drawing.Size(217, 218);
            this.pctImagenCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctImagenCola.TabIndex = 0;
            this.pctImagenCola.TabStop = false;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(43, 32);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(246, 186);
            this.lstCola.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(68, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(89, 110);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(68, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnVolver2);
            this.Controls.Add(this.marcoLIstayGrilla);
            this.Controls.Add(this.marcoElementoEliminado);
            this.Controls.Add(this.marcoNuevoElemento);
            this.Controls.Add(this.pctImagenCola);
            this.Name = "FrmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCola";
            this.marcoNuevoElemento.ResumeLayout(false);
            this.marcoNuevoElemento.PerformLayout();
            this.marcoElementoEliminado.ResumeLayout(false);
            this.marcoElementoEliminado.PerformLayout();
            this.marcoLIstayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagenCola;
        private System.Windows.Forms.GroupBox marcoNuevoElemento;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox marcoElementoEliminado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.GroupBox marcoLIstayGrilla;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}