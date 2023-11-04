using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Bunifu.UI.WinForms.BunifuButton;
using System.Threading;

namespace Braço
{
    public partial class Form1 : Form
    {
        String RxString;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            KeyPreview = true;
            
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ActiveControl = null;
                switch (e.KeyCode)
                {
                    case Keys.A:
                        serialPort1.Write("A");
                        break;
                    case Keys.W:
                        serialPort1.Write("W");
                        break;
                    case Keys.S:
                        serialPort1.Write("S");
                        break;
                    case Keys.D:
                        serialPort1.Write("D");
                        break;
                    case Keys.Q:
                        serialPort1.Write("Q");
                        break;
                    case Keys.E:
                        serialPort1.Write("E");
                        break;
                    case Keys.Right:
                        this.Focus();
                        serialPort1.Write("E");
                        break;
                    case Keys.Left:
                        this.Focus();
                        serialPort1.Write("Q");
                        break;
                    case Keys.Escape:
                        ActiveControl = null;
                        break;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            atualizaListaCOMs();

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }

                if (serialPort1.IsOpen)
                {
                    button2.Text = "Desconectar";
                    comboBox1.Enabled = false;
                    label2.Text = "Digite as teclas 'W' 'A' 'S' 'D' 'Q' 'E' ";
                }

            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    button2.Text = "Conectar";
                }
                catch
                {
                    return;

                }
            }
            ActiveControl = null;
        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ActiveControl = null;
        }

        
    }
}

