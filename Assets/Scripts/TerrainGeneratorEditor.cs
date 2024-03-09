using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof(TerrainGenerator))]
public class TerrainGeneratorEditor : Editor
{
   public override void OnInspectorGUI()
   {
      TerrainGenerator mapGenerator = (TerrainGenerator)target;

      DrawDefaultInspector();

      if (GUILayout.Button("GenerateMap"))
      {
         mapGenerator.GenerateTerrain();
      }
   }
}
