using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Colorizer : EditorWindow {
	Color color;

	[MenuItem("Window/Colorizer")]
	public static void ShowWindow(){
		GetWindow<Colorizer>("Colorizer");
	}

	void OnGUI(){
		GUILayout.Label("Color Selected Objects!", EditorStyles.boldLabel);
		color = EditorGUILayout.ColorField("Color", color);
		if(GUILayout.Button("COLORIZE!")){
			FuncColorize();
		}
	}

	void FuncColorize(){
		foreach(GameObject obj in Selection.gameObjects){
			Renderer renderer = obj.GetComponent<Renderer>();
			if(renderer != null){
				renderer.sharedMaterial.color = color;
			}
		}
	}


}
