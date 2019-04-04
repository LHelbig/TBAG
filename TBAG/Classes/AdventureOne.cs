using System;

public class AdventureOne
{
    Boolean reset;
    Boolean full;
    static String[] textBoxText = String[10];
    static String[] clues = String[10];
    static int clueIndex;
    static int mapXCoordinate;
    static int mapYCoordinate;
    

	public AdventureOne()
	{
	}

    public Boolean getFull()
    {
        return full;
    }

    public void resetAdventure()
    {
        currentIndex = 0;
        clueIndex = 0;

        foreach(int i in textBoxText){
            textBoxText[i] = "";
        }

        foreach(int i in clues)
        {
            clues[i] = "";
        }
        //once map is figured out, reset map coordinates to the beginning

        reset = true;
    }

    public int load(String[] textBox, String[] clueArray)
    {
        int counter = 0;

        foreach(int i in textBoxText)
        {
            if(textBoxText[i] != "")
            {
                counter++;
                textBox[i] = textBoxText[i];
            }
        }

        for(int i = 0; i <= clueIndex; i++)
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

        mapXCoordinate = positionX;
        mapYCoordinate = positionY;
    }
}
