using System;

public class Path
{
    private Boolean NORTH, SOUTH, EAST, WEST;
    private Boolean CURRENT;

    public Path()
    {

    }

    public Path(Boolean north, Boolean south, Boolean east, Boolean west, Boolean current)
    {
        NORTH = north;
        SOUTH = south;
        EAST = east;
        WEST = west;
        CURRENT = current;
    }

    public updateCurrent(Boolean current)
    {
        CURRENT = current;
    }
}
