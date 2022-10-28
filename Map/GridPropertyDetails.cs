[System.Serializable]
//It holds the information for evry grid in the tilemap
public class GridPropertyDetails
{
    public int gridX;
    public int gridY;
    //The values on the SO_Tilemap
    public bool isDiggable = false;
    public bool canDropItem = false;
    public bool canPlaceFurniture = false;
    public bool isPath = false;
    public bool isNPCObstacle = false;
    //Properties for game play
    public int daysSinceDug = -1;
    public int daysSinceWatered = -1;
    public int seedItemCode = -1;
    public int growthDays = -1;
    public int daysSinceLastHarvest = -1;

    public GridPropertyDetails()
    {
    }
}