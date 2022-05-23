//The version 01 of Computer Project
//hellooo
using System;
namespace OOP_in_Csharp
{
  public class Computer
  {
    public string _BIOSname;
    public string _ipadress;
    public string _OS;

    public Computer (string bn, string ip, string os)
    {
      _BIOSname = bn;
      _ipadress = ip;
      _OS = os;
    }
  }
///one comment
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

      Computer[]net = new Computer[4];

      for (int i = 0; i < net.Length; i++)
	{
	  net[i] =
	    new Computer ("comp" + i.ToString (),
			  "10.0." + getNum () + "." + getNum (), "Win10");
	}

      for (int i = 0; i < net.Length; i++)
	{
	  Console.WriteLine ("{0} {1}", net[i]._BIOSname, net[i]._ipadress);
	}

    }
  }
}
