using Newtonsoft.Json;

namespace Serialización
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCargarProducton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JSON|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonFilePath = openFileDialog.FileName;

                try
                {
                    string jsonContent = System.IO.File.ReadAllText(jsonFilePath);
                    Producto producto = JsonConvert.DeserializeObject<Producto>(jsonContent);

                    MostrarDatosProducto(producto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message);
                }
            }
        }

        private void MostrarDatosProducto(Producto producto)
        {
            txtBxCodigo.Text = producto.Codigo;
            txtBxDescripcion.Text = producto.Descripcion;
            txtBxPrecio.Text = producto.Precio.ToString();
            txtBxExistencia.Text = producto.Existencia.ToString();
        }
    }

    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}



      
