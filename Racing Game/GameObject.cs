using System;
using Raylib_cs;

namespace Racing_Game
{
    public class GameObject
    {
        public static void Draw(Car playerOne, Car playerTwo, Map road)
        {
            Raylib.DrawRectanglePro(new Rectangle(playerOne.PosX, playerOne.PosY, playerOne.width, playerOne.length), playerOne.origin, playerOne.rotation, playerOne.carColor);
            // Raylib.DrawRectangle((int)playerOne.PosX, (int)playerOne.PosY, playerOne.width, playerOne.length, playerOne.carColor);

            // Raylib.DrawRectangle((int)playerTwo.PosX, (int)playerTwo.PosY, playerTwo.width, playerTwo.length, playerTwo.carColor);
        
            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.WHITE);
            
            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW-260, 5, 45, Color.WHITE);
        }
    }
}