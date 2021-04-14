using System;
using Raylib_cs;

namespace Racing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            //Create window
            Window.Initialize();

            
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorMain);

                Raylib.DrawText("Racing game", 10, 10, 50, Color.WHITE);

                //PICK OPTIONS ARRAY
                            string[] array = new string[]{"Play", "Quit"};

                            int x = 0;
                        //WHITEN SELECTION AND ADD ARROW
                            for (int i = 0; i < x; i++)
                            {
                                System.Console.WriteLine(array[i]);
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("--> " + array[x]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        
                        for (int i = x+1; i < array.Length; i++)
                        {
                            System.Console.WriteLine(array[i]);
                        }
                        ConsoleKeyInfo Ui = Console.ReadKey();

                        //TOGGLE BETWEEN SELECTIONS AND SELECT UPON CLICK
                            if (Ui.Key == ConsoleKey.DownArrow && x != array.Length-1|| Ui.Key == ConsoleKey.S && x != array.Length-1)
                            {
                                x++;
                            }
                            else if (Ui.Key == ConsoleKey.UpArrow && x != 0|| Ui.Key == ConsoleKey.W && x != 0)
                            {
                                x--;
                            }
                            else if (Ui.Key == ConsoleKey.Enter)
                            {
                                if (x == 0)
                                {
                                    // Game();
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }

                Raylib.EndDrawing();
            
            }

        }

        
    }
}
