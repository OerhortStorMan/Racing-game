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

        public void Draw(Car playerOne, Car playerTwo, Map map)
        {
            //road
            Raylib.DrawRectangleRec(map.finishLine, Color.GRAY);
            Raylib.DrawRectangleRec(map.straightway, Color.GRAY);
            Raylib.DrawRectangleRec(map.deathcorner, Color.GRAY);
            Raylib.DrawRectangleRec(map.rebound, Color.GRAY);
            Raylib.DrawRectangleRec(map.snaketail, Color.GRAY);
            Raylib.DrawRectangleRec(map.turnaround, Color.GRAY);
            Raylib.DrawRectangleRec(map.mouth, Color.GRAY);
            Raylib.DrawRectangleRec(map.parallel, Color.GRAY);
            Raylib.DrawRectangleRec(map.southway, Color.GRAY);
            Raylib.DrawRectangleRec(map.straightwayJR, Color.GRAY);
            Raylib.DrawRectangleRec(map.offset, Color.GRAY);
            Raylib.DrawRectangleRec(map.reRun, Color.GRAY);

            Raylib.DrawRectangleRec(map.goal, Color.WHITE);

            Raylib.DrawRectangleRec(map.checkpoint, Color.YELLOW);


            playerOneRec = new Rectangle(playerOne.posX, playerOne.posY, playerOne.width, playerOne.length);

            Raylib.DrawRectanglePro(playerOneRec, playerOne.origin, playerOne.rotation, playerOne.carColor);




            playerTwoRec = new Rectangle(playerTwo.posX, playerTwo.posY, playerTwo.width, playerTwo.length);

            Raylib.DrawRectanglePro(playerTwoRec, playerTwo.origin, playerTwo.rotation, playerTwo.carColor);





            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.RED);

            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW - 260, 5, 45, Color.BLUE);

             
             

        }

        public bool PlayerOneCollidesWithRoads(Car car, Map map)
        {
            for (int i = 0; i < map.roads.Count; i++)
            {
                playerOneIsOnRoad = Raylib.CheckCollisionRecs(playerOneRec, map.roads[i]);

                if (playerOneIsOnRoad == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PlayerTwoCollidesWithRoads(Car car, Map map)
        {
            for (int i = 0; i < map.roads.Count; i++)
            {
                playerTwoIsOnRoad = Raylib.CheckCollisionRecs(playerTwoRec, map.roads[i]);

                if (playerTwoIsOnRoad == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}