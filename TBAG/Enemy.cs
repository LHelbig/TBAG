using System;

public class Enemy: NPC
{

    private double HEALTH;
    private double ATTACK;

    public Enemy()
	{
	}

    //used for healing and taking damage, depending on wether difference is positive or negative
    public updateHealth(double difference)
    {
        HEALTH += difference;
    }

    public attack()
    {

    }

}
