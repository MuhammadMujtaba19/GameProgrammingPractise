using UnityEngine;
using System.Collections;
using UnityEditor;
 
[CustomEditor(typeof(mapGenerator))]
public class map : Editor
{
 
    public override void OnInspectorGUI()
    {
        mapGenerator map = target as mapGenerator;
        if(DrawDefaultInspector()){
            map.generate();

        }
        if(GUILayout.Button("Generate")){
            map.generate();

        }
 
    }
}

