using System.CodeDom;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxCosto.Text, out decimal montoTotal)
                || !decimal.TryParse(textBoxDinero.Text, out decimal montoPagado))
            {
                MessageBox.Show("Por favor, ingrese montos válidos.");
                return;
            }

            decimal cambio = montoPagado - montoTotal;
            labelResultCambio.Text = "$" + cambio.ToString("0.00");

            CambioMinimo cambioMinimo = new CambioMinimo(cambio);

            listBox1.Items.Clear();
            foreach (Moneda moneda in cambioMinimo.CalcularCambioMinimo())
            {
                listBox1.Items.Add($"{moneda.Cantidad} moneda(s) de {moneda.Valor:C}");
            }
        }

        private void buttonHanoi_Click(object sender, EventArgs e)
        {
            double discos = double.Parse(textBoxHanoi.Text);
            char I = 'I'; //Poste inicial
            char A = 'A'; //Poste auxiliar
            char F = 'F'; //Poste Final
            Hanoi juego = new Hanoi();

            listBox2.Items.Clear();
            
            foreach (Movimiento movimiento in juego.CalcularMovs(discos, I, A, F))
            {
                listBox2.Items.Add($"{movimiento._mov}");
            }

            labelResultHanoi.Text = juego.pasos.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Moneda
    {
        public decimal Valor { get; set; }
        public int Cantidad { get; set; }

    }
    public class CambioMinimo
    {
        private decimal _cambio;
        private readonly List<Moneda> _demoninaciones = new List<Moneda>()
    {
        new Moneda {Valor = 100},
        new Moneda {Valor = 50 },
        new Moneda {Valor = 20},
        new Moneda {Valor  = 10},
        new Moneda {Valor = 5},
        new Moneda {Valor = 1},
        new Moneda {Valor = 0.5m},
        new Moneda {Valor = 0.2m},
        new Moneda {Valor = 0.01m}
    };

        public CambioMinimo(decimal cambio)
        {
            _cambio = cambio;
        }

        public List<Moneda>
        CalcularCambioMinimo()
        {
            List<Moneda> cantidadMonedas = new List<Moneda>();
            foreach (Moneda moneda in _demoninaciones)
            {
                int cantidad = (int)(_cambio / moneda.Valor);
                if (cantidad > 0)
                {
                    cantidadMonedas.Add(new Moneda { Valor = moneda.Valor, Cantidad = cantidad });
                    _cambio -= cantidad * moneda.Valor;
                }
            }
            return cantidadMonedas;
        }

    }
    public class Movimiento
    {
        public string _mov;
    }
    public class Hanoi
    {
        public int pasos;
        public string resultado;
        public List<Movimiento> CalcularMovs(double discos, char I, char A, char F)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            if (discos == 0)
            {
                resultado = "Sin discos";
            }
            else if (discos == 1)
            {
                string mov = I + "-->" + F;
                resultado = mov;
                movimientos.Add(new Movimiento { _mov = resultado });
                pasos++;
                
            }
            else
            {
                pasos++;
                movimientos.AddRange(CalcularMovs(discos - 1, I, F, A));
                string mov = I + "-->" + F;
                resultado = mov;
                movimientos.Add(new Movimiento { _mov = resultado });
                movimientos.AddRange(CalcularMovs(discos - 1, A, I, F));
            }
            return movimientos;
        }
    }
}