using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            var old = new Stack<string>();
            old.Push("");
            var text = new StringBuilder();
            for (int i = 0; i < commands; i++)
            {
                string[] commandInput = Console.ReadLine().Split();
                int command = int.Parse(commandInput[0]);

                switch (command)
                {
                    case 1:
                        old.Push(text.ToString());
                        text.Append(commandInput[1]);
                        break;
                    case 2:
                        old.Push(text.ToString());
                        int length = int.Parse(commandInput[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        int index = int.Parse(commandInput[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(old.Pop());
                        break;
                }
            }
        }
    }
}
