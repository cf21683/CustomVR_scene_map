using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour
{
    public int width = 256;
    public int height = 256; 
    public float scale = 20f;
    
    public bool autoUpdate;
    
    // public TerrainLayer grassLayer;
    // public TerrainLayer dirtLayer;
    

    void Start()
    {
        // Terrain terrain = GetComponent<Terrain>();
        // if (terrain != null)
        // {
        //     
        //     terrain.terrainData = GenerateTerrain(terrain.terrainData);
        // }
    }

    // TerrainData GenerateTerrain(TerrainData terrainData)
    public void GenerateTerrain()
    {
        // terrainData.terrainLayers = new TerrainLayer[] { grassLayer, dirtLayer };
        // terrainData.heightmapResolution = width + 1;
        // terrainData.size = new Vector3(width, height, depth);
        // terrainData.SetHeights(0, 0, GenerateHeights());
        // return terrainData;
        float[,] perlinMap = PerlinNoise.GenerateMap(width, height, scale);
        
        TerrainDisplay display = FindObjectOfType<TerrainDisplay>();
        display.Display2DMap(perlinMap);


    }
    
   
}