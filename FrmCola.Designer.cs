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
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.marcoElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodi = new System.Windows.Forms.Label();
            this.marcoLIstayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvDatosCliente = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListView();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.pctImagenCola = new System.Windows.Forms.PictureBox();
            this.marcoNuevoElemento.SuspendLayout();
            this.marcoElementoEliminado.SuspendLayout();
            this.marcoLIstayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenCola)).BeginInit();
            this.SuspendLayout();
            // 
            // marcoNuevoElemento
            // 
            this.marcoNuevoElemento.Controls.Add(this.lblTramite1);
            this.marcoNuevoElemento.Controls.Add(this.lblNombre1);
            this.marcoNuevoElemento.Controls.Add(this.lblCodigo1);
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
            // lblTramite1
            // 
            this.lblTramite1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite1.Location = new System.Drawing.Point(93, 106);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(69, 19);
            this.lblTramite1.TabIndex = 6;
            // 
            // lblNombre1
            // 
            this.lblNombre1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre1.Location = new System.Drawing.Point(93, 70);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(69, 19);
            this.lblNombre1.TabIndex = 5;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo1.Location = new System.Drawing.Point(93, 40);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(69, 19);
            this.lblCodigo1.TabIndex = 4;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(32, 149);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar1.TabIndex = 3;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
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
            this.marcoElementoEliminado.Controls.Add(this.lblCodigo2);
            this.marcoElementoEliminado.Controls.Add(this.lblNombre2);
            this.marcoElementoEliminado.Controls.Add(this.lblTramite2);
            this.marcoElementoEliminado.Controls.Add(this.btnAgregar2);
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
            // lblCodigo2
            // 
            this.lblCodigo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo2.Location = new System.Drawing.Point(84, 40);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(69, 19);
            this.lblCodigo2.TabIndex = 7;
            // 
            // lblNombre2
            // 
            this.lblNombre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre2.Location = new System.Drawing.Point(84, 76);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(69, 19);
            this.lblNombre2.TabIndex = 6;
            // 
            // lblTramite2
            // 
            this.lblTramite2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite2.Location = new System.Drawing.Point(84, 111);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(69, 19);
            this.lblTramite2.TabIndex = 5;
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(40, 149);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar2.TabIndex = 4;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
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
            this.marcoLIstayGrilla.Controls.Add(this.dgvDatosCliente);
            this.marcoLIstayGrilla.Controls.Add(this.lstCola);
            this.marcoLIstayGrilla.Location = new System.Drawing.Point(22, 248);
            this.marcoLIstayGrilla.Name = "marcoLIstayGrilla";
            this.marcoLIstayGrilla.Size = new System.Drawing.Size(737, 237);
            this.marcoLIstayGrilla.TabIndex = 3;
            this.marcoLIstayGrilla.TabStop = false;
            this.marcoLIstayGrilla.Text = "Listado en una Lista y Grilla";
            // 
            // dgvDatosCliente
            // 
            this.dgvDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Tramite});
            this.dgvDatosCliente.Location = new System.Drawing.Point(352, 31);
            this.dgvDatosCliente.Name = "dgvDatosCliente";
            this.dgvDatosCliente.Size = new System.Drawing.Size(339, 192);
            this.dgvDatosCliente.TabIndex = 1;
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
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(66, 31);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(201, 192);
            this.lstCola.TabIndex = 0;
            this.lstCola.UseCompatibleStateImageBehavior = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagenCola;
        private System.Windows.Forms.GroupBox marcoNuevoElemento;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox marcoElementoEliminado;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.GroupBox marcoLIstayGrilla;
        private System.Windows.Forms.DataGridView dgvDatosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.Button btnVolver2;
    }
}