using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainDisplay : MonoBehaviour
{
    public Render textureRender;

    public Display2DMap(float[,] map)
    {
        int width = map.Getlength(0);
        int height = map.Getlength(1);
        
        Texture2D mapTexture = new Texture2D (width, height);

        Color[] colorMap = new Color[width * height];
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++)
            {
                colorMap[y * width + x] = Color.lerp(Color.black, Color.White, map[x, y]);
            }
        }

        mapTexture.SetPixel(colourMap);
        mapTexture.Apply();

        textureRender.sharedMaterial.mainTexture = mapTexture;
        textureRender.transform.localScale = new Vector3(width,1,height);
    }
}
