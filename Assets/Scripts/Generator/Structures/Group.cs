using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Group", menuName = "Generator/Group")]
public class Group : ScriptableObject
{
    
    public List<WeightedTile> tiles = new List<WeightedTile>();

}

public class WeightedTile {
    public Tile tile;
    [Range(0, 100)]
    public uint chance;
}
