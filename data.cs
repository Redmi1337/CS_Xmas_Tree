using System.Drawing;
using Microsoft.VisualBasic;

namespace Data
{
    public class data
    {
        static public char[,] tree = new char[,]
        {
            {' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*','*','*',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ','*','*','*','*','*',' ',' ',' ',' '},
            {' ',' ',' ','*','*','*','*','*','*','*',' ',' ',' '},
            {' ',' ','*','*','*','*','*','*','*','*','*',' ',' '},
            {' ','*','*','*','*','*','*','*','*','*','*','*',' '},
            {'*','*','*','*','*','*','*','*','*','*','*','*','*'},
            {' ',' ',' ',' ',' ','|','|','|',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','|','|','|',' ',' ',' ',' ',' '}
        };
        static public string[] text = new string[]{
            "A face on a lover",
            "With a fire in his heart",
            "A man under cover",
            "But you tore me apart",
            "Ooh ooh",
            "Now I've found a real love",
            "You'll never fool me again"
        };
        static public void pickColor(int color)
        {
            switch (color)  // выбор цвета для гирлянды
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }
    }
}