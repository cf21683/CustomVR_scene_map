using UnityEngine;
using System.Collections;

public static class PerlinNoise
{
    //generate the perlin noise to create2D map
    public static float[,] GenerateMap(int width, int height,float scale,int octaves, float persistance, float lacumarity)
    {
        float[,] map = new float[width, height];
        float MaxNoiseValue = float.MinValue;
        float MinNoiseValue = float.MaxValue;
        if (scale < 0)
        {
            scale = 0.00001f;
        }
        
        
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float amplitude = 1;
                float frequency = 1;
                float noiseValue = 0;
                
                //more octavues mean superimpose multiple Perlin noises of different frequencies and amplitudes
                for (int i = 0; i < octaves; i++)
                {
                    float xCoord = x / scale * frequency;
                    float yCoord = y / scale * frequency;
                    
                    // allow get the negative perlin value
                    float perlin = Mathf.PerlinNoise(xCoord, yCoord) * 2 -1;
                    noiseValue = perlin * amplitude + noiseValue;

                    amplitude = amplitude * persistance;
                    frequency = frequency * lacumarity;
                    

                }
                
                //get the maximum perlin value and minnimun perlin value
                if (noiseValue > MaxNoiseValue)
                {
                    MaxNoiseValue = noiseValue;
                }else if (noiseValue < MinNoiseValue)
                {
                    MinNoiseValue = noiseValue;
                }

                map[x, y] = noiseValue;
            }
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // normalize the noise value, the value close to Min value becomes 0 and the value close to Max value becomes 1
                map[x, y] = Mathf.InverseLerp(MinNoiseValue, MaxNoiseValue, map[x, y]);
            }
        }

        return map;
    }
}