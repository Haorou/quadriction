using UnityEngine;
using System.Collections;

public class TriggerTest : MonoBehaviour {
	public string NameObj;

	private GameObject WorldGestion;
	private World WorldScript;

	// Use this for initialization
	void Start () {

		WorldGestion = GameObject.Find ("WorldGestion");
		WorldScript = (World)WorldGestion.GetComponent(typeof(World));
	}
	void OnTriggerEnter(Collider col) {
		Debug.Log ("JeFaitMonTaf");
		WorldScript.SetTriggerOn (NameObj);
	}
	void OnTriggerExit() {
		Debug.Log ("JeFaitMonTaf");
		WorldScript.SetTriggerOff (NameObj);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
