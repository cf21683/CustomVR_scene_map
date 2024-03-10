using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainDisplay : MonoBehaviour
{
    public Renderer textureRender;
    
    // apply the color of the map texture
    public void Display2DMap(float[,] map)
    {
        int width = map.GetLength(0);
        int height = map.GetLength(1);
        
        Texture2D mapTexture = new Texture2D (width, height);

        Color[] colorMap = new Color[width * height];
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++)
            {
                // 0 mean black, 1 mean white, and lerp method gives normalized grayscale values
                colorMap[y * width + x] = Color.Lerp(Color.black, Color.white, map[x, y]);
            }
        }

        mapTexture.SetPixels(colorMap);
        mapTexture.Apply();

        textureRender.sharedMaterial.mainTexture = mapTexture;
        textureRender.transform.localScale = new Vector3(width,1,height);
    }
}
