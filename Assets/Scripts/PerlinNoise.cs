using UnityEngine;
using System.Collections;

public static class PerlinNoise
{
    public static float[,] GenerateMap(int width, int height,float scale)
    {
        float[,] map = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float xCoord = x / scale;
                float yCoord = y / scale;
                float perlin = Mathf.PerlinNoise(xCoord, yCoord);
            
                
                // if (height > 0.4f && height < 0.6f)
                // {
                //     height = 0.5f; 
                // }
            
                map[x, y] = perlin;
            }
        }
        return map;
    }
}