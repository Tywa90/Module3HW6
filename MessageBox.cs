using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxAsync
{
    public class MessageBox
    {
        public delegate void WinCloseHandler(State state);
        public event WinCloseHandler WinClose;

        public async void Open()
        {
            string openWindow = "Window is open";
            Console.WriteLine(openWindow);

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }


            for (int i = 0; i < 7; i++)
            {
                string closeWindow = "Window was closed by user";
                Console.Write(closeWindow);

                int choice = new Random().Next(0, 2);
                switch (choice)
                {
                    case 0:
                        WinClose(State.Cancel);
                        break;
                    case 1:
                        WinClose(State.OK);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
