using System;
using System.Numerics;
using Raylib_cs;
using System.Windows.Input;

namespace Racing_Game
{
    public class Car : GameObject
    {
        public float speed = 5;
        public float acceleration = 1.25f;
        public float rotation = 0;

        //car pos
        public float PosX;
        public float PosY;
        
        //Color
        public Color carColor;

        public int lapScore = 0;

        public int length = 20;

        public int width = 10; 

    //Position for spawning car
        public Car(float PosX, float PosY, Color carColor, int lapScore)
        {
            this.PosX = PosX;
            this.PosY = PosY;
            this.carColor = carColor;
            this.lapScore = lapScore;
        }

    //Calculate car movement
        public void CalculatePlayerOne()
        {
            //Car movement
                //Forward
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                    {
                        PosY--;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
                    {
                        PosX--;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
                    {
                        PosX++;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
                    {
                        PosY++;
                    }
                      
        }

        public void CalculatePlayerTwo()
        {
            //Car movement
                //Forward
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        PosY--;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        PosX--;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        PosX++;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        PosY++;
                    }
                      
        }

        public Vector2 getNextPos()
        {
            float nextX = (float)Math.Sin(rotation) * speed;
            float nextY = (float)Math.Cos(rotation) * speed;

            return new Vector2(nextX, nextY);
        }



    }
}