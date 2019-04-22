using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public class AdventureInformation
{

    private static AdventureInformation adventureInformation;

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

    private adventureInformation()
    {
        // Create a Dictionary to store friends at runtime
        this.friendsDictionary = new Dictionary<string, Friend>();
        this.formatter = new BinaryFormatter();
    } // end private FriendsInformation()

    public void addNewAdventure(string name, string email)
    {
        // If we already had added a friend with this name
        if (this.adventures.ContainsKey(name))
        {
            //Console.WriteLine("You had already added " + name + " before.");
        }
        // Else if we do not have this friend details 
        // in our dictionary
        else
        {
            // Add him in the dictionary
            this.adventures.Add(name, new Friend(name, email));
            Console.WriteLine("Friend added successfully.");
        } // end if
    } // end public bool AddFriend(string name, string email)

    public void RemoveFriend(string name)
    {
        // If we do not have a friend with this name
        if (!this.friendsDictionary.ContainsKey(name))
        {
            Console.WriteLine(name + " had not been added before.");
        }
        // Else if we have a friend with this name
        else
        {
            if (this.friendsDictionary.Remove(name))
            {
                Console.WriteLine(name + " had been removed successfully.");
            }
            else
            {
                Console.WriteLine("Unable to remove " + name);
            } // end if
        } // end if
    } // end public bool RemoveFriend(string name)

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
            this.formatter.Serialize(writerFileStream, this.friendsDictionary);

            // Close the writerFileStream when we are done.
            writerFileStream.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Unable to save our friends' information");
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
                this.friendsDictionary = (Dictionary<String, Friend>)
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
        if (this.friendsDictionary.Count > 0)
        {
            Console.WriteLine("Name, Email");
            foreach (Friend friend in this.friendsDictionary.Values)
            {
                Console.WriteLine(friend.Name + ", " + friend.Email);
            } // end foreach
        }
        else
        {
            Console.WriteLine("There are no saved information about your friends");
        } // end if
    }
}// end public void Print()
