using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : ScriptableObject
{
    
    public GameObject obj;
    public List<Connector> properties = new List<Connector>();

}

public class Connector {
    public Vector3 direction;
    public Group group;
}
