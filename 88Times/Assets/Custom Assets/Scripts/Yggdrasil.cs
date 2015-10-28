using UnityEngine;
using System.Collections;

public class Yggdrasil : MonoBehaviour {

	private string Actual_Scene = "Start";
	void Awake() {
		DontDestroyOnLoad(this.gameObject);
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("Yggdrasil Start");
		Actual_Scene = "SplashScreen";
		Application.LoadLevel (Actual_Scene);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ChangeScene(string Scene){
		Debug.Log ("Try to Load Scene : " + Scene);
		Actual_Scene = Scene;
		Application.LoadLevel (Actual_Scene);
	}
}
