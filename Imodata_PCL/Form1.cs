using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPD;

namespace Imodata_PCL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Arquivo = new OpenFileDialog();

            {
                var withBlock = Arquivo;
                // .DefaultExt = ".txt"
                withBlock.Multiselect = false;

                // .Filter = "Arquivos de Texto (*.txt)|*.txt"
                withBlock.Title = "Selecione um Arquivo...";
                withBlock.ShowDialog();
            }

            textBox1.Text = Arquivo.FileName;

        }


        string impressora, fila;

        private void enviarFormsPCLImodataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Impressoras
            //RICOH 1107 - 1
            //RICOH 1107 - 2
            //RICOH 1357EX
            //RICOH 907EX
            //RICOH 9100


            //  string textocombo = comboBox1.Text;


            switch (comboBox1.Text)
            {
                case "RICOH 1107-1":
                    impressora = "10.0.0.205";
                    fila = "";
                    break;

                case "RICOH 1107-2":
                    impressora = "10.0.0.206";
                    fila = "";
                    break;

                case "RICOH 1357EX":
                    impressora = "10.0.0.207";
                    fila = "Pro1357EX";
                    break;

                case "RICOH 907EX":
                    impressora = "10.0.0.208";
                    fila = "Pro907EX";
                    break;

                case "RICOH 9100":
                    impressora = "10.0.0.210";
                    fila = "";
                    break;

                default:
                    MessageBox.Show("Selecione uma Impressora");
                    break;
            }

            //Printer printer1 = new Printer("10.0.0.208", "Pro907EX", "");
            Printer printer1 = new Printer(impressora, fila, "");

            string pastaResourde = @"\\10.0.0.100\DADOS\DADOS DE PROGRAMAS\RESOURCE IMODATA\";

            //Envio de arquivos PCL da IMODATA
            string arquivo = textBox1.Text;

            try
            {
                printer1.LPR(pastaResourde + "form03.pcl", false);
                printer1.LPR(pastaResourde + "form04.pcl", false);
                printer1.LPR(pastaResourde + "form05.pcl", false);
                printer1.LPR(pastaResourde + "form06.pcl", false);
                printer1.LPR(pastaResourde + "form07.pcl", false);
                printer1.LPR(pastaResourde + "form08.pcl", false);
                printer1.LPR(pastaResourde + "form09.pcl", false);
                printer1.LPR(pastaResourde + "form10.pcl", false);
                printer1.LPR(pastaResourde + "form11.pcl", false);
                printer1.LPR(pastaResourde + "form12.pcl", false);
                printer1.LPR(pastaResourde + "form13.pcl", false);
                printer1.LPR(pastaResourde + "form14.pcl", false);
                printer1.LPR(pastaResourde + "form15.pcl", false);
                printer1.LPR(pastaResourde + "form16.pcl", false);
                printer1.LPR(pastaResourde + "form17.pcl", false);
                printer1.LPR(pastaResourde + "form18.pcl", false);
                printer1.LPR(pastaResourde + "form19.pcl", false);
                printer1.LPR(pastaResourde + "form20.pcl", false);
                printer1.LPR(pastaResourde + "form21.pcl", false);
                printer1.LPR(pastaResourde + "form22.pcl", false);
                printer1.LPR(pastaResourde + "form23.pcl", false);
                printer1.LPR(pastaResourde + "form25.pcl", false);
                printer1.LPR(pastaResourde + "form26.pcl", false);
                printer1.LPR(pastaResourde + "form27.pcl", false);
                printer1.LPR(pastaResourde + "form30.pcl", false);
                printer1.LPR(pastaResourde + "form35.pcl", false);
                printer1.LPR(pastaResourde + "form39.pcl", false);
                printer1.LPR(pastaResourde + "form49.pcl", false);
                printer1.LPR(pastaResourde + "form55.pcl", false);
                printer1.LPR(pastaResourde + "form75.pcl", false);
                printer1.LPR(pastaResourde + "form76.pcl", false);
                printer1.LPR(pastaResourde + "form78.pcl", false);
                printer1.LPR(pastaResourde + "form79.pcl", false);
                printer1.LPR(pastaResourde + "form80.pcl", false);
                printer1.LPR(pastaResourde + "form81.pcl", false);
                printer1.LPR(pastaResourde + "form88.pcl", false);
                printer1.LPR(pastaResourde + "form89.pcl", false);
                printer1.LPR(pastaResourde + "form90.pcl", false);
                printer1.LPR(pastaResourde + "form91.pcl", false);
                printer1.LPR(pastaResourde + "form92.pcl", false);

                printer1.LPR(pastaResourde + "i2501p.n32", false);
                printer1.LPR(pastaResourde + "logodata.n32", false);

               }
            catch
            {

                MessageBox.Show("Erro ao encontrar a impressora");

            }
            finally
            {

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
                        
            //Impressoras
            //RICOH 1107 - 1
            //RICOH 1107 - 2
            //RICOH 1357EX
            //RICOH 907EX
            //RICOH 9100
            //  string textocombo = comboBox1.Text;

            switch (comboBox1.Text)
            {
                case "RICOH 1107-1":
                    impressora="10.0.0.205";
                    fila = "";
                    break;

                case "RICOH 1107-2":
                    impressora = "10.0.0.206";
                    fila = "";
                    break;

                case "RICOH 1357EX":
                    impressora = "10.0.0.207";
                    fila = "Pro1357EX";
                    break;

                case "RICOH 907EX":
                    impressora = "10.0.0.208";
                    fila = "Pro907EX";
                    break;

                case "RICOH 9100":
                    impressora = "10.0.0.210";
                    fila = "";
                    break;

                case "PDF FILES":
                    impressora = "PORTPROMPT:";
                    fila = "";
                    break;
               
                default:
                    MessageBox.Show("Selecione uma Impressora");
                    break;
            }

            //Printer printer1 = new Printer("10.0.0.208", "Pro907EX", "");
            Printer printer1 = new Printer(impressora, fila, "");

            string pastaResourde = @"\\10.0.0.100\DADOS\DADOS DE PROGRAMAS\RESOURCE IMODATA\";

            //Envio de arquivos PCL da IMODATA

            string arquivo = textBox1.Text;

            try
            {
             
                //printer1.LPR(pastaResourde + "i2501p.n32", false);
                //printer1.LPR(pastaResourde + "logodata.n32", false);
                //ARQUIVO PRINCIPAL
                printer1.LPR(textBox1.Text, false);


            }
            catch{

                MessageBox.Show("Erro ao encontrar a impressora");

            }
            finally {

            }



        }
    }
}
