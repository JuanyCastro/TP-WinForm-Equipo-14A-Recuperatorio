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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private bool soloLectura = false;
        private int indiceImagenActual = 0;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        public frmAltaArticulo(Articulo articulo, bool soloLectura)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.soloLectura = soloLectura;
            Text = soloLectura ? "Detalle Artículo" : "Modificar Artículo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();
            //ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                int idActual = articulo != null ? articulo.Id : 0;

                if (negocio.existeCodigo(txtCodigo.Text, idActual))
                {
                    MessageBox.Show("El código ingresado ya pertenece a otro artículo. Por favor, ingrese uno distinto.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.MarcaArticulo = (Marca)cboMarca.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);

                    //if (articulo.Imagenes != null)
                    //{
                    //    foreach (Imagen img in articulo.Imagenes)
                    //    {
                    //        if (img.Id == 0)
                    //        {
                    //            img.IdArticulo = articulo.Id;
                    //            imgNegocio.agregar(img);
                    //        }
                    //    }
                    //}
                    MessageBox.Show("Artículo modificado exitosamente");
                }
                else
                {
                    int idGenerado = negocio.agregar(articulo);

                    //if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                    //{
                    //    foreach (Imagen img in articulo.Imagenes)
                    //    {
                    //        img.IdArticulo = idGenerado;
                    //        imgNegocio.agregar(img);
                    //    }
                    //}
                    MessageBox.Show("Artículo agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulonegocio = new ArticuloNegocio();
            //MarcaNegocio marcaNegocio = new MarcaNegocio();
            //CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                //cboMarca.DataSource = marcaNegocio.listar();
                //cboMarca.DisplayMember = "Descripcion";
                //cboMarca.ValueMember = "Id";
                //cboCategoria.DataSource = categoriaNegocio.listar();
                //cboCategoria.DisplayMember = "Descripcion";
                //cboCategoria.ValueMember = "Id";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;

                    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                    {
                        txtImagen.Text = articulo.Imagenes[0].ImagenUrl;
                        cargarImagen(articulo.Imagenes[0].ImagenUrl);
                    }
                    else
                    {
                        txtImagen.Text = "";
                        cargarImagen("");
                    }

                    cboMarca.SelectedValue = articulo.MarcaArticulo.Id;
                    cboCategoria.SelectedValue = articulo.CategoriaArticulo.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }

                if (soloLectura)
                {
                    txtCodigo.ReadOnly = true;
                    txtCodigo.TabStop = false;
                    txtNombre.ReadOnly = true;
                    txtNombre.TabStop = false;
                    txtDescripcion.ReadOnly = true;
                    txtDescripcion.TabStop = false;
                    txtImagen.ReadOnly = true;
                    txtImagen.TabStop = false;
                    txtPrecio.ReadOnly = true;
                    txtPrecio.TabStop = false;
                    cboMarca.Enabled = false;
                    cboCategoria.Enabled = false;
                    btnAceptar.Visible = false;
                    btnAgregarImagen.Visible = false;
                    btnEliminarImagen.Visible = false;
                    btnCancelar.Text = "Cerrar";
                }

                mostrarImagenActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                if (string.IsNullOrEmpty(imagen))
                {
                    pbxDetalle.Load("https://dummyimage.com/400x400/efefef/000000&text=Sin+Imagen");
                    return;
                }
                pbxDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pbxDetalle.Load("https://dummyimage.com/400x400/efefef/000000&text=Sin+Imagen");
            }
        }
        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete el código, nombre y descripción del artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (cboMarca.SelectedIndex < 0 || cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una marca y una categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, ingrese el precio del artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            decimal precioAux;
            if (!decimal.TryParse(txtPrecio.Text, out precioAux))
            {
                MessageBox.Show("El formato del precio es incorrecto. Por favor ingrese solo números y coma decimal.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (precioAux < 0)
            {
                MessageBox.Show("El precio no puede ser un valor negativo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            indiceImagenActual--;
            mostrarImagenActual();
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            indiceImagenActual++;
            mostrarImagenActual();
        }

        private void mostrarImagenActual()
        {
            if (articulo == null || articulo.Imagenes == null || articulo.Imagenes.Count == 0)
            {
                cargarImagen("");
                btnImagenAnterior.Enabled = false;
                btnImagenSiguiente.Enabled = false;
                txtImagen.Clear();

                if (lblContadorImagen != null)
                    lblContadorImagen.Text = "0 / 0";

                return;
            }

            cargarImagen(articulo.Imagenes[indiceImagenActual].ImagenUrl);
            txtImagen.Text = articulo.Imagenes[indiceImagenActual].ImagenUrl;

            if (lblContadorImagen != null)
                lblContadorImagen.Text = (indiceImagenActual + 1) + " / " + articulo.Imagenes.Count;

            btnImagenAnterior.Enabled = (indiceImagenActual > 0);
            btnImagenSiguiente.Enabled = (indiceImagenActual < articulo.Imagenes.Count - 1);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string nuevaUrl = txtImagen.Text;

            if (string.IsNullOrWhiteSpace(nuevaUrl))
            {
                MessageBox.Show("Pegue una URL válida primero.");
                return;
            }

            if (articulo == null)
            {
                articulo = new Articulo();
            }

            if (articulo.Imagenes == null)
            {
                articulo.Imagenes = new List<Imagen>();
            }

            Imagen nuevaImagen = new Imagen();
            nuevaImagen.ImagenUrl = nuevaUrl;
            articulo.Imagenes.Add(nuevaImagen);

            indiceImagenActual = articulo.Imagenes.Count - 1;
            mostrarImagenActual();

            txtImagen.Clear();
        }

        //private void btnEliminarImagen_Click(object sender, EventArgs e)
        //{
        //    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
        //    {
        //        DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar esta imagen?", "Eliminar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (respuesta == DialogResult.Yes)
        //        {
        //            Imagen imgActual = articulo.Imagenes[indiceImagenActual];

        //            if (imgActual.Id != 0)
        //            {
        //                ImagenNegocio imgNegocio = new ImagenNegocio();
        //                imgNegocio.eliminar(imgActual.Id);
        //            }

        //            articulo.Imagenes.RemoveAt(indiceImagenActual);

        //            if (indiceImagenActual > 0)
        //                indiceImagenActual--;

        //            mostrarImagenActual();
        //        }
        //    }
        //}
    }
}
