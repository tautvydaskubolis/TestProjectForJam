using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TilemapGenerator;

public class TestScript : MonoBehaviour
{
    public Tilemap tilemap;
    void Start()
    {
        MapGenerator tg = new MapGenerator();
        tg.DrawTiles(tilemap, "Tilemap");
    }
}
