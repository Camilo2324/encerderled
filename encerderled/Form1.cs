using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encerderled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArduinoPort =  new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM7";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.btnApagar.Click += btnApagar_Click;
            this.btnEncender.Click += btnEncender_Click;


        }

        public SerialPort ArduinoPort { get; }


        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void CerrarForm1(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

























        private void cerrarform_Click(object sender, EventArgs e)
        {
           
        }
    }
}
