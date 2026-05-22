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
    public partial class frmGestionMarcas : Form
    {
        private List<Marca> listaMarca;
        private Marca marca = null;
        public frmGestionMarcas()
        {
            InitializeComponent();
        }

        private void frmGestionMarcas_Load(object sender, EventArgs e)
        {
            cargar();
            dgvMarcas.Columns["Id"].Visible = false;
        }
        public frmGestionMarcas(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {

                listaMarca = negocio.listar();
                dgvMarcas.DataSource = listaMarca;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            }
        }

        private void tsbEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una marca de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                    MessageBox.Show("Marca eliminada exitosamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una marca de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmModificarMarca modificar = new frmModificarMarca(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la nueva marca.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (negocio.existeMarca(txtNombre.Text))
                {
                    MessageBox.Show("La marca ingresada ya existe en la base de datos. Por favor, ingrese una distinta.", "Marca Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Marca nuevaMarca = new Marca();
                nuevaMarca.Descripcion = txtNombre.Text;

                negocio.agregar(nuevaMarca);

                MessageBox.Show("Marca agregada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
