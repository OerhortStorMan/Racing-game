using System;
using System.Numerics;
using Raylib_cs;
using System.Windows.Input;

namespace Racing_Game
{
    public class Car : GameObject
    {

        public float speed = 10;
        public float rotation = 0;
        public float rotationSpeed = 1.75f;

        //car pos
        public float posX;
        public float posY;

        //Color
        public Color carColor;

        public int lapScore = 0;
        public bool hasPassedGoal = false;

        public float length = 10;

        public float width = 20;

        public int yInput = 0;

        public Vector2 origin = new Vector2(10, 5);

         

        float dt = Raylib.GetFrameTime();
        float timerAcc = 0;
        float timerDeacc = 0;
        float timerBreak = 0;
        float timerBreakAcc = 0;

        
        //Position for spawning car
        public Car(float posX, float posY, Color carColor)
        {
            this.posX = posX;
            this.posY = posY;
            this.carColor = carColor;
        }

        //Calculate car movement
        public void CalculatePlayerOne()
        {
            //Car movement
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                yInput = -1;
                timerAcc += Raylib.GetFrameTime();
                if (timerAcc > 0.1f)
                {
                    speed += 5;
                    timerAcc = 0;
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
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && speed != 0)
            {
                if (speed > 0)
                {
                    rotation -= rotationSpeed;
                }
                else if (speed < 0)
                {
                    rotation += rotationSpeed;
                }
                
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && speed != 0)
            {
                if (speed > 0)
                {
                    rotation += rotationSpeed;
                }
                else if (speed < 0)
                {
                    rotation -= rotationSpeed;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                yInput = 1;
                timerBreakAcc += Raylib.GetFrameTime();
                if (timerBreakAcc > 0.1f)
                {
                    if (speed < 0)
                    {
                        speed -= 10;
                    }
                    else
                    {
                        speed -= 20;
                    }
                    timerBreakAcc = 0;
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

            posX += MathF.Cos((rotation) * MathF.PI / 180) * speed * dt;
            posY += MathF.Sin((rotation) * MathF.PI / 180) * speed * dt;

            yInput = 0;

        }

        public void CalculatePlayerTwo()
        {
            //Car movement
            //Forward
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                yInput = -1;
                timerAcc += Raylib.GetFrameTime();
                if (timerAcc > 0.1f)
                {
                    speed += 5;
                    timerAcc = 0;
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
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && speed != 0)
            {
                if (speed > 0)
                {
                    rotation -= rotationSpeed;
                }
                else if (speed < 0)
                {
                    rotation += rotationSpeed;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && speed != 0)
            {
                if (speed > 0)
                {
                    rotation += rotationSpeed;
                }
                else if (speed < 0)
                {
                    rotation -= rotationSpeed;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                yInput = 1;
                timerBreakAcc += Raylib.GetFrameTime();
                if (timerBreakAcc > 0.1f)
                {
                    if (speed < 0)
                    {
                        speed -= 10;
                    }
                    else
                    {
                        speed -= 20;
                    }
                    timerBreakAcc = 0;
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

            posX += MathF.Cos((rotation) * MathF.PI / 180) * speed * dt;
            posY += MathF.Sin((rotation) * MathF.PI / 180) * speed * dt;

            yInput = 0;

            

        }


    }
}
