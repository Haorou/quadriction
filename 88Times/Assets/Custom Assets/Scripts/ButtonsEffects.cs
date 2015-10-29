using UnityEngine;
using System.Collections;

public class ButtonsEffects : MonoBehaviour {

	private GameObject WorldGestion;
	private World WorldController;
	private GameObject TouchDetector;
	private SwipeDetector SwipeScript;
	private GameObject Player;
	private playerController playerScript;

	public GameObject Menu;
	public GameObject MenuRetry;

	// Use this for initialization
	void Start () {
		WorldGestion = GameObject.Find ("WorldGestion");
		WorldController = (World)WorldGestion.GetComponent(typeof(World));
		TouchDetector = GameObject.Find ("TouchDetector");
		SwipeScript = (SwipeDetector)TouchDetector.GetComponent(typeof(SwipeDetector));
		Player = GameObject.Find ("player");
		playerScript = (playerController)Player.GetComponent(typeof(playerController));

	}

	public void ButtonStart(){
		Menu.SetActive (false);
		MenuRetry.SetActive(false);
		WorldController.SetGameActive (true);
		SwipeScript.SetGameActive (true);
		playerScript.LifePoint = 3;
	}

	public void ButtonCredit(){
		
	}
	// Update is called once per frame
	void Update () {
		if (playerScript.LifePoint == 0f) {
			WorldController.SetGameActive (false);
			SwipeScript.SetGameActive (false);
			MenuRetry.SetActive(true);
		}
	}
}
