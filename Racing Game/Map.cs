using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Racing_Game
{
    public class Map : GameObject
    {
        //Road
         static float roadWidth = 100;
         public Rectangle finishLine = new Rectangle(100, 100, roadWidth, 300);
         public Rectangle straightway = new Rectangle(100, 100, 1300, roadWidth);
         public Rectangle deathcorner = new Rectangle(1300, 100, roadWidth, 300);
         public Rectangle rebound = new Rectangle(500, 300, 800, roadWidth);
         public Rectangle snaketail = new Rectangle(500, 300, roadWidth, 300);
         public Rectangle turnaround = new Rectangle(500, 600, 300, roadWidth);
         public Rectangle mouth = new Rectangle(700, 500, roadWidth, 200);
         public Rectangle parallel = new Rectangle(700, 500, 600, roadWidth);
         public Rectangle southway = new Rectangle(1300, 500, roadWidth, 350);
         public Rectangle straightwayJR = new Rectangle(300, 775, 1100, (roadWidth-25));
         public Rectangle offset = new Rectangle(300, 300, roadWidth, 500);
         public Rectangle reRun = new Rectangle(100, 300, 300, roadWidth);

        //Road list
        public  List<Rectangle> roads = new List<Rectangle>();

        //Initiate road
        public void InitRoads()
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

        //Finish line & checkpoint
         public Rectangle goal = new Rectangle(230, 100, 20, 100);

         public Rectangle checkpoint = new Rectangle(500, 500, 100, 20);
        
        
    }
}