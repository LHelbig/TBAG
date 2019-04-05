using System;

public class Player : GameObject
{
    Room LOCATION;

	public Player()
	{
	}

    public parseCommand() //used for command interpretation and execution
    {

    }

    private Boolean updateLocation(String direction) //move n, s, e, w from current room, returns truw is able to move to room
    {


        //check to see if there is a room to move to
        switch (direction)
        {
            case "north":
                if (LOCATION.lookNorth() = null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "south":
                if (LOCATION.lookSouth() = null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "east":
                if (LOCATION.lookEast() = null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "west":
                if (LOCATION.lookWest() = null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            default:
                Console.WriteLine("error occured");
        }
    }
}
