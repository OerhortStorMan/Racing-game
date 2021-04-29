using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;

namespace Racing_Game
{
    public class Map : GameObject
    {
        //Amounth of laps required for a win
        public int lapReq = 2;

        //Roads
        static float roadWidth = 100;
        Rectangle finishLine = new Rectangle(100, 100, roadWidth, 300);
        Rectangle straightway = new Rectangle(100, 100, 1300, roadWidth);
        Rectangle deathcorner = new Rectangle(1300, 100, roadWidth, 300);
        Rectangle rebound = new Rectangle(500, 300, 800, roadWidth);
        Rectangle snaketail = new Rectangle(500, 300, roadWidth, 300);
        Rectangle turnaround = new Rectangle(500, 600, 300, roadWidth);
        Rectangle mouth = new Rectangle(700, 500, roadWidth, 200);
        Rectangle parallel = new Rectangle(700, 500, 600, roadWidth);
        Rectangle southway = new Rectangle(1300, 500, roadWidth, 350);
        Rectangle straightwayJR = new Rectangle(300, 775, 1100, (roadWidth - 25));
        Rectangle offset = new Rectangle(300, 300, roadWidth, 500);
        Rectangle reRun = new Rectangle(100, 300, 300, roadWidth);

        //Road list
        //This shortens code in Scene using a for loop to draw roads
        public List<Rectangle> roads = new List<Rectangle>();

        //Initiate road, adding road recs to roads list
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

        public Rectangle bufferCheckpoint = new Rectangle(280, 100, 20, 100);


    }
}