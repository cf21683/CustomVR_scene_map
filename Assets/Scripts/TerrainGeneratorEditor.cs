using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof(TerrainGenerator))]
public class TerrainGeneratorEditor : Editor
{
   //override a button on the TerrainGenerator that can show the map without play mode
   public override void OnInspectorGUI()
   {
      TerrainGenerator mapGenerator = (TerrainGenerator)target;
      
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
