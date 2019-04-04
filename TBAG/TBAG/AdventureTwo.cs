﻿using System;

namespace TBAG
{
    public class AdventureTwo
    {
        bool reset = false;
        bool full = false;
        static bool current;
        static String[] textBoxText = new String[10];
        static String[] clues = new String[10];
        static int clueIndex;
        static int mapXCoordinate;
        static int mapYCoordinate;

        //GameScreen gs = new GameScreen();

        public AdventureTwo()
        {
        }

        public Boolean getFull()
        {
            return full;
        }

        public Boolean getReset()
        {
            return reset;
        }

        public int resetAdventure()
        {
            clueIndex = 0;

            for (int i = 0; i <= 9; i++)
            {
                textBoxText[i] = "";
            }

            for (int i = 0; i <= 9; i++)
            {
                clues[i] = "";
            }
            //once map is figured out, reset map coordinates to the beginning

            reset = true;
            full = false;
            //gs.clueNumber = clueIndex;
            return 0;
        }

        public int load(String[] textBox, String[] clueArray)
        {
            int counter = 0;

            for (int i = 0; i <= 9; i++)
            {
                if (textBoxText[i] != "")
                {
                    counter++;
                    textBox[i] = textBoxText[i];
                }
            }

            for (int i = 0; i <= clueIndex; i++)
            {
                clueArray[i] = clues[i];
            }

            return counter - 1;
        }

        public void saveGame(int index, int clueIndex, int positionX, int positionY, String[] textBox, String[] clueArray)
        {
            for (int i = 9; i >= 0; i--)
            {
                textBoxText[i] = textBox[index];
                index--;
            }

            for (int i = 0; i <= clueIndex; i++)
            {
                clues[i] = clueArray[i];
            }

            full = true;
            mapXCoordinate = positionX;
            mapYCoordinate = positionY;
        }
        public void setCurrent(bool value)
        {
            current = value;
        }

        public bool getCurrent()
        {
            return current;
        }
    }
}
