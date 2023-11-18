using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Structure", menuName = "Generator/Structure")]
public class Structure : ScriptableObject
{

    public List<StructureTile> tiles = new List<StructureTile>();

}

public class StructureTile {
    public Tile tile;
    public List<DirectedConnection> connections = new List<DirectedConnection>();
}

public class DirectedConnection {
    public Vector3 direction;
    public Tile tile;
}
