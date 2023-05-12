using System.Security.Cryptography.X509Certificates;

namespace MessageBoxAsync
{
    public class Program
    {
        static void Main(string[] args)
        {
            MessageBox msBox = new MessageBox();

            msBox.WinClose += Message;
            msBox.Open();

            void Message(State state)
            {
                if (state == State.Cancel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" :: Operation is Canceled");
                    Console.ResetColor();

                }
                else if(state == State.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" :: Operation is OK");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("SomeError with State.Type");
                }
            }
        }
    }
}