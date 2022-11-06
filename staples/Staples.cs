using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staples;

public class Staples
{
    Stack<char> stapl;
    public Staples()
    {
        stapl = new Stack<char>();
    }
    public bool ReturnStaples()
    {
        Console.WriteLine("Введите скобки для проверки их закрытия");
        string select = Console.ReadLine();
        if (select == null || select == " ")
        {
            Console.WriteLine();
            Console.WriteLine("Введите корректную команду");
            Console.WriteLine();
            return false;
        }
        else
        {
            foreach (char staples in select)
            {
                if (staples == '(' || staples == '{' || staples == '[')
                {
                    stapl.Push(staples);
                }
                else if (staples == ')')
                {
                    if (stapl.Count == 0) { return false; }
                    else if (stapl.Pop() != '(') { return false; }
                }
                else if (staples == '}')
                {
                    if (stapl.Count == 0) { return false; }
                    else if (stapl.Pop() != '{') { return false; }
                }
                else if (staples == ']')
                {
                    if (stapl.Count == 0) { return false; }
                    else if (stapl.Pop() != '[') { return false; }
                }
            }
                return stapl.Count() == 0; 
        }
    }
}
