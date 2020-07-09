using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(track))]
public class TrackEditor : Editor {

    public override void OnInspectorGUI() {
        
        track scipt = target as track;
        if(DrawDefaultInspector()){
            

        }
        if(GUILayout.Button("Generate")){
            scipt.generate();

        }

        
        
    }
}
