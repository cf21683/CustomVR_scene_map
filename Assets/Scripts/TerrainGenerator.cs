using UnityEngine;

public class CustomTerrainGenerator : MonoBehaviour
{
    public int width = 256;
    public int height = 256; 
    // public int height = 20; 
    public float scale = 20f;
    
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
        


    }
    
   
}