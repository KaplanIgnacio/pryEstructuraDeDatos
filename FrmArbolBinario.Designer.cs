namespace pryEstructuraDeDatos
{
    partial class FrmArbolBinario
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
            this.btnVolver6 = new System.Windows.Forms.Button();
            this.marcoLIstayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcoElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodi = new System.Windows.Forms.Label();
            this.marcoNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar4 = new System.Windows.Forms.Button();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rbInOrdenAscendente = new System.Windows.Forms.RadioButton();
            this.rbInOrdenDescendente = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.marcoLIstayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.marcoElementoEliminado.SuspendLayout();
            this.marcoNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver6
            // 
            this.btnVolver6.Location = new System.Drawing.Point(32, 508);
            this.btnVolver6.Name = "btnVolver6";
            this.btnVolver6.Size = new System.Drawing.Size(76, 26);
            this.btnVolver6.TabIndex = 16;
            this.btnVolver6.Text = "Volver";
            this.btnVolver6.UseVisualStyleBackColor = true;
            this.btnVolver6.Click += new System.EventHandler(this.btnVolver6_Click);
            // 
            // marcoLIstayGrilla
            // 
            this.marcoLIstayGrilla.Controls.Add(this.rbPostOrden);
            this.marcoLIstayGrilla.Controls.Add(this.rbPreOrden);
            this.marcoLIstayGrilla.Controls.Add(this.rbInOrdenDescendente);
            this.marcoLIstayGrilla.Controls.Add(this.rbInOrdenAscendente);
            this.marcoLIstayGrilla.Controls.Add(this.dgvCola);
            this.marcoLIstayGrilla.Location = new System.Drawing.Point(32, 243);
            this.marcoLIstayGrilla.Name = "marcoLIstayGrilla";
            this.marcoLIstayGrilla.Size = new System.Drawing.Size(737, 250);
            this.marcoLIstayGrilla.TabIndex = 15;
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
            // marcoElementoEliminado
            // 
            this.marcoElementoEliminado.Controls.Add(this.cmbLista);
            this.marcoElementoEliminado.Controls.Add(this.btnEliminar);
            this.marcoElementoEliminado.Controls.Add(this.lblCodi);
            this.marcoElementoEliminado.Location = new System.Drawing.Point(564, 24);
            this.marcoElementoEliminado.Name = "marcoElementoEliminado";
            this.marcoElementoEliminado.Size = new System.Drawing.Size(182, 104);
            this.marcoElementoEliminado.TabIndex = 14;
            this.marcoElementoEliminado.TabStop = false;
            this.marcoElementoEliminado.Text = "Elemento a eliminar";
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(61, 25);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(115, 21);
            this.cmbLista.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 29);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Location = new System.Drawing.Point(17, 28);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(43, 13);
            this.lblCodi.TabIndex = 1;
            this.lblCodi.Text = "Código:";
            // 
            // marcoNuevoElemento
            // 
            this.marcoNuevoElemento.Controls.Add(this.txtTramite);
            this.marcoNuevoElemento.Controls.Add(this.txtNombre);
            this.marcoNuevoElemento.Controls.Add(this.txtCodigo);
            this.marcoNuevoElemento.Controls.Add(this.btnAgregar4);
            this.marcoNuevoElemento.Controls.Add(this.lblTram);
            this.marcoNuevoElemento.Controls.Add(this.lblNom);
            this.marcoNuevoElemento.Controls.Add(this.lblCod);
            this.marcoNuevoElemento.Location = new System.Drawing.Point(322, 24);
            this.marcoNuevoElemento.Name = "marcoNuevoElemento";
            this.marcoNuevoElemento.Size = new System.Drawing.Size(182, 192);
            this.marcoNuevoElemento.TabIndex = 13;
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
            // btnAgregar4
            // 
            this.btnAgregar4.Location = new System.Drawing.Point(32, 149);
            this.btnAgregar4.Name = "btnAgregar4";
            this.btnAgregar4.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar4.TabIndex = 3;
            this.btnAgregar4.Text = "Agregar";
            this.btnAgregar4.UseVisualStyleBackColor = true;
            this.btnAgregar4.Click += new System.EventHandler(this.btnAgregar4_Click);
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(564, 163);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(182, 39);
            this.btnEquilibrar.TabIndex = 17;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 192);
            this.treeView1.TabIndex = 18;
            // 
            // rbInOrdenAscendente
            // 
            this.rbInOrdenAscendente.AutoSize = true;
            this.rbInOrdenAscendente.Location = new System.Drawing.Point(65, 63);
            this.rbInOrdenAscendente.Name = "rbInOrdenAscendente";
            this.rbInOrdenAscendente.Size = new System.Drawing.Size(126, 17);
            this.rbInOrdenAscendente.TabIndex = 2;
            this.rbInOrdenAscendente.TabStop = true;
            this.rbInOrdenAscendente.Text = "In-Orden Ascendente";
            this.rbInOrdenAscendente.UseVisualStyleBackColor = true;
            // 
            // rbInOrdenDescendente
            // 
            this.rbInOrdenDescendente.AutoSize = true;
            this.rbInOrdenDescendente.Location = new System.Drawing.Point(65, 101);
            this.rbInOrdenDescendente.Name = "rbInOrdenDescendente";
            this.rbInOrdenDescendente.Size = new System.Drawing.Size(133, 17);
            this.rbInOrdenDescendente.TabIndex = 3;
            this.rbInOrdenDescendente.TabStop = true;
            this.rbInOrdenDescendente.Text = "In-Orden Descendente";
            this.rbInOrdenDescendente.UseVisualStyleBackColor = true;
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(65, 143);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rbPreOrden.TabIndex = 4;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(65, 184);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rbPostOrden.TabIndex = 5;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            // 
            // FrmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.btnVolver6);
            this.Controls.Add(this.marcoLIstayGrilla);
            this.Controls.Add(this.marcoElementoEliminado);
            this.Controls.Add(this.marcoNuevoElemento);
            this.Name = "FrmArbolBinario";
            this.Text = "FrmArbolBinario";
            this.marcoLIstayGrilla.ResumeLayout(false);
            this.marcoLIstayGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.marcoElementoEliminado.ResumeLayout(false);
            this.marcoElementoEliminado.PerformLayout();
            this.marcoNuevoElemento.ResumeLayout(false);
            this.marcoNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver6;
        private System.Windows.Forms.GroupBox marcoLIstayGrilla;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox marcoElementoEliminado;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.GroupBox marcoNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar4;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrdenDescendente;
        private System.Windows.Forms.RadioButton rbInOrdenAscendente;
    }
}