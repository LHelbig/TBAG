using System;

public class GameObject
{

    public String NAME; //name displayed to user, not used for in-code identification of individual objects
    public String DESCRIPTION; //flavor text
    public String IDVALUE; //in-code identifier, unique to each object


    public GameObject()
    {

    }
    public GameObject(String name, String descrip, String id)
	{
        NAME = name;
        DESCRIPTION = descrip;
        IDVALUE = id;
    }

    public void setName(String name)
    {
        NAME = name;
    }

    public void setDescription(String description)
    {
        DESCRIPTION = description;
    }
}
