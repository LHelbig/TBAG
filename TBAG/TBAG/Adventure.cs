using System;
using System.Text;

[Serializable]
public class Adventure
{
    private int number;
    private int currentIndex;
    private string[] text = new string[10];
    private string[] clues = new string[10];


    public Adventure(string[] text, string[] clues)
    {
        this.text = text;
        this.clues = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    } // end public string Name

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            this.email = value;
        }
    } // end public string Email
} // end public class Friend