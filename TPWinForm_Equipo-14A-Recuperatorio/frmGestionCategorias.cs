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
    public partial class frmGestionCategorias : Form
    {
        private List<Categoria> listaCategoria;
        private Categoria categoria = null;
        public frmGestionCategorias()
        {
            InitializeComponent();
        }

        private void frmGestionCategorias_Load(object sender, EventArgs e)
        {
            cargar();
            dgvCategorias.Columns["Id"].Visible = false;
        }
        public frmGestionCategorias(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            }
        }

        private void tsbEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                    MessageBox.Show("Categoria eliminada exitosamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmModificarCategoria modificar = new frmModificarCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la nueva categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (negocio.existeCategoria(txtNombre.Text))
                {
                    MessageBox.Show("La categoría ingresada ya existe en la base de datos. Por favor, ingrese una distinta.", "Categoría Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.Descripcion = txtNombre.Text;

                negocio.agregar(nuevaCategoria);

                MessageBox.Show("Categoria agregada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();

                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
