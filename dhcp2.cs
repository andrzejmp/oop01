//dhcp2
//experiments with generating unique elements of the List

using System;
using System.Collections.Generic;

class HelloWorld {
    
  public static string getNum()
{
    Random random = new Random();
    int num;
    num = random.Next(1, 255);
    return num.ToString();
}    



public static void addresses(List<string> ips2)
{
     const int N = 4;
     int count = 0;
     string piece = "";
     
     while(count < 4) 
     {
        piece = getNum();
        if(ips2.Contains(piece) == false)
        {
            ips2.Add(piece);
            count++;
        }
     }

}
    
  static void Main() {
     
     List<string> ips2 = new List<string>();
     addresses(ips2);    
    
     int last;
     Console.WriteLine("-------------");
     foreach(string s in ips2)
     {
         //Console.WriteLine(s);
         //Console.WriteLine(ips2.RemoveAt(ips2.Count()-1);
              
         
     }
   
      Console.WriteLine(ips2.Count);
      last = ips2.Count - 1;
      Console.WriteLine(ips2[last]);
      ips2.RemoveAt(last);
      
      Console.WriteLine(ips2.Count);
      last = ips2.Count - 1;
      Console.WriteLine(ips2[last]);
      ips2.RemoveAt(last);
      
      Console.WriteLine(ips2.Count);
      last = ips2.Count - 1;
      Console.WriteLine(ips2[last]);
      ips2.RemoveAt(last);
     
  }
}





