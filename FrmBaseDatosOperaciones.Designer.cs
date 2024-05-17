namespace pryEstructuraDeDatos
{
    partial class FrmBaseDatosOperaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mrcSelect = new System.Windows.Forms.GroupBox();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.btnProyMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.mrcAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.mrcWhere = new System.Windows.Forms.GroupBox();
            this.btnSelecConvo = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mrcSelect.SuspendLayout();
            this.mrcAlgebraicas.SuspendLayout();
            this.mrcWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // mrcSelect
            // 
            this.mrcSelect.Controls.Add(this.btnJuntar);
            this.mrcSelect.Controls.Add(this.btnProyMulti);
            this.mrcSelect.Controls.Add(this.btnProySimple);
            this.mrcSelect.Location = new System.Drawing.Point(14, 350);
            this.mrcSelect.Name = "mrcSelect";
            this.mrcSelect.Size = new System.Drawing.Size(211, 160);
            this.mrcSelect.TabIndex = 1;
            this.mrcSelect.TabStop = false;
            this.mrcSelect.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(15, 28);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(174, 27);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección Simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // btnProyMulti
            // 
            this.btnProyMulti.Location = new System.Drawing.Point(15, 73);
            this.btnProyMulti.Name = "btnProyMulti";
            this.btnProyMulti.Size = new System.Drawing.Size(174, 27);
            this.btnProyMulti.TabIndex = 1;
            this.btnProyMulti.Text = "Proyección Multiatributo";
            this.btnProyMulti.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(15, 117);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(174, 27);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // mrcAlgebraicas
            // 
            this.mrcAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mrcAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mrcAlgebraicas.Controls.Add(this.btnUnion);
            this.mrcAlgebraicas.Location = new System.Drawing.Point(552, 347);
            this.mrcAlgebraicas.Name = "mrcAlgebraicas";
            this.mrcAlgebraicas.Size = new System.Drawing.Size(211, 160);
            this.mrcAlgebraicas.TabIndex = 2;
            this.mrcAlgebraicas.TabStop = false;
            this.mrcAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(15, 117);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(174, 27);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(15, 73);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(174, 27);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(15, 28);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(174, 27);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // mrcWhere
            // 
            this.mrcWhere.Controls.Add(this.btnSelecConvo);
            this.mrcWhere.Controls.Add(this.btnSelecMulti);
            this.mrcWhere.Controls.Add(this.btnSelecSimple);
            this.mrcWhere.Location = new System.Drawing.Point(288, 350);
            this.mrcWhere.Name = "mrcWhere";
            this.mrcWhere.Size = new System.Drawing.Size(211, 160);
            this.mrcWhere.TabIndex = 3;
            this.mrcWhere.TabStop = false;
            this.mrcWhere.Text = "Operaciones de Proyección - WHERE";
            // 
            // btnSelecConvo
            // 
            this.btnSelecConvo.Location = new System.Drawing.Point(15, 117);
            this.btnSelecConvo.Name = "btnSelecConvo";
            this.btnSelecConvo.Size = new System.Drawing.Size(174, 27);
            this.btnSelecConvo.TabIndex = 2;
            this.btnSelecConvo.Text = "Selección por convolución";
            this.btnSelecConvo.UseVisualStyleBackColor = true;
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(15, 73);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(174, 27);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Selección Multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(15, 28);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(174, 27);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Selección Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(14, 516);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(62, 22);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 547);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcWhere);
            this.Controls.Add(this.mrcAlgebraicas);
            this.Controls.Add(this.mrcSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base De Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mrcSelect.ResumeLayout(false);
            this.mrcAlgebraicas.ResumeLayout(false);
            this.mrcWhere.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox mrcSelect;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMulti;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.GroupBox mrcAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox mrcWhere;
        private System.Windows.Forms.Button btnSelecConvo;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.Button btnVolver;
    }
}