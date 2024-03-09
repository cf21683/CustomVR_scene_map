using UnityEngine;

public class CustomTerrainGenerator : MonoBehaviour
{
    public int width = 256;
    public int depth = 256; 
    public int height = 20; 
    public float scale = 20;
    

    void Start()
    {
        Terrain terrain = GetComponent<Terrain>();
        if (terrain != null)
        {
            
            terrain.terrainData = GenerateTerrain(terrain.terrainData);
        }
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, height, depth);
        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }
    
    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, depth];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < depth; y++)
            {
                float xCoord = x / (float)width * scale;
                float yCoord = y / (float)depth * scale;
                float height = Mathf.PerlinNoise(xCoord, yCoord);
            
                
                if (height > 0.4f && height < 0.6f)
                {
                    height = 0.5f; 
                }
            
                heights[x, y] = height;
            }
        }
        return heights;
    }
}