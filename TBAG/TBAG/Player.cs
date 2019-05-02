using System;

public class Player : GameObject
{
    Room LOCATION;

	public Player(String name, String descrip, String id)
	{
        NAME = name;
        DESCRIPTION = descrip;
        IDVALUE = id;
    }

    public void parseCommand(String command) //used for command interpretation and execution
    {
        String[] data = command.Split(' ');
        
        switch (data[0])
        {
            case "get":
                {

                }
            case "inventory":
                {
                    ArrayList invList = new ArrayList();
                    invList.add("TEST1");
                    invList.add("TEST2");
                    invList.add(1);
                    invList.add(2);

                }
            case "move":
                {
                    updateLocation(data[1]);
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
                { moveTargetID = LOCATION.lookSouth();
                    if (moveTargetID == null)
                    {
                        Console.WriteLine("no room in that direction");
                        return false;
                    }
                    break;
                }

            case "east":
                {
                    moveTargetID = LOCATION.lookEast();
                    if (moveTargetID == null)
                    {
                        Console.WriteLine("no room in that direction");
                        return false;
                    }
                    break;
                }
            case "west":
                {
                    moveTargetID = LOCATION.lookWest();
                    if (moveTargetID == null)
                    {
                        Console.WriteLine("no room in that direction");
                        return false;
                    }
                    break;
                }
            default:
                {
                    Console.WriteLine("error occured");
                    break;
                }
        }

        //move to new room, while changing the flag that is set
        LOCATION.PLAYERLOCATION = false;
        LOCATION = moveTargetID;
        LOCATION.PLAYERLOCATION = true;

    }
}
