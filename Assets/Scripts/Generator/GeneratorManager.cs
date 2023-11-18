using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

public class GeneratorManager : MonoBehaviour
{

    public static GeneratorManager instance;

    public List<Tile> tiles = new List<Tile>();

    public List<Coordinate> coordinates = new List<Coordinate>();

    public int cubeSize = 3;

    void Awake() {

        if (instance) {
            Destroy(this);
        }
        else {
            instance = this;
        }
    }

}

public class Coordinate {
    public Vector3 position;
    public int id;
}