using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof(TerrainMapGenerator))]
public class TerrainMapGeneratorEditor : Editor
{
   //override a button on the TerrainGenerator that can show the map without play mode
   public override void OnInspectorGUI()
   {
      TerrainMapGenerator mapGenerator = (TerrainMapGenerator)target;
      
      // if use autoUpdate,this method will update the map each value change
      if (DrawDefaultInspector())
      {
         if (mapGenerator.autoUpdate)
         {
            mapGenerator.GenerateTerrain();
         }
      }
      
      
      if (GUILayout.Button("GenerateMap"))
      {
         mapGenerator.GenerateTerrain();
      }
      
   }
}
