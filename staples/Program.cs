using staples;

Staples staples=new Staples();
while (true)
{
    if (staples.ReturnStaples() == false)
    {
        for (int i = 20; i >= 0; i--)
        {
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("Думаю.....");
            if (i == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Неправильно, попробуй ещё раз(False)");
                Console.WriteLine();
            }
        }
    }
    else 
    {
        for (int i = 20; i >= 0; i--)
        {
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("Думаю.....");
            if (i == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Так уж и быть, правильно(True)");
                Console.WriteLine();
            }
        }
    }
}