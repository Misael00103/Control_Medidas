namespace Control_Medidas
{
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturando Parametros
            double metros = double.Parse(txtMetros.Text);

            //Realizar conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            //Mostrando los resultados de las conversiones 
            lstR.Items.Add("** RESUMEN DE CONVERSIONES **");
            lstR.Items.Add("MEDIDA EN METROS: " + metros.ToString("0.00"));
            lstR.Items.Add("---------------------------------------------");
            lstR.Items.Add("MEDIDA EN CENTIMETROS: " + centimetros.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PULGADAS: " + pulgadas.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PIES: " + pies.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN YARDAS: " + yardas.ToString("0.00"));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de salir?","Medidas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();
        }
    }
}