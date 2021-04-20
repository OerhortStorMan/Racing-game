using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Racing_Game
{
    public class Map : GameObject
    {
        static float roadWidth = 100;
        static public Rectangle finishLine = new Rectangle(100, 100, roadWidth, 300);
        static public Rectangle straightway = new Rectangle(100, 100, 1300, roadWidth);
        static public Rectangle deathcorner = new Rectangle(1300, 100, roadWidth, 300);
        static public Rectangle rebound = new Rectangle(500, 300, 800, roadWidth);
        static public Rectangle snaketail = new Rectangle(500, 300, roadWidth, 300);
        static public Rectangle turnaround = new Rectangle(500, 600, 300, roadWidth);
        static public Rectangle mouth = new Rectangle(700, 500, roadWidth, 200);
        static public Rectangle parallel = new Rectangle(700, 500, 600, roadWidth);
        static public Rectangle southway = new Rectangle(1300, 500, roadWidth, 350);
        static public Rectangle straightwayJR = new Rectangle(300, 775, 1100, (roadWidth-25));
        static public Rectangle offset = new Rectangle(300, 300, roadWidth, 500);
        static public Rectangle reRun = new Rectangle(100, 300, 300, roadWidth);

        public static List<Rectangle> roads = new List<Rectangle>();


        public static void InitRoads()
        {
            roads.Add(finishLine);
            roads.Add(straightway);
            roads.Add(deathcorner);
            roads.Add(rebound);
            roads.Add(snaketail);
            roads.Add(turnaround);
            roads.Add(mouth);
            roads.Add(parallel);
            roads.Add(southway);
            roads.Add(straightwayJR);
            roads.Add(offset);
            roads.Add(reRun);
        }
        
        
    }
}