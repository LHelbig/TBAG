using System;

public class NPC : GameObject
{

    private ArrayList INVENTORY = new ArrayList();

    public NPC()
	{
	}

    public addToInventory(GameObject item)
    {
        INVENTORY.add(item);
    }
}
