namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Producto producto = new Producto();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            calcularOperacion();

        }

        private void calcularOperacion()
        {
            if (textBoxNum1.Text == "" || textBoxNum2.Text == "")
            {
                MessageBox.Show("Ingrese los numeros");
                return;
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Seleccione una operacion");
                return;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Seleccione solo una operacion");
                return;
            }
            else
            {
                producto.num1 = Convert.ToInt32(textBoxNum1.Text);
                producto.num2 = Convert.ToInt32(textBoxNum2.Text);
                producto.sumar = checkBox1.Checked;
                producto.restar = checkBox2.Checked;
                producto.calcular();
                MessageBox.Show($"El resultado es {producto.resultado.ToString()}");
            }
        }
    }
}
