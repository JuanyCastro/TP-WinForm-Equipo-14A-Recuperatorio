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
    public partial class frmModificarMarca : Form
    {
        private Marca marca = null;
        public frmModificarMarca()
        {
            InitializeComponent();
        }

        public frmModificarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txtDescripcion.Text = marca.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la marca.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (negocio.existeMarca(txtDescripcion.Text, marca.Id))
                {
                    MessageBox.Show("La marca ingresada ya existe en la base de datos. Por favor, ingrese una distinta.", "Marca Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                marca.Descripcion = txtDescripcion.Text;

                negocio.modificar(marca);
                MessageBox.Show("Marca modificada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
