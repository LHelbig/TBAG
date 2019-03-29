using System;

public class Room : GameObject
{
    private Boolean PLAYERLOCATION;
    private Room NORTH;
    private Room SOUTH;
    private Room EAST;
    private Room WEST;
    private String[] CONTENTS;

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
}
