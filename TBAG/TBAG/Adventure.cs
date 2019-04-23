using System;
using System.Text;

[Serializable]
public class Adventure
{
    private string number;
    private int currentIndex;
    private int clueIndex;
    private bool current;
    private bool full;
    private bool reset;
    private string[] text = new string[10];
    private string[] clues = new string[10];

    //To be used in an instance of saving games in 

    public Adventure(string number)
    {
        this.number = number;
        this.currentIndex = 0;
        this.clueIndex = 0;
        this.current = false;
        this.text = new string[]{ "","","","","","","","",""};
        this.clues = new string[] { "", "", "", "", "", "", "", "", "", "" };
        this.full = false;
        this.reset = false;
    }
    public string Number
    {
        get
        {
            return this.number;
        }
        set
        {
            this.number = value;
        }
    }
    public int CurrentIndex
    {
        get
        {
            return this.currentIndex;
        }
        set
        {
            this.currentIndex = value;
        }
    }
    public int ClueIndex
    {
        get
        {
            return this.clueIndex;
        }
        set
        {
            this.clueIndex = value;
        }
    }
    public bool Current
    {
        get
        {
            return this.current;
        }
        set
        {
            this.current = value;
        }
    }
    public bool Reset
    {
        get
        {
            return this.reset;
        }
        set
        {
            this.reset = value;
        }
    }
    public bool Full
    {
        get
        {
            return this.full;
        }
        set
        {
            this.full = value;
        }
    }
    public string[] Text
    {
        get
        {
            return this.text;
        }

        set
        {
            this.text = value;
        }
    } // end public string Name

    public string[] Clues
    {
        get
        {
            return this.clues;
        }
        set
        {
            this.clues = value;
        }
    }// end public string Email

} // end public class Friend