using System;
using Raylib_cs;

namespace Racing_Game
{
    public class GameObject
    {
        public static void Draw(Car playerOne, Car playerTwo, Map road)
        {
            Raylib.DrawRectangleRec(Map.finishLine, Color.GRAY);
            Raylib.DrawRectangleRec(Map.straightway, Color.GRAY);
            Raylib.DrawRectangleRec(Map.deathcorner, Color.GRAY);
            Raylib.DrawRectangleRec(Map.rebound, Color.GRAY);
            Raylib.DrawRectangleRec(Map.snaketail, Color.GRAY);
            Raylib.DrawRectangleRec(Map.turnaround, Color.GRAY);
            Raylib.DrawRectangleRec(Map.mouth, Color.GRAY);
            Raylib.DrawRectangleRec(Map.parallel, Color.GRAY);
            Raylib.DrawRectangleRec(Map.southway, Color.GRAY);
            Raylib.DrawRectangleRec(Map.straightwayJR, Color.GRAY);
            Raylib.DrawRectangleRec(Map.offset, Color.GRAY);
            Raylib.DrawRectangleRec(Map.reRun, Color.GRAY);
            



            Rectangle playerOneRec = new Rectangle(playerOne.posX, playerOne.posY, playerOne.width, playerOne.length);

            Raylib.DrawRectanglePro(playerOneRec, playerOne.origin, playerOne.rotation, playerOne.carColor);




            Rectangle playerTwoRec = new Rectangle(playerTwo.posX, playerTwo.posY, playerTwo.width, playerTwo.length);

            Raylib.DrawRectanglePro(playerTwoRec, playerTwo.origin, playerTwo.rotation, playerTwo.carColor);

            



            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.RED);

            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW - 260, 5, 45, Color.BLUE);




            

        }
    }
}