using System;
using System.Collections;

public class Player : GameObject
{
    Room LOCATION;
    ArrayList invList = new ArrayList();
    Queue returnText = new Queue();
    


    public Player()
	{
        invList.Add("Test");
        invList.Add("Jacob wants this semester to be over already.");
    }

    public Queue parseCommand(string command) //used for command interpretation and execution
    {
        returnText.Clear();
        Console.WriteLine("Cleared.");
        string[] word = command.Split(' ');
        switch (word[0])
        {
            case "get":
                {
                    returnText.Enqueue("get filler");
                    return returnText;
                }
            case "inventory":
                {
                    if (invList.Count == 0)
                    {
                        Console.WriteLine("There is nothing in your inventory.");
                        returnText.Enqueue("There is nothing in your inventory.");
                        return returnText;

                    }
                    else if(invList.Count != 0)
                    {
                        foreach(var item in invList) 
                        {
                            Console.WriteLine(" - " + item);
                            returnText.Enqueue(" - " + item);
 

                        }
                    }
                    return returnText;
                }
            case "move":
                {
                    updateLocation(word[1]);
                    return returnText;
                }
            default:
                {
                    returnText.Enqueue("You imbecile.");
                    return returnText;
                }
        }
    }

    public void setLocation(Room place)
    {
        LOCATION = place;
        LOCATION.PLAYERLOCATION = true;
    }

    private Boolean updateLocation(String direction) //move n, s, e, w from current room, returns true is able to move to room
    {
        Room moveTarget; //id of room to be moved to

        //check to see if there is a room to move to
        switch (direction)
        {
            case "north":
                moveTarget = LOCATION.lookNorth();
                if (moveTarget == null)
                {
                    Console.WriteLine("no room in that direction");
                    returnText.Enqueue("no room in that direction");
                    return false;
                }
                break;
            case "south":
                moveTarget = LOCATION.lookSouth();
                if (moveTarget == null)
                {
                    Console.WriteLine("no room in that direction");
                    returnText.Enqueue("no room in that direction");
                    return false;
                }
                break;
            case "east":
                moveTarget = LOCATION.lookEast();
                if (moveTarget == null)
                {
                    Console.WriteLine("no room in that direction");
                    returnText.Enqueue("no room in that direction");
                    return false;
                }
                break;
            case "west":
                moveTarget = LOCATION.lookWest();
                if (moveTarget == null)
                {
                    Console.WriteLine("no room in that direction");
                    return false;
                }
                break;
            default:
                Console.WriteLine("error occured");
                returnText.Enqueue("no room in that direction");
                return false;
        }

        //move to new room, while changing the flag that is set
        LOCATION.PLAYERLOCATION = false;
        LOCATION = moveTarget;
        LOCATION.PLAYERLOCATION = true;

        returnText.Enqueue("You moved to " + LOCATION.IDVALUE);
        return true;

    }
}
