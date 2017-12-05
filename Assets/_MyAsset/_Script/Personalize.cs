using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Personalize : EditorWindow {

	string myString = "Hello, World!";

	[MenuItem("Window/Example")]
	public static void ShowWindow(){
		GetWindow<Personalize>("Example");
	}

	void OnGUI(){
		GUILayout.Label("This is a Label", EditorStyles.boldLabel);

		myString = EditorGUILayout.TextField("Name", myString);

		if(GUILayout.Button("Press Me")){
			Debug.Log("Button was Pressed");
		}
	}


}
