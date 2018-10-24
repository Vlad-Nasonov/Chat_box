using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using LumiSoft.Net.STUN.Client;

namespace Stun_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //инициация подключения к сstun серверу, ради всех богов не трогать
        private void button1_Click(object sender, EventArgs e)
        {
            //объявляем сокет
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 0));
            //кидаем запрос серверу, получаем в ответ новый адрес и порт, при этом занимаем свой порт, считывая данные
            STUN_Result result = STUN_Client.Query(Stun_serv_adr.Text, 3478, socket);
            //прост зрительно выводим информацию о типе нат и прочей лобуде
            Net_Type.Text = result.NetType.ToString();
            new_Local_output.Text = socket.LocalEndPoint.ToString();
            if (result.NetType != STUN_NetType.UdpBlocked)
            {
                new_local_input.Text = result.PublicEndPoint.ToString();
            }
            else
            {
                new_local_input.Text = "";
            }
        }
        //Вот отсюда можно, желательно бы разбить это по классам отдыльным и накидать ссылок для удобства, ибо ну пиздец всего тут много
        private static IPAddress remoteIPAddress;
        private static int remotePort;
        private static int localPort;
        private void button2_Click(object sender, EventArgs e)
        {  
             try
            {
                // Получаем данные, необходимые для соединения
                chat_box.Text = "Укажите локальный порт";
                localPort = Convert.ToInt32(local_port_log.Text);

                chat_box.Text = chat_box.Text += ("Укажите удаленный порт");
                remotePort = Convert.ToInt32(srv_port_log.Text);

                chat_box.Text = chat_box.Text += "Укажите удаленный IP-адрес";
                remoteIPAddress = IPAddress.Parse(srv_ip_log.Text);
            
                // Создаем поток для прослушивания
                Thread tRec = new Thread(new ThreadStart(Receiver));
                tRec.Start();
                /*
                    while (true)
                {
                 Send(Console.ReadLine());
                } */
             }
            catch
            {
                chat_box.Text = "Проверьте введённые данные";
            }


        }


        private static void Send(string datagram)
        {
            // Создаем UdpClient
            UdpClient sender = new UdpClient();

            // Создаем endPoint по информации об удаленном хосте
            IPEndPoint endPoint = new IPEndPoint(remoteIPAddress, remotePort);

            try
            {
                // Преобразуем данные в массив байтов
                byte[] bytes = Encoding.UTF8.GetBytes(datagram);

                // Отправляем данные
                sender.Send(bytes, bytes.Length, endPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
            finally
            {
                // Закрыть соединение
                sender.Close();
            }
        }

       public static void Receiver()
        {
            // Создаем UdpClient для чтения входящих данных
            UdpClient receivingUdpClient = new UdpClient(localPort);

            IPEndPoint RemoteIpEndPoint = null;

            try
            {
                Console.WriteLine(
                   "\n-----------*******Общий чат*******-----------");

                while (true)
                {
                    // Ожидание дейтаграммы
                    byte[] receiveBytes = receivingUdpClient.Receive(
                       ref RemoteIpEndPoint);

                    // Преобразуем и отображаем данные
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    Console.WriteLine(" --> " + returnData.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
        }

    }
}

      
