using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnExercicioA.Click += btnExercicioA_Click;
            btnExercicioB.Click += btnExercicioB_Click;
            btnExercicioC.Click += btnExercicioC_Click;
            btnExercicioD.Click += btnExercicioD_Click;
            btnExercicioE.Click += btnExercicioE_Click;
        }

        private void btnExercicioA_Click(object sender, EventArgs e)
        {
            lblEnunciado.Text =
                "Apresentar todos os numeros inteiros impares de 0 a 40.";

            ExercicioA();
        }

        private void btnExercicioB_Click(object sender, EventArgs e)
        {
            lblEnunciado.Text =
                "Apresentar a soma dos 100 primeiros numeros inteiros.";

            ExercicioB();
        }

        private void btnExercicioC_Click(object sender, EventArgs e)
        {
            lblEnunciado.Text =
                "Apresentar todos os números divisíveis por 4 que sejam menores que 40.";

            ExercicioC();
        }

        private void btnExercicioD_Click(object sender, EventArgs e)
        {
            lblEnunciado.Text =
                "Apresentar os quadrados dos números de 15 a 200.";

            ExercicioD();
        }

        private void btnExercicioE_Click(object sender, EventArgs e)
        {
            lblEnunciado.Text =
                "Apresentar a soma dos números pares de 1 a 50.";

            ExercicioE();
        }

        // Exercicio A - Numeros impares de 0 a 40
        private void ExercicioA()
        {
            txtResultado.Clear();

            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 != 0)
                {
                    txtResultado.AppendText(
                        i + Environment.NewLine
                    );
                }
            }
        }

        // Exercicio B - Soma dos numeros de 1 a 100
        private void ExercicioB()
        {
            txtResultado.Clear();

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            txtResultado.Text = "Resultado da soma: " + soma;
        }

        // Exercicio C - Divisiveis por 4 menores que 40
        private void ExercicioC()
        {
            txtResultado.Clear();

            for (int i = 1; i < 40; i++)
            {
                if (i % 4 == 0)
                {
                    txtResultado.AppendText(
                        i + Environment.NewLine
                    );
                }
            }
        }

        // Exercicio D - Quadrados de 15 a 200
        private void ExercicioD()
        {
            txtResultado.Clear();

            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;

                txtResultado.AppendText(
                    i + " ao quadrado = " + quadrado
                    + Environment.NewLine
                );
            }
        }

        // Exercicio E - Soma dos pares de 1 a 50
        private void ExercicioE()
        {
            txtResultado.Clear();

            int soma = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }

            txtResultado.Text =
                "Soma dos numeros pares: " + soma;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}