# Object Oriented Programming in C# and C++

## 01. Definitions of the class Computer in subsequent versions:

### v. 03 

```
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
            num = random.Next(1, 255);
            return num.ToString();
        }
        public void StartComputer()
        {
            IPAddress =  "10.0." + getNum() + "." + getNum();
        }
    }
  ```

### v. 02 

```
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
  ```

### v. 01 

```
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
```

## 02. Data structures

### Declaration of an array of 5 elements of the type  Computer

```
Computer[]net = new Computer[5];
```

### Declaration of a list of the type Computer

```
List<Computer> net = new List<Computer>();
```


