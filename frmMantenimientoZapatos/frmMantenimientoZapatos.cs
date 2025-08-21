using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMantenimientoZapatos
{
    public partial class frmMantenimientoZapatos : Form
    {
        public frmMantenimientoZapatos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoZapatos_Load(object sender, EventArgs e)
        {
            cargarEspecialidad();
            cargarZapatos();
        }

        private void cargarZapatos()
        {
            dgvProductosAlmacen.DataSource = null;
            dgvProductosAlmacen.DataSource = Zapato.cargarZapatos();

            //Cargar datos en el otro datagrid
            dgvMostrarProducAlmacen.DataSource = null;
            dgvMostrarProducAlmacen.DataSource=Zapato.cargarZapatos();
        }


        //Creando el metodo cargarEspecialidad o categoria

        private void cargarEspecialidad() 
        {
            //Esto es para los combobox
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = Categoria.cargarCategoria();
            //Ahora voy a usar el displayMember
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            //El -1 sirve para que no aparezca nada al momento de cargar la lista
            cmbCategoria.SelectedIndex = -1;

            //-----Tambien para el mismo pero para el form de actualizar
            cmbCategoriaActInfo.DataSource = null;
            cmbCategoriaActInfo.DataSource = Categoria.cargarCategoria();
            cmbCategoriaActInfo.DisplayMember = "Nombre";
            cmbCategoriaActInfo.ValueMember = "Id";
            cmbCategoriaActInfo.SelectedIndex = -1;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Zapato zap = new Zapato();
                zap.Nombre=txtNombreZapato.Text;
                zap.Precio = double.Parse(txtPrecioZapato.Text);
                zap.FechaCreacion = dtpFechaRegistro.Value;
                zap.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                zap.ImagenURL = "";
                zap.insertarZapatos();
                cargarZapatos();
                MessageBox.Show("Excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Zapato zapatoEliminar = new Zapato();
            int id = int.Parse(dgvProductosAlmacen.CurrentRow.Cells[0].Value.ToString());
            string registroAEliminar = dgvProductosAlmacen.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n"+ registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta==DialogResult.Yes) {
                if (zapatoEliminar.eliminarZapato(id)==true) {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }
            else {
            
            }
        }
    }
}
