using System;
using Raylib_cs;

namespace Racing_Game
{
    public class Scene : GameObject
    {
        Car playerOne;
        Car playerTwo;
        bool playerOneIsOnRoad = false;
        bool playerTwoIsOnRoad = false;
        public Rectangle playerOneRec;
        Rectangle playerTwoRec;

        public Scene(Car playerOne, Car playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        

        public void Draw(Car playerOne, Car playerTwo)
        {

            //road
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

            Raylib.DrawRectangleRec(Map.finishLine, Color.WHITE);

            Raylib.DrawRectangleRec(Map.checkpoint, Color.YELLOW);


            playerOneRec = new Rectangle(playerOne.posX, playerOne.posY, playerOne.width, playerOne.length);

            Raylib.DrawRectanglePro(playerOneRec, playerOne.origin, playerOne.rotation, playerOne.carColor);




            playerTwoRec = new Rectangle(playerTwo.posX, playerTwo.posY, playerTwo.width, playerTwo.length);

            Raylib.DrawRectanglePro(playerTwoRec, playerTwo.origin, playerTwo.rotation, playerTwo.carColor);





            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.RED);

            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW - 260, 5, 45, Color.BLUE);

        }

        public bool PlayerOneCollidesWithRoads(Car car)
        {
            for (int i = 0; i < Map.roads.Count; i++)
            {
                playerOneIsOnRoad = Raylib.CheckCollisionRecs(playerOneRec, Map.roads[i]);

                if (playerOneIsOnRoad == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PlayerTwoCollidesWithRoads(Car car)
        {
            for (int i = 0; i < Map.roads.Count; i++)
            {
                playerTwoIsOnRoad = Raylib.CheckCollisionRecs(playerTwoRec, Map.roads[i]);

                if (playerTwoIsOnRoad == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}