//The version 04 of Computer Project
using System;
using System.Collections.Generic;

namespace OOP_in_Csharp
{
    class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private static int _counter = 0;
        public Computer(string bn, string ip, string os)
        {
            this._BIOSname = bn;
            this._ipadress = ip;
            this._OS = os;

            _counter++;
        }
        public Computer()
        {
            _counter++;
        }
        public static int getCompsNum()
        {
            return _counter;
        }
        //proprties
        public string BiosName
        {
            get { return this._BIOSname; }
            set { this._BIOSname = value; }
        }
        public string IPAddress
        {
            get { return this._ipadress; }
            set { this._ipadress = value; }
        }

        public string OS
        {
            get { return this._OS; }
            set { this._OS = value; }
        }

        public static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(2, 255);
            return num.ToString();
        }
        public void StartComputer()
        {
            IPAddress =  "10.0." + getNum() + "." + getNum();
        }

        public void addresses(List<string> ips2, int N)
        {
            int count = 0;
            string piece = "";
            
            while(count < N) 
            {
                piece = getNum();
                if(ips2.Contains(piece) == false)
                {
                    ips2.Add(piece);
                    count++;
                }
            }
        }


    }
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
            Computer server = new Computer();
            server.BiosName = "DHCP";
            server.IPAddress = "10.0.100.1";
            server.OS = "Linux"; 

            const int numComps = 5;

            List<string> ips2 = new List<string>();
            server.addresses(ips2,numComps-1 );
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
                last = ips2.Count - 1;
                piece = ips2[last];
                net[i].IPAddress =  "10.0.100"  + "." + piece;
                ips2.RemoveAt(last);
                Console.WriteLine("{0} {1}", net[i].BiosName, net[i].IPAddress);
            }

            //removinig comps
            Console.WriteLine("------------");

            //ShutDownComp(net, "comp1");
            //ShutDownComp(net, "comp3");

            foreach (Computer comp in net)
            {
                Console.WriteLine("{0} {1}", comp.BiosName, comp.IPAddress);
            }
            Console.WriteLine("\nWe have {0} computers.", Computer.getCompsNum());
        }
    }
}
/*

Device 
Fields:
            id
Methods:   
            StartDevice
            ShutDownDevice
--------------------------
Computer:
        fields
            private string _BIOSname;
            private string _ipadress;
            private string _OS;
            private static int _counter = 0;

        methods inhereted
            StartDevice
            ShutDownDevice
Server:
        generate IP adresses


