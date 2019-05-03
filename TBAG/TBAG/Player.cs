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
                    returnText.Enqueue(updateLocation(word[1]));
                    return returnText;
                }
            default:
                {
                    returnText.Enqueue("You imbecile.");
                    return returnText;
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
        }

        //move to new room, while changing the flag that is set
        LOCATION.PLAYERLOCATION = false;
        //LOCATION = moveTargetID; fix me by getting room from the idvalue
        LOCATION.PLAYERLOCATION = true;
        return true;

    }
}
