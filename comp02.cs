//The version 02 of Computer Project
using System;
namespace OOP_in_Csharp
{
  class Computer
  {
    string _BIOSname;
    private string _ipadress;
    public string _OS;
    private static int _counter = 0;
    public Computer (string bn, string ip, string os)
    {
      _BIOSname = bn;
      _ipadress = ip;
      _OS = os;   
      _counter++;
    }
    public Computer () 
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
    get { return _BIOSname;}
    set { _BIOSname = value; }
    }
    public string IPAddress
    {
    get { return _ipadress;}
    set { _ipadress = value; }
    }
  }
  class Program
  {
    static string getNum ()
    {
      Random random = new Random ();
      int num;
        num = random.Next (1, 255);
        return num.ToString ();
    }
    public static void Main (string[]args)
    {
      Computer[]net = new Computer[5];
      Computer server = new Computer();
      server.BiosName = "SERVER";
      server.IPAddress = "10.0.100.100";
      net[0] = server;
      for (int i = 1; i < net.Length; i++)
    {
      net[i] =
        new Computer ("comp" + i.ToString (),
              "10.0." + getNum () + "." + getNum (), "Win10");
    }
       
      for (int i = 0; i < net.Length; i++)
    {
      Console.WriteLine ("{0} {1}", net[i].BiosName, net[i].IPAddress);
    }
        Console.WriteLine("We have {0} computers.", Computer.getCompsNum());
    }
  }
} 