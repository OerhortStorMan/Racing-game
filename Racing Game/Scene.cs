using System;
using Raylib_cs;

namespace Racing_Game
{
    public class Scene : GameObject
    {
        Car playerOne;
        Car playerTwo;
        bool playerOneHasCollided = false;
        bool playerTwoHasCollided = false;
        public Rectangle playerOneRec;
        Rectangle playerTwoRec;

        public Scene(Car playerOne, Car playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        

        public void Draw(Car playerOne, Car playerTwo)
        {
            //grass

            // Rectangle grass = new Rectangle(0, 0, Window.windowW, Window.windowH);
            // Raylib.DrawRectangle((int)grass.x, (int)grass.y, (int)grass.width, (int)grass.height, Window.backgroundColorGame);

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


            playerOneRec = new Rectangle(playerOne.posX, playerOne.posY, playerOne.width, playerOne.length);

            Raylib.DrawRectanglePro(playerOneRec, playerOne.origin, playerOne.rotation, playerOne.carColor);




            playerTwoRec = new Rectangle(playerTwo.posX, playerTwo.posY, playerTwo.width, playerTwo.length);

            Raylib.DrawRectanglePro(playerTwoRec, playerTwo.origin, playerTwo.rotation, playerTwo.carColor);





            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.RED);

            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW - 260, 5, 45, Color.BLUE);

            



            // bool outOfBoundsPlayerOne = Raylib.CheckCollisionRecs(playerOneRec, Map.roads);

            // bool outOfBoundsPlayerTwo = Raylib.CheckCollisionRecs(playerTwoRec, grass);

            // if (outOfBoundsPlayerOne)
            // {
            //     playerOne.speed = 0;
            //     playerOne.speed -= 10;
            // }


        }

        public bool PlayerOneCollidesWithRoads(Car car)
        {
            for (int i = 0; i < Map.roads.Count; i++)
            {
                playerOneHasCollided = Raylib.CheckCollisionRecs(playerOneRec, Map.roads[i]);

                if (playerOneHasCollided == true)
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
                playerTwoHasCollided = Raylib.CheckCollisionRecs(playerTwoRec, Map.roads[i]);

                if (playerTwoHasCollided == true)
                {
                    return true;
                }
            }
            return false;
        }
            // /*
            //     bool harkolliderat - false
            //     loop genom listan:
            //         Om kolliderar med rektangel:
            //         harkolliderat = true

            //     return harkolliderat
            // */
    }
}