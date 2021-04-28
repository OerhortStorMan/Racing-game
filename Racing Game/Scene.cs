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
        Rectangle playerOneRec;
        Rectangle playerTwoRec;

        public Scene(Car playerOne, Car playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public void Draw(Car playerOne, Car playerTwo, Map map)
        {
            //Draw road and goals + checkpoints
            for (int i = 0; i < map.roads.Count; i++)
            {
                Raylib.DrawRectangleRec(map.roads[i], Color.GRAY);
            }

            //Draw goal
            Raylib.DrawRectangleRec(map.goal, Color.WHITE);

            //These are gray so that they are invisible to the player, making it near impossible for the player to cheat without seeing the code
            Raylib.DrawRectangleRec(map.checkpoint, Color.GRAY);
            Raylib.DrawRectangleRec(map.bufferCheckpoint, Color.GRAY);


            
            //Draw p1
            playerOneRec = new Rectangle(playerOne.posX, playerOne.posY, playerOne.width, playerOne.length);

            Raylib.DrawRectanglePro(playerOneRec, playerOne.origin, playerOne.rotation, playerOne.carColor);

            //Roof/back of car to indicate back and front
            Raylib.DrawRectanglePro(new Rectangle(playerOne.posX, playerOne.posY, 10, 10), playerOne.origin, playerOne.rotation, Color.BROWN);



            //Draw p2
            playerTwoRec = new Rectangle(playerTwo.posX, playerTwo.posY, playerTwo.width, playerTwo.length);

            Raylib.DrawRectanglePro(playerTwoRec, playerTwo.origin, playerTwo.rotation, playerTwo.carColor);

            //Roof/back of car to indicate back and front
            Raylib.DrawRectanglePro(new Rectangle(playerTwo.posX, playerTwo.posY, 10, 10), playerTwo.origin, playerTwo.rotation, Color.DARKBLUE);



            //Draw lap score
            Raylib.DrawText("P1 Laps: " + playerOne.lapScore.ToString(), 30, 5, 45, Color.RED);

            Raylib.DrawText("P2 Laps: " + playerTwo.lapScore.ToString(), Window.windowW - 260, 5, 45, Color.BLUE);             
             
            //Player one add lap score
                if (playerOne.hasPassedGoal == true && playerOne.hasPassedCheckpoint == true)
                {
                    playerOne.lapScore++;
                    playerOne.hasPassedCheckpoint = false;
                    playerOne.hasPassedGoal = false;
                }

                if (Raylib.CheckCollisionRecs(playerOneRec, map.checkpoint))
                {
                    playerOne.hasPassedCheckpoint = true;
                }
                
                if (Raylib.CheckCollisionRecs(playerOneRec, map.goal))
                {
                    playerOne.hasPassedGoal = true;
                }

                if (Raylib.CheckCollisionRecs(playerOneRec, map.bufferCheckpoint) == true)
                {
                    playerOne.hasPassedGoal = false;
                }

            //player one add lap score
                if (playerTwo.hasPassedGoal == true && playerTwo.hasPassedCheckpoint == true)
                {
                    playerTwo.lapScore++;
                    playerTwo.hasPassedCheckpoint = false;
                    playerTwo.hasPassedGoal = false;
                }

                if (Raylib.CheckCollisionRecs(playerTwoRec, map.checkpoint))
                {
                    playerTwo.hasPassedCheckpoint = true;
                }
                
                if (Raylib.CheckCollisionRecs(playerTwoRec, map.goal))
                {
                    playerTwo.hasPassedGoal = true;
                }

                if (Raylib.CheckCollisionRecs(playerTwoRec, map.bufferCheckpoint) == true)
                {
                    playerTwo.hasPassedGoal = false;
                }
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

        public void AWinner(Car car)
        {
            Raylib.DrawRectangle(0,0,Window.windowW, Window.windowH, Color.BLACK);
            Raylib.DrawText("Player " + car.ID.ToString() + " has won the race", 400, 350, 50, Color.MAGENTA);
            
        }
    }
}