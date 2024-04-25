using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Network
    {
        public static void getLocalIPAddressWithNetworkInterface(NetworkInterfaceType _type)
        {
            string localIP = "";
            
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localIP = ip.Address.ToString();
                        }

                    }
                    
                }
            }
            if (localIP != "")
            {
                Console.WriteLine($"Local IP Address = {localIP}");
            }
            else
            {
                Log.Message("Not able to find your Localadress. You're probably disconected from the LAN");
                Console.WriteLine("Not connected");
            }
        }
    }
}
