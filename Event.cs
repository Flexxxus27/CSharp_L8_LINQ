using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L8
{
    public class Event
    {
        public delegate void MyDelegate(string msg);
        public event MyDelegate onMsg;

        public static void HandleMes(string msg) { Console.WriteLine(msg); }
        public void TakeMsg(string msg)
        {
            onMsg.Invoke(msg);
        }
    }
}
