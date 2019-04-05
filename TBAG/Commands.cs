using System;
using System.Collections;


public class Commands
{
    public String Inventory(object Item) {//inventory class
                                          //need to implement class for inventory that takes the Item object and stores it to inventory.
        ArrayList invList = new ArrayList();
        invList.Add("TEST1");
        invList.add("TEST2");
        invList.Add("TEST3");
        invList.Add(1);
        invList.Add(3);
        foreach (Object obj in invList)
            Form2.storyText.AppendText(obj);

    }

    public void North()
{

}

    public void South()
{

}

public void East()
{

}

public void West()
{

}
}

}