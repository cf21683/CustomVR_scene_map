using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int width = 256;
    public int depth = 256;
    public int height;
    public float scale = 20f;

    public int octaves = 4;
    public float persistance = 0.5f;
    public float lacunarity = 2f;
    
    void Start()
    {
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, height, depth);
        terrainData.SetHeights(0, 0, PerlinNoise.GenerateMap(width, depth, scale, octaves, persistance, lacunarity));
        return terrainData;
    }
}