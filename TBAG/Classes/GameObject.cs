using System;

public class GameObject
{

    private String NAME; //name displayed to user, not used for in-code identification of individual objects
    private String DESCRIPTION; //flavor text
    private String IDVALUE; //in-code identifier, unique to each object

    public GameObject(String name, String descrip, String id)
	{
        NAME = name;
        DESCRIPTION = descrip;
        IDVALUE = id;
    }

    public setName(String name)
    {
        NAME = name;
    }

    public setDescription(String description)
    {
        DESCRIPTION = description;
    }
}
