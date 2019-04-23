using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

/*This class is to be used for potential implementation of saving games. It is a handler for the adventure class*/
public class AdventureInformation
{

    private static AdventureInformation adventureInformation;

    private Adventure adventure;

    private Dictionary<string, Adventure> adventures;
    private BinaryFormatter formatter;

    private const string DATA_FILENAME = "adventureinformation.dat";

    public static AdventureInformation Instance()
    {
        if (adventureInformation == null)
        {
            adventureInformation = new AdventureInformation();
        }

        return adventureInformation;
    }

    private AdventureInformation()
    {
        // Create a Dictionary to store friends at runtime
        this.adventures = new Dictionary<string, Adventure>();
        this.formatter = new BinaryFormatter();
        addAdventure("one");
        addAdventure("two");
        addAdventure("three");
    } // end private FriendsInformation()

    public void saveAdventure(string number, int currentIndex, bool current, string[] text, string[] clues)
    {
        // If we already had added a friend with this name
        if (this.adventures.ContainsKey(number))
        {
            //Console.WriteLine("You had already added " + name + " before.");
            adventure = this.adventures[number];
            adventure.CurrentIndex = currentIndex;
            adventure.Current = current;
            adventure.Text = text;
            adventure.Clues = clues;
        }
        // Else if we do not have this friend details 
        // in our dictionary
        else
        {
        } // end if
    } // end public bool AddFriend(string name, string email)
    public void addAdventure(string number)
    {
        // If we already had added a friend with this name
        if (this.adventures.ContainsKey(number))
        {
        }
        // Else if we do not have this friend details 
        // in our dictionary
        else
        {
            // Add him in the dictionary
            this.adventures.Add(number, new Adventure(number));
            //Console.WriteLine("Friend added successfully.");
        } // end if
    }
    /*    public bool getCurrent(int number)
        {
            return adventures<number, Adventure.current>;
        }*/
    public void RemoveAdventure(string number)
    {
        // If we do not have a friend with this name
        if (!this.adventures.ContainsKey(number))
        {
            //Console.WriteLine(name + " had not been added before.");
        }
        // Else if we have a friend with this name
        else
        {
            if (this.adventures.Remove(number))
            {
                //Console.WriteLine(name + " had been removed successfully.");
            }
            else
            {
                //Console.WriteLine("Unable to remove " + name);
            } // end if
        } // end if
    } // end public bool RemoveFriend(string name)

    public void resetAdventure(string number)
    {
        if (this.adventures.ContainsKey(number))
        {
            adventure = this.adventures[number];
            this.adventures.Remove(number);
            this.adventures.Add(number, new Adventure(number));
            adventure.Reset = true;

        }
    }

    public int getCurrentIndex(string number)
    {
        adventure = this.adventures[number];
        return adventure.CurrentIndex;
    }
    public void setCurrentIndex(string number, int index)
    {
        adventure = this.adventures[number];
        adventure.CurrentIndex = index;
    }
    public int getClueIndex(string number)
    {
        adventure = this.adventures[number];
        return adventure.ClueIndex;
    }
    public void setClueIndex(string number, int index)
    {
        adventure = this.adventures[number];
        adventure.ClueIndex = index;
    }
    public bool getCurrent(string number)
    {
        adventure = this.adventures[number];
        return adventure.Current;
    }
    public void setCurrent(string number, bool current)
    {
        adventure = this.adventures[number];
        adventure.Current = current;
    }
    public bool getFull(string number)
    {
        adventure = this.adventures[number];
        return adventure.Full;
    }
    public void setFull(string number, bool full)
    {
        adventure = this.adventures[number];
        adventure.Full = full;
    }
    public bool getReset(string number)
    {
        adventure = this.adventures[number];
        return adventure.Reset;
    }
    public void setReset(string number, bool reset)
    {
        adventure = this.adventures[number];
        adventure.Reset = reset;
    }
    public string[] getText(string number)
    {
        adventure = this.adventures[number];
        return adventure.Text;
    }
    public void setText(string number, string[] text)
    {
        adventure = this.adventures[number];
        adventure.Text = text;
    }
    public string[] getClues(string number)
    {
        adventure = this.adventures[number];
        return adventure.Clues;
    }
    public void setClues(string number, string[] clues)
    {
        adventure = this.adventures[number];
        adventure.Clues = (clues);
    }

    public void Save()
    {
        // Gain code access to the file that we are going
        // to write to
        try
        {
            // Create a FileStream that will write data to file.
            FileStream writerFileStream =
                new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
            // Save our dictionary of friends to file
            this.formatter.Serialize(writerFileStream, this.adventures);

            // Close the writerFileStream when we are done.
            writerFileStream.Close();
        }
        catch (Exception)
        {
            //Console.WriteLine("Unable to save our friends' information");
        } // end try-catch
    } // end public bool Load()

    public void Load()
    {

        // Check if we had previously Save information of our friends
        // previously
        if (File.Exists(DATA_FILENAME))
        {

            try
            {
                // Create a FileStream will gain read access to the 
                // data file.
                FileStream readerFileStream = new FileStream(DATA_FILENAME,
                    FileMode.Open, FileAccess.Read);
                // Reconstruct information of our friends from file.
                this.adventures = (Dictionary<string, Adventure>)
                    this.formatter.Deserialize(readerFileStream);
                // Close the readerFileStream when we are done
                readerFileStream.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("There seems to be a file that contains " +
                    "friends information but somehow there is a problem " +
                    "with reading it.");
            } // end try-catch

        } // end if

    } // end public bool Load()

    public void Print()
    {
        // If we have saved information about friends
        if (this.adventures.Count > 0)
        {
            //Console.WriteLine("Name, Email");
           /* foreach (Friend friend in this.friendsDictionary.Values)
            {
                Console.WriteLine(friend.Name + ", " + friend.Email);
            } // end foreach*/
        }
        else
        {
            //Console.WriteLine("There are no saved information about your friends");
        } // end if
    }
}// end public void Print()
