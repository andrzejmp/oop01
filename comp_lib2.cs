//The version 09 of Computer Project
using System;
using System.Collections.Generic;

//namespace OOP_in_Csharp
namespace compLibs
{

    public class Computer
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

        public virtual void StartComputer(string addr1, string addr2)
        {
            IPAddress =  addr1 + addr2;
        }

        public void addresses(List<string> dhcpAddresses, int N)
        {
            int count = 0;
            string piece = "";
            
            while(count < N) 
            {
                piece = getNum();
                if(dhcpAddresses.Contains(piece) == false)
                {
                    dhcpAddresses.Add(piece);
                    count++;
                }
            }
        }


    } //end Computer

    public class Server : Computer 
    {
        
        public Server(string bn, string ip, string os, string type) : base(bn, ip, os)
        {
            this.Type = type;
        }

        public Server() { }
       
        protected string type;
        public string Type
		{
			get { return type;  }
			set { type = value; }
		}

        public override void StartComputer(string addr1, string addr2)
        {
            IPAddress =  addr1 + "10";
        }
        
    }

    
}
