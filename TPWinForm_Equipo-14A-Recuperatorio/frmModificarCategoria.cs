using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo_14A_Recuperatorio
{
    public partial class frmModificarCategoria : Form
    {
        private Categoria categoria = null;
        public frmModificarCategoria()
        {
            InitializeComponent();
        }

        public frmModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtDescripcion.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la categoria.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (negocio.existeCategoria(txtDescripcion.Text, categoria.Id))
                {
                    MessageBox.Show("La categoría ingresada ya existe en la base de datos. Por favor, ingrese una distinta.", "Categoría Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                categoria.Descripcion = txtDescripcion.Text;

                negocio.modificar(categoria);
                MessageBox.Show("Categoria modificada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
