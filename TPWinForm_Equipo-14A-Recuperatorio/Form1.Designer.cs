namespace TPWinForm_Equipo_14A_Recuperatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tBoxFiltro = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tsbEliminarArticulo = new System.Windows.Forms.ToolStripButton();
            this.tsbVerDetalle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGestionMarcas = new System.Windows.Forms.ToolStripButton();
            this.tsbGestionCategorias = new System.Windows.Forms.ToolStripButton();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.tsbNuevoArticulo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(56, 145);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(772, 335);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(52, 67);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(256, 30);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Búsqueda de Artículos:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(54, 115);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Campo:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(221, 115);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Criterio:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(387, 115);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(32, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Filtro:";
            // 
            // tBoxFiltro
            // 
            this.tBoxFiltro.Location = new System.Drawing.Point(434, 113);
            this.tBoxFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxFiltro.Name = "tBoxFiltro";
            this.tBoxFiltro.Size = new System.Drawing.Size(312, 20);
            this.tBoxFiltro.TabIndex = 5;
            // 
            // cboCriterio
            // 
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(278, 112);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(92, 21);
            this.cboCriterio.TabIndex = 6;
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(112, 112);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(92, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(764, 111);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 21);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tsbEliminarArticulo
            // 
            this.tsbEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarArticulo.Image")));
            this.tsbEliminarArticulo.Name = "tsbEliminarArticulo";
            this.tsbEliminarArticulo.Size = new System.Drawing.Size(99, 39);
            this.tsbEliminarArticulo.Text = "Eliminar Artículo";
            this.tsbEliminarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEliminarArticulo.Click += new System.EventHandler(this.tsbEliminarArticulo_Click);
            // 
            // tsbVerDetalle
            // 
            this.tsbVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("tsbVerDetalle.Image")));
            this.tsbVerDetalle.Name = "tsbVerDetalle";
            this.tsbVerDetalle.Size = new System.Drawing.Size(66, 39);
            this.tsbVerDetalle.Text = "Ver Detalle";
            this.tsbVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVerDetalle.Click += new System.EventHandler(this.tsbVerDetalle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbGestionMarcas
            // 
            this.tsbGestionMarcas.Image = ((System.Drawing.Image)(resources.GetObject("tsbGestionMarcas.Image")));
            this.tsbGestionMarcas.Name = "tsbGestionMarcas";
            this.tsbGestionMarcas.Size = new System.Drawing.Size(92, 39);
            this.tsbGestionMarcas.Text = "Gestión Marcas";
            this.tsbGestionMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGestionMarcas.Click += new System.EventHandler(this.tsbGestionMarcas_Click);
            // 
            // tsbGestionCategorias
            // 
            this.tsbGestionCategorias.Image = ((System.Drawing.Image)(resources.GetObject("tsbGestionCategorias.Image")));
            this.tsbGestionCategorias.Name = "tsbGestionCategorias";
            this.tsbGestionCategorias.Size = new System.Drawing.Size(110, 39);
            this.tsbGestionCategorias.Text = "Gestión Categorías";
            this.tsbGestionCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGestionCategorias.Click += new System.EventHandler(this.tsbGestionCategorias_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(854, 145);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(354, 335);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 10;
            this.pbxArticulo.TabStop = false;
            // 
            // tsbNuevoArticulo
            // 
            this.tsbNuevoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoArticulo.Image")));
            this.tsbNuevoArticulo.Name = "tsbNuevoArticulo";
            this.tsbNuevoArticulo.Size = new System.Drawing.Size(91, 39);
            this.tsbNuevoArticulo.Text = "Nuevo Artículo";
            this.tsbNuevoArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevoArticulo.Click += new System.EventHandler(this.tsbNuevoArticulo_Click);
            // 
            // tsbModificarArticulo
            // 
            this.tsbModificarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificarArticulo.Image")));
            this.tsbModificarArticulo.Name = "tsbModificarArticulo";
            this.tsbModificarArticulo.Size = new System.Drawing.Size(107, 39);
            this.tsbModificarArticulo.Text = "Modificar Artículo";
            this.tsbModificarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificarArticulo.Click += new System.EventHandler(this.tsbModificarArticulo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoArticulo,
            this.tsbModificarArticulo,
            this.tsbEliminarArticulo,
            this.tsbVerDetalle,
            this.toolStripSeparator1,
            this.tsbGestionMarcas,
            this.tsbGestionCategorias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1285, 42);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 549);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.tBoxFiltro);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Catálogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tBoxFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ToolStripButton tsbNuevoArticulo;
        private System.Windows.Forms.ToolStripButton tsbModificarArticulo;
        private System.Windows.Forms.ToolStripButton tsbEliminarArticulo;
        private System.Windows.Forms.ToolStripButton tsbVerDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGestionMarcas;
        private System.Windows.Forms.ToolStripButton tsbGestionCategorias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

