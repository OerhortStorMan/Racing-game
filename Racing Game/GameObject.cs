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
        }

        
    }
}