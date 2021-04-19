using System;
using Raylib_cs;

namespace Racing_Game
{
    public class Map : GameObject
    {
        static float roadWidth = 100;

        static public Rectangle finishLine = new Rectangle(100, 100, roadWidth, 300);
        static public Rectangle straightway = new Rectangle(100, 100, 1300, roadWidth);
        static public Rectangle deathcorner = new Rectangle(1300, 100, roadWidth, 300);
        static public Rectangle rebound = new Rectangle(500, 300, 800, roadWidth);
        static public Rectangle snaketail = new Rectangle();
        static public Rectangle turnaround = new Rectangle();
        static public Rectangle mouth = new Rectangle();
        static public Rectangle parallel = new Rectangle();
        static public Rectangle southway = new Rectangle();
        static public Rectangle straightwayJR = new Rectangle();
        static public Rectangle offset = new Rectangle();
        static public Rectangle reRun = new Rectangle();



        // static public Rectangle X = new Rectangle();
    }
}