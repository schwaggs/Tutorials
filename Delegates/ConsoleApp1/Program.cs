using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateTest delTest = new DelegateTest(DelegateMethods.DisplayMessage, null, "test");
            DelegateTest delTest2 = new DelegateTest(null ,DelegateMethods.DisplayMessage, "test", "\n\n");

            delTest.DisplayMessage("new test");
        }
    }

    public class DelegateTest
    {
        public delegate void Message(string message);
        public delegate void MessagePlusEnding(string message, string ending);
        private Message MessageDel { get; set; }
        private MessagePlusEnding MessagePlusEndingDel { get; set; }

        public DelegateTest(Message _MessageDel = null, MessagePlusEnding _MessagePlusEndingDel = null, string message = "", string ending = "")
        {
            if(_MessageDel != null)
            {
                MessageDel = _MessageDel;
            }

            if(_MessagePlusEndingDel != null)
            {
                MessagePlusEndingDel = _MessagePlusEndingDel;
            }

            DisplayMessage(message, ending);
        }

        public void DisplayMessage(string message, string ending = "")
        {
            if (ending == "")
                MessageDel(message);
            else
                MessagePlusEndingDel(message, ending);
        }
    }

    public static class DelegateMethods
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message + "\n\n");
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }

        public static void DisplayMessage(string message, string ending)
        {
            Console.WriteLine(message + ending);
            Console.WriteLine("Press ENTER to quit 2");
            Console.ReadLine();
        }
    }
}
