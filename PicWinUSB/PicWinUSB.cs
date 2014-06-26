using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
//using System.Threading.Tasks;         
using System.Net.Sockets;       //   Paso 1
using PicWinUSB;

namespace PicWinUSB
{

    public partial class PicWinUSB : Form
    {
      
        IntPtr iHandle;     // global device handle definition
        PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();
       
        public String wifi;

        public PicWinUSB()
        {
            
            Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid
            InitializeComponent();
            iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string s in SerialPort.GetPortNames())
                {
                    comboBox1.Items.Add(s);
                }
            Class1 frm1 = new Class1();
            if (frm1.data1 == "1")
            {
                button3.PerformClick();
            }  
            
        }

        
        private void led_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x01;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
        }

        private void led2_click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x02;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
        }

        private void led3_click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x03;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
        }

        private void led4_click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x04;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.desarrollopic.com");
        }

        private void PicWinUSB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x06;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x05;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);

        }

        private void button4_Click(object sender, EventArgs e)
        {
       
                bool bres;
                byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

                sdBuffer[0] = 0x01;    //Mode
                sdBuffer[1] = 0x02;    //Led

                bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
         
        }

        public void button3_Click(object sender, EventArgs e)
        {
          
                button3.PerformClick();
                bool bres;
                byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

                sdBuffer[0] = 0x01;    //Mode
                sdBuffer[1] = 0x01;    //Led

                bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);                      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x01;    //Mode
            sdBuffer[1] = 0x03;    //Led

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text.ToString());
        }

        private void PicWinUSB_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Puerto no válido");
                return;
            }
            comboBox1.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dato_reciv = serialPort1.ReadExisting();
            //label4.Text = dato_reciv;
            foreach (char caracterc in dato_reciv)
            {
                int n = (int)caracterc;

                if (n != 36 & n != 42 & n != 0)
                { 
                   this.listBox1.Items.Add(n); 
                }
            }

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                serialPort1.Write("g");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
                serialPort1.Write("h");
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[2];           // Define send DataBuffer size

            sdBuffer[0] = 0x00;    //Mode
            sdBuffer[1] = 0x02;    //Led
            //bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, sdBuffer);
            // IntPtr InterfaceHandle, byte PipeID, byte[] Buffer, int BufferLength, out uint LengthTransferred, IntPtr Overlapped
            this.listBox2.Items.Add( bres);          
        }

    }
}
