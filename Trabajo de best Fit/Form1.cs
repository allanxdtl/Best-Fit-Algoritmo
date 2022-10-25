using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace Trabajo_de_best_Fit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Contador para asignar numero a los procesos
        static int cont = 0;
        //Contador para mantener control de los procesos activos en la memoria
        public int Espacios = 0;

        //Arreglo donde se almacenan los espacios de memoria segmentados
        int[] tamaniosMemoria =
        {
            30,
            20,
            45,
            35,
            10
        };

        //Con este se lleva el control de que espacio esta ocupado y cual no
        bool[] espaciosOcupados =
        {
            false,
            false,
            false,
            false,
            false
        };

        //Se instancian tres procesos iniciales y se acomodan los espacios de memoria en
        //los list box
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Array.Sort(tamaniosMemoria);
            ClsProceso proceso1 = new ClsProceso();
            ClsProceso proceso2 = new ClsProceso();
            ClsProceso proceso3 = new ClsProceso();
            listBox1.Items.Add($"Proceso Ej: {proceso1.Tamanio} kb");
            listBox1.Items.Add($"Proceso EJ: {proceso2.Tamanio} kb");
            listBox1.Items.Add($"Proceso Ej: {proceso3.Tamanio} kb");
            listBox2.Items.Clear();
            for (int i = 0; i < tamaniosMemoria.Length; i++)
            {
                listBox2.Items.Add($"{tamaniosMemoria[i]} kb free");
            }


        }

        //Con el timer hacemos que cada 3 seg se asigne un proceso a la memoria
        //mediante el algoritmo de best fit
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Si el contador de espacios es igual a 3 se liberara un espacio
            if (Espacios == 3)
            {
                for (int i = 0; i < espaciosOcupados.Length; i++)
                {
                    if (espaciosOcupados[i])
                    {
                        espaciosOcupados[i] = false;
                        listBox2.Items[i] = $"{tamaniosMemoria[i]} kb free";
                        Espacios--;
                        break;
                    }
                }
            }
            listBox1.Items.RemoveAt(0);
            ClsProceso procesoN = new ClsProceso();
            cont++;
            listBox1.Items.Add($"Proceso {cont}: "+procesoN.Tamanio+ " kb");
            InsertarProceso(procesoN);
        }

        //Con este metodo hacemos la asignacion de memoria
        public void InsertarProceso(ClsProceso proceso)
        {
            int espacio=45;
            int indice=0;
            for (int i = 0; i< tamaniosMemoria.Length; i++)
            {
                if (proceso.Tamanio <= tamaniosMemoria[i])
                {
                    if (espacio >= tamaniosMemoria[i] && espaciosOcupados[i]==false)
                    {
                        espacio = tamaniosMemoria[i];
                        indice = i;
                    }
                }
            }
            espaciosOcupados[indice] = true;
            Espacios++;
            listBox2.Items[indice] = $"Bloque ocupado, sobran {espacio-proceso.Tamanio}";
            IndiceLabel(indice);
        }

        //Pausa del algoritmo
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //En este metodo asignamos de etiqueta a la memoria que proceso esta ocupando el segmento de memoria
        public void IndiceLabel(int indice)
        {
            switch (indice)
            {
                case 0:
                    lblEspacio1.Text = $"Proceso {cont}";
                    break;
                case 1:
                    lblEspacio2.Text = $"Proceso {cont}";
                    break;
                case 2:
                    lblEspacio3.Text = $"Proceso {cont}";
                    break;
                case 3:

                    lblEspacio4.Text = $"Proceso {cont}";
                    break;
                case 4:
                    lblEspacio5.Text = $"Proceso {cont}";
                    break;
            }
        }

        //Resumen del algoritmo
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Comentario
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                timer1.Interval = Convert.ToInt16(textBox1.Text) * 1000;
            }
            else
            {
                MessageBox.Show("No deje el campo vacio");
            }
        }
    }
}