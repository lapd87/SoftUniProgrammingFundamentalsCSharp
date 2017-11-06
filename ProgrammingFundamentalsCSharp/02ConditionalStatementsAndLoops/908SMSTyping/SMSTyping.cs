using System;

class SMSTyping
{
    static void Main()
    {
        int characters = int.Parse(Console.ReadLine());

        string sms = "";

        for (int i = 1; i <= characters; i++)
        {
            int symbol = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case 0: sms += " "; break;

                case 2: sms += "a"; break;
                case 22: sms += "b"; break;
                case 222: sms += "c"; break;

                case 3: sms += "d"; break;
                case 33: sms += "e"; break;
                case 333: sms += "f"; break;

                case 4: sms += "g"; break;
                case 44: sms += "h"; break;
                case 444: sms += "i"; break;

                case 5: sms += "j"; break;
                case 55: sms += "k"; break;
                case 555: sms += "l"; break;

                case 6: sms += "m"; break;
                case 66: sms += "n"; break;
                case 666: sms += "o"; break;

                case 7: sms += "p"; break;
                case 77: sms += "q"; break;
                case 777: sms += "r"; break;
                case 7777: sms += "s"; break;

                case 8: sms += "t"; break;
                case 88: sms += "u"; break;
                case 888: sms += "v"; break;

                case 9: sms += "w"; break;
                case 99: sms += "x"; break;
                case 999: sms += "y"; break;
                case 9999: sms += "z"; break;
            }
        }

        Console.WriteLine(sms);
    }
}
