using System;
using System.Numerics;
using Raylib_cs;
using System.Windows.Input;

namespace Racing_Game
{
    public class CarOne : GameObject
    {
        public float speed = 5;
        public float acceleration = 1.25f;
        public float turnDegree = 0;

        public float PosX;
        public float PosY;

    //Position for spawning car
        public CarOne(float PosX, float PosY)
        {
            this.PosX = PosX;
            this.PosY = PosY;
        }

    //Calculate car movement
        public void Calculate()
        {
            //Car movement
                //Forward
                    while (true)
                    {
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {

                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {

                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            
                        }
                    }

                    

        }

        public Vector2 getNextPos()
        {
            float nextX = (float)Math.Sin(turnDegree) * speed;
            float nextY = (float)Math.Cos(turnDegree) * speed;

            return new Vector2(nextX, nextY);
        }



    }
}