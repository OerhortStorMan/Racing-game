using System;
using Raylib_cs;

namespace Racing_Game
{
    public class Window
    {
        //WINDOW PROPERTIES
            //Window width
            public static int windowW = 1536;

            //Window height
            public static int windowH = 864;
        
            //Background color
            public static Color backgroundColorMain = new Color(0,0,0,0);

            public static Color backgroundColorGame = new Color(70, 127, 86, 0);

        public static void Initialize()
        {
            //WINDOW SIZE AND NAME
                Raylib.InitWindow(Window.windowW, Window.windowH, "Racing game");
            
            //TARGET FPS
                Raylib.SetTargetFPS(60);

        }
    }
}