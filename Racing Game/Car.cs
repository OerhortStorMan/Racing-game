using System;
using System.Numerics;
using Raylib_cs;
using System.Windows.Input;

namespace Racing_Game
{
    public class Car : GameObject
    {
        public float speed = 10;
        public float acceleration = 1.25f;
        public float rotation = 0;

        //car pos
        public float PosX;
        public float PosY;
        
        //Color
        public Color carColor;

        public int lapScore = 0;

        public float length = 10;

        public float width = 20; 

        public int yInput = 0;

        public Vector2 origin = new Vector2(10, 5);

        float dt = Raylib.GetFrameTime();
        float timerAcc   = 0;
        float timerDeacc = 0;
        float timerBreak = 0;
        float timerBreakAcc = 0;
        

    //Position for spawning car
        public Car(float PosX, float PosY, Color carColor)
        {
            this.PosX = PosX;
            this.PosY = PosY;
            this.carColor = carColor;
        }
        
    //Calculate car movement
        public void CalculatePlayerOne()
        {
            //Car movement
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                yInput = -1;
                timerAcc  += Raylib.GetFrameTime();
                if (timerAcc  > 0.1f)
                {
                    speed += 5;
                    timerAcc  = 0;
                }
            }
            else
            {
                timerDeacc += Raylib.GetFrameTime();
                if (timerDeacc > 0.1f && speed > 0)
                {
                    speed -= 5;
                    timerDeacc = 0;
                }
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A) && speed != 0)
            {
                rotation--;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D) && speed != 0)
            {
                rotation++;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                yInput = 1;
                timerBreakAcc += Raylib.GetFrameTime();
                if (timerBreakAcc  > 0.1f)
                {
                    if (speed < 0)
                    {
                        speed -= 5;
                    }
                    else
                    {
                        speed -= 10;
                    }
                    timerBreakAcc  = 0;
                }
            }
            else
            {
                timerBreak += Raylib.GetFrameTime();
                if (timerBreak > 0.1f && speed < 0)
                {
                    speed += 5;
                    timerBreak = 0;
                }
            }

            PosX += MathF.Cos((rotation) * MathF.PI / 180) * speed * dt;
            PosY += MathF.Sin((rotation) * MathF.PI / 180) * speed * dt;

            yInput = 0;
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
                      PosX = MathF.Cos((rotation) * MathF.PI / 180) * speed * dt;
                      PosY = MathF.Sin((rotation) * MathF.PI / 180) * speed * dt;

        }

        public Vector2 getNextPos()
        {
            float nextX = (float)Math.Sin(rotation) * speed;
            float nextY = (float)Math.Cos(rotation) * speed;

            return new Vector2(nextX, nextY);
        }


    }
}
