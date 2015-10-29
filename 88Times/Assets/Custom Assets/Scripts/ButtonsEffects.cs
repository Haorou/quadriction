using UnityEngine;
using System.Collections;

public class ButtonsEffects : MonoBehaviour {

	private GameObject WorldGestion;
	private World WorldController;

	public GameObject Menu;
	// Use this for initialization
	void Start () {
		WorldGestion = GameObject.Find ("WorldGestion");
		WorldController = (World)WorldGestion.GetComponent(typeof(World));
	}

	public void ButtonStart(){
		Menu.SetActive (false);
		WorldController.SetGameActive (true);
	}

	public void ButtonCredit(){
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
