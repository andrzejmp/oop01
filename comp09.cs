//The version 08 of Computer Project
using System;
using System.Collections.Generic;
using compLibs; //OOP_in_Csharp;

    class Program
    {
        static void ShutDownComp(List<Computer> network, string compName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i].BiosName == compName)
                {
                    //Console.WriteLine(i);
                    network.RemoveAt(i);
                }
            }
        }

        public static void Main(string[] args)
        {
            List<Computer> net = new List<Computer>();
            Server server = new Server();
            server.BiosName = "DHCP";
            server.IPAddress = "10.0.100.1";
            server.OS = "Linux"; 

            const int numComps = 9;

            List<string> dhcpAddresses = new List<string>();
            server.addresses(dhcpAddresses,numComps-1 );
            net.Add(server);

            for (int i = 1; i < numComps; i++)
            {
                Computer comp =
                  new Computer("comp" + i.ToString(), "", "Win10");
                net.Add(comp);
            }

            int last;
            string piece;
            for (int i = 1; i < net.Count; i++)
            {
                last = dhcpAddresses.Count - 1;
                piece = dhcpAddresses[last];
                net[i].StartComputer("10.0.100.", piece);
                dhcpAddresses.RemoveAt(last);
                Console.WriteLine("{0} {1}", net[i].BiosName, net[i].IPAddress);
            }

            //removinig comps
            Console.WriteLine("------------");
            ShutDownComp(net, "comp1");
            ShutDownComp(net, "comp3");
            ShutDownComp(net, "comp6");

            foreach (Computer comp in net)
            {
                Console.WriteLine("{0} {1}", comp.BiosName, comp.IPAddress);
            }
            Console.WriteLine("\nWe have {0} computers.", Computer.getCompsNum());
        }
    }

