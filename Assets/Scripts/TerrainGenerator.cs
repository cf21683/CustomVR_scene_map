using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour
{
    public int width = 256;
    public int height = 256; 
    public float scale = 20f;

    public int octaves;
    public float persistence;
    public float lacumarity;
    
    public bool autoUpdate;

   
    public void GenerateTerrain()
    {
        float[,] perlinMap = PerlinNoise.GenerateMap(width, height, scale,octaves,persistence,lacumarity);
        
        TerrainDisplay display = FindObjectOfType<TerrainDisplay>();
        display.Display2DMap(perlinMap);


    }
    
   
}