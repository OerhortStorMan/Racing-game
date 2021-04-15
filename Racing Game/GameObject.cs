using System;
using Raylib_cs;

namespace Racing_Game
{
    public class GameObject
    {
        public static void Draw(Car playerOne, Car playerTwo, Map road)
        {
            Raylib.DrawRectangle((int)playerOne.PosX, (int)playerOne.PosY, playerOne.width, playerOne.length, playerOne.carColor);

            Raylib.DrawRectangle((int)playerTwo.PosX, (int)playerTwo.PosY, playerTwo.width, playerTwo.length, playerTwo.carColor);
        
            Raylib.DrawText("P1: " + playerOne.lapScore.ToString(), (Window.windowW/2)-(Window.windowH/4)-100, 5, 100, Color.WHITE);
            
            Raylib.DrawText("P2: " + playerTwo.lapScore.ToString(), (Window.windowW/2)+(Window.windowH/4)-100, 5, 100, Color.WHITE);
        }
    }
}