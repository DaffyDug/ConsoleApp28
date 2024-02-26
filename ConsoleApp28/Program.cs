using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string stringtext = "";
        InputText inputText = new InputText(stringtext);
        StringBuilder stringBuilder = new StringBuilder();
        while (true)
        {
            Console.WriteLine("1. введение текста");
            Console.WriteLine("2. вывод на экран");
            Console.WriteLine("3. очистить весь экран");
            Console.WriteLine("4. замена строк");
            Console.WriteLine("5. очистить экран");
            string intvalue = Console.ReadLine();
            if (intvalue == "1")
            {
                string txt = inputText.inputtext(stringtext);
                while (true)
                {
                    Console.WriteLine("1. Write");
                    Console.WriteLine("2. WriteLine");
                    string intvalue2 = Console.ReadLine();
                    if (intvalue2 == "1" || intvalue2 == "2")
                    {
                        if (intvalue2 == "1")
                        {
                            stringBuilder.Append(txt);
                        }
                        if (intvalue2 == "2")
                        {
                            stringBuilder.Append("\n" + txt);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ошибка");
                    }
                }
            }
            if (intvalue == "2")
            {
                if (stringBuilder.Length > 0)
                {
                    inputText.outputtext(stringBuilder);
                }
                else
                {
                    Console.WriteLine("ошибка");
                }
            }
        }
    }
}
class InputText
{
    private string _text;
    public InputText(string text)
    {
        _text = text;
    }
    public string inputtext(string txt)
    {
        Console.Write("введиет текст: ");
        txt = Console.ReadLine();
        return txt;
    }
    public void outputtext(StringBuilder stringBuilder)
    {
        Console.WriteLine(stringBuilder);
    }
}