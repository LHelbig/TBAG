using System;

public class Interactable : NPC
{
    private String[][] speechOptions;

    public Interactable()
	{

	}

    public String getText (int r, int c)
    {
        return speechOptions[r][c];
    }
}
