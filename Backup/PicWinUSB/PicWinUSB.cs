////////////////////////////////////////////////////////////////////////////
//// Web: www.desarrollopic.com                                         ////
////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PicWinUSB
{
    public partial class PicWinUSB : Form
    {
        IntPtr iHandle;     // global device handle definition

        PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();
        
        public PicWinUSB()
        {
            Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid
                        
            InitializeComponent();
            iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);
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
    }
}
