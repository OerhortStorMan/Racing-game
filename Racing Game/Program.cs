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

            //Defines the position for the picker outside of the while loop so the value does not return to 0 every loop
            int picker = 0;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorMain);

                Raylib.DrawText("Racing game", 10, 10, 70, Color.WHITE);

                Raylib.DrawText(@"
Contol scheme:
    Menu:
        W - Move up
        S - Move down
        E - Select
        ESC - Exit game
    In-game:
        Player one:
            W - Accelerate
            S - Reverse / Break
            A - Turn left
            D - Turn Right
        Player two:
            UP - Accelerate
            DOWN - Reverse / Break
            LEFT - Turn left
            RIGHT - Turn Right
        
        ESC - Return to menu
", 500, 10, 25, Color.WHITE);

                //PICK OPTIONS ARRAY
                string[] pickArray = new string[] { "Play", "Quit" };

                //the text's y position is defined here since the same value is used further down in the code in the "picker" part
                int playTextY = 120;
                Raylib.DrawText(pickArray[0], 100, playTextY, 50, Color.WHITE);

                int exitTextY = 190;
                Raylib.DrawText(pickArray[1], 100, exitTextY, 50, Color.WHITE);

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

            Map map = new Map();
            map.InitRoads();

            Car playerOne = new Car(200, 145, Color.RED, 1);
            Car playerTwo = new Car(200, 160, Color.BLUE, 2);

            //Creates a scene that connects the players to the Scene class
            Scene plane = new Scene(playerOne, playerTwo);

            while (!Raylib.WindowShouldClose())
            {
                //Calculate the players movement
                playerOne.CalculatePlayerOne();

                playerTwo.CalculatePlayerTwo();

                //If a player doesnt collide with a road then the car will bump back out and they lose their speed
                if (plane.PlayerOneCollidesWithRoads(playerOne, map) == false)
                {
                    playerOne.speed = -10;
                }

                if (plane.PlayerTwoCollidesWithRoads(playerTwo, map) == false)
                {
                    playerTwo.speed = -10;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Window.backgroundColorGame);

                //Draw cars and map
                plane.Draw(playerOne, playerTwo, map);

                //If player has passed all laps let player win, also stops both players speed making it impossible for the other player to win
                if (playerOne.lapScore == map.lapReq)
                {
                    plane.AWinner(playerOne);
                    playerOne.speed = 0;
                    playerTwo.speed = 0;
                }
                if (playerTwo.lapScore == map.lapReq)
                {
                    plane.AWinner(playerTwo);
                    playerOne.speed = 0;
                    playerTwo.speed = 0;
                }

                Raylib.EndDrawing();
            }
        }
    }
}