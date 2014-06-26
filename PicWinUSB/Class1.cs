using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using System.Threading.Tasks;
using System.Net;               //   Paso 1
using System.Net.Sockets;       //   Paso 1
using System.IO;


using System.Diagnostics;

using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using PicWinUSB;


namespace PicWinUSB
{
    class Class1
    {
        IntPtr iHandle;
        public static String wifi1;
        public String data1="";

        public static void Conectar()
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // paso 2 - creamos el socket
            
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Any, 11000);
            
            //paso 3 -IPAddress.Any significa que va a escuchar al cliente en toda la red 
            try
            {
                // paso 4
                miPrimerSocket.Bind(miDireccion); // Asociamos el socket a miDireccion
                miPrimerSocket.Listen(1); // Lo ponemos a escucha

                Console.WriteLine("Escuchando...");
                //Socket handler = socket.Accept();
                Socket Escuchar = miPrimerSocket.Accept();
               
                //creamos el nuevo socket, para comenzar a trabajar con él
                //La aplicación queda en reposo hasta que el socket se conecte a el cliente
                //Una vez conectado, la aplicación sigue su camino  
                Console.WriteLine("Conectado con exito");
                
                /*Aca ponemos todo lo que queramos hacer con el socket, osea antes de 
                cerrarlo je*/
                ///////////////////////////////////////////////////////
                PicWinUSB frm = new PicWinUSB();
                frm.Show();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                /////////////////////////////////////////////////////////////
                byte[] bytes = new byte[1024]; //Declaramos un array de bytes de longitud 1024
                int count;
                String data = ""; //Declaramos data, que sera donde se almacenaran los datos

                do //Bucle Do/While
                {
                    count = Escuchar.Receive(bytes); //Recibimos los datos enviados y lo guardamos en cout.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, count); //Lo codificamos a cadena (ya que se envian como bytes)
                    String data1 = System.Text.Encoding.ASCII.GetString(bytes, 0, count);
                    ////////////////////////////////////////////////////////
                    wifi1 = data;
                    if (data == "a")
                    {
                        PicWinUSB frm2 = new PicWinUSB();
                        frm2.button3.PerformClick(); //button3_Click
                                 
                    }
                    if (data == "b")
                    {
                        PicWinUSB frm2 = new PicWinUSB();
                        frm2.button4.PerformClick();
                    }
                    if (data == "1")
                    {
                        PicWinUSB frm2 = new PicWinUSB();
                        frm2.button7.PerformClick();
                    }
                    if (data == "2")
                    {
                        PicWinUSB frm2 = new PicWinUSB();
                        frm2.button10.PerformClick();
                    }
                    ///////////////////////////////////////////////////////
                    if (data != "exitn") //Mientras lo recibido no sea exit + n (es decir, exit + Intro, ya que intro tambien se envia)
                    {
                        Console.Write("Se a recibido: {0}", data); //Mostramos lo recibido pro pantalla
                                              
                    }
                    
                    

                } while (data != "exitn"); //Mientras lo recibido no sea exit + Intro se continua el bucle, si recibimos exit + intro, salimos del bucle
                //while (true) ; 
                Console.WriteLine("Se ha finalizado la conexión"); //Avisamos qde que se a terminado la transferencia de datos
               
                miPrimerSocket.Close(); //Luego lo cerramos
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();

        }
    }
}
