using System;
using System.Net;
using System.Net.Sockets;

public class Program
{
    static void Main()
    {
        // Configurations
        string plcIP = "127.0.0.1";
        int plcPort = 502;  // Modbus TCP/IP Port (PLC)

        // Check simulator running
        bool simulatorRunning = ScanSimulatorCLP(plcIP, plcPort);

        if (simulatorRunning)
        {
            Console.WriteLine("Simulador its running...");
        }
        else
        {
            Console.WriteLine("Simulator its not running...");
        }
    }

    // Função para realizar o scan do simulador do CLP Schneider M221
    static bool ScanSimulatorCLP(string ip, int port)
    {
        try
        {
            // Criação do objeto TCPClient para a conexão com o simulador
            TcpClient client = new TcpClient();
            client.Connect(ip, port);

            // Verifica se a conexão foi estabelecida
            if (client.Connected)
            {
                // Fecha a conexão
                client.Close();
                return true;
            }
        }
        catch (SocketException)
        {
            Console.WriteLine("Erro de socket");
        }

        return false;
    }
}
