using System;

public class Room : GameObject
{
    private Boolean PLAYERLOCATION; //is the player in this room?
    private Room NORTH;
    private Room SOUTH;
    private Room EAST;
    private Room WEST;
    private GameObject[] CONTENTS;

    public Room()
	{
	}

    //initializes room with references to all adjacent rooms
    public Room(Room north, Room south, Room east, Room west)
    {
        NORTH = north;
        SOUTH = south;
        EAST = east;
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
