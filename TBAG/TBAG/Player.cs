using System;
using System.Collections;

public class Player : GameObject
{
    Room LOCATION;

	public Player()
	{
	}

    public void parseCommand(string command) //used for command interpretation and execution
    {
        string[] word = command.Split(' ');
        switch (word[0])
        {
            case "get":
                {
                    break;
                }
            case "inventory":
                {
                    ArrayList invList = new ArrayList();
                    break;
                }
            case "move":
                {
                    updateLocation(word[1]);
                    break;
                }
        }
    }

    private Boolean updateLocation(String direction) //move n, s, e, w from current room, returns truw is able to move to room
    {
        String moveTargetID; //id of room to be moved to

        //check to see if there is a room to move to
        switch (direction)
        {
            case "north":
                moveTargetID = LOCATION.lookNorth();
                if (moveTargetID == null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "south":
                moveTargetID = LOCATION.lookSouth();
                if (moveTargetID == null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "east":
                moveTargetID = LOCATION.lookEast();
                if (moveTargetID == null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            case "west":
                moveTargetID = LOCATION.lookWest();
                if (moveTargetID == null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            default:
                Console.WriteLine("error occured");
                return false;
                break;
        }

        //move to new room, while changing the flag that is set
        LOCATION.PLAYERLOCATION = false;
        //LOCATION = moveTargetID; fix me by getting room from the idvalue
        LOCATION.PLAYERLOCATION = true;
        return true;

    }
}
