namespace WindowsFormIMC
{
    public partial class FrmImc : Form
    {
        float imc = 0;
        
        public FrmImc()
        {
            InitializeComponent();
        }

        private float CalculoImc(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;
        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            float peso;
            float altura;

            if (!float.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um peso válido.");
            }

            if (!float.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Digite uma altura válida.");
            }

            CalculoImc(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));
            string tipoImc;

            switch (imc)
            {
                case >= 40:
                    tipoImc = "Obesidade III";
                    break;

                case >= 35:
                    tipoImc = "Obesidade II";
                    break;

                case >= 30:
                    tipoImc = "Obesidade I";
                    break;

                case >= 25:
                    tipoImc = ("Levemente acima do Peso");
                    break;

                case >= 18:
                    tipoImc = ("Peso Ideal");
                    break;

                default:
                    tipoImc = ("Abaixo do Peso");
                    break;
            }
            MessageBox.Show($"IMC: {imc:F2}\n" +
                $"Grau: {tipoImc}",
                "IMC",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }   
    }
}
