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

                Raylib.DrawText(@"
Contol scheme:
    Menu:
        W - Move up
        S - Move down
        E - Select
        ESC - Exit game

    In-game:
        W - Accelerate
        S - Reverse
        A - Turn left
        D - Turn Right
        SPACE - BREAK (!)

        ESC - Return to menu
                ", 500, 10, 20, Color.WHITE);

                //PICK OPTIONS ARRAY
                string[] array = new string[] { "Play", /*"Options",*/ "Quit" };

                int playTextY = 70;
                Raylib.DrawText(array[0], 100, playTextY, 50, Color.WHITE);

                int exitTextY = 150;
                Raylib.DrawText(array[1], 100, exitTextY, 50, Color.WHITE);

                

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                {
                    picker++;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    picker--;
                }

                //Lets player shift between play and exit, while also allowing picker to loop around selections
                if (picker == 0 || picker == 2)
                {
                    picker = 0;
                    Raylib.DrawText("-->", 10, playTextY, 50, Color.WHITE);
                }
                else if (picker == 1 || picker == -1)
                {
                    picker = 1;
                    Raylib.DrawText("-->", 10, exitTextY, 50, Color.WHITE);
                }

                if (picker == 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    Raylib.CloseWindow();
                    Game();
                }
                else if (picker == 1 && Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    Raylib.CloseWindow();
                    Environment.Exit(0);
                }

                Raylib.EndDrawing();
            }
        }

        static void Game()
        {
            Window.Initialize();

            CarOne carOne = new CarOne(100, 100);
           /*CAR ONE HERE!!! CHANGE TO TWO*/ CarOne carTwo = new CarOne(200, 200);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorGame);

                GameObject.Draw(carOne, carTwo, road);
                
                Raylib.EndDrawing();
            }
        }
    }
}

// double GetTime(void);   // Returns elapsed time in seconds since InitWindow()

