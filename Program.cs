using System;
using System.Threading;
using Data;
using Microsoft.VisualBasic;

namespace project3
{
    class Program
    {

        static public Random random = new Random();
        public static int number;
        public static int textColor_cell;
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            Console.Clear();
            Thread treeThread = new Thread(MainLoop);
            Thread textThread = new Thread(TextDraw);
            treeThread.Start();
            textThread.Start();
        }
        static void MainLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                TreeDraw();
                Thread.Sleep(1500);
            }
        }
        static void TreeDraw() //вывод ёлки при помощи foreach и окрашивание некоторых элементов в цвета
        {
            for (int i = 0; i < data.tree.GetLength(0); i++)
            {
                Console.SetCursorPosition(0, i);
                for (int x = 0; x < data.tree.GetLength(1); x++)
                {
                    number = random.Next(0, 11);
                    if (number > 5 && i < data.tree.GetLength(0) - 2)
                    {
                        textColor_cell = random.Next(1, 13);
                        data.pickColor(textColor_cell);
                    }
                    Console.Write(data.tree[i, x]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static void TextDraw() //вывод текста
        {
            Thread.Sleep(10);
            for (int i = 0; i < data.text.Length; i++)
            {
                char[] textArray = data.text[i].ToCharArray();
                Console.SetCursorPosition(data.tree.GetLength(0) + 14, i);
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (char letter in textArray)
                {
                    Console.Write(letter);
                    Thread.Sleep(20);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
