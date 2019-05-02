using System;

public class Room : GameObject
{
    public Boolean PLAYERLOCATION; //is the player in this room?
    private Room NORTH;
    private Room SOUTH;
    private Room EAST;
    private Room WEST;
    private GameObject[] CONTENTS;

    public Room()
	{
        NORTH = null;
        SOUTH = null;
        EAST = null;
        WEST = null;
	}

    //initializes room with references to all adjacent rooms
    public Room(Room north, Room south, Room east, Room west)
    {
        NORTH = north;
        SOUTH = south;
        EAST = east;
        WEST = west;

    }

    public void setAdjacent(Room north, Room south, Room east, Room west)
    {
        NORTH = north;
        SOUTH = south;
        EAST = east;
        WEST = west;
    }

    public void setNorth(Room north)
    {
        NORTH = north;
    }

    public void setSouth(Room south)
    {
        SOUTH = south;
    }
    public void setEast(Room east)
    {
        EAST = east;
    }
    public void setWest(Room west)
    {
        WEST = west;
    }


    public String lookNorth()
    {
        return NORTH.IDVALUE;
    }

    public String lookSouth()
    {
        return SOUTH.IDVALUE;
    }

    public String lookEast()
    {
        return EAST.IDVALUE;
    }

    public String lookWest()
    {
        return WEST.IDVALUE;
    }
}
