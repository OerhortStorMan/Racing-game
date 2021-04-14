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

            int picker = 0;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorMain);

                Raylib.DrawText("Racing game", 10, 10, 50, Color.WHITE);

                //PICK OPTIONS ARRAY
                string[] array = new string[] { "Play", /*"Options",*/ "Quit" };

                int playTextY = 70;
                Raylib.DrawText(array[0], 120, playTextY, 50, Color.WHITE);

                int exitTextY = 150;
                Raylib.DrawText(array[1], 120, exitTextY, 50, Color.WHITE);

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                {
                    picker++;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    picker--;
                }

                //Lets player shift between play and exit, also allowing picker to loop around selections
                if (picker == 0 || picker == 2)
                {
                    picker = 0;
                    Raylib.DrawText("-->", 30, playTextY, 50, Color.WHITE);
                }
                else if (picker == 1 || picker == -1)
                {
                    picker = 1;
                    Raylib.DrawText("-->", 30, exitTextY, 50, Color.WHITE);
                }

                if (picker == 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    Raylib.CloseWindow();
                    Game();
                }

                Raylib.EndDrawing();
            }
        }

        static void Game()
        {
            Window.Initialize();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorGame);

                Raylib.EndDrawing();
            }
        }
    }
}

// double GetTime(void);   // Returns elapsed time in seconds since InitWindow()

