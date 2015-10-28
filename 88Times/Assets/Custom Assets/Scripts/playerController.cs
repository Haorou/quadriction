using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public int LifePoint = 3;
	public GameObject Left, Middle, Right;
	private int pos = 2 ;
	private Rigidbody RigidPlayer;
	public GameObject debuging;

	// Use this for initialization
	void Start () {
		RigidPlayer = GetComponent<Rigidbody>();
		RigidPlayer.MovePosition (Middle.transform.position);
		pos = 2;
	}

	public void MoveLeft(){
		if (pos > 1) {
			if (pos == 2) {
				RigidPlayer.MovePosition (Left.transform.position);
				pos = 1;
			} else if (pos == 3) {
				RigidPlayer.MovePosition (Middle.transform.position);
				pos = 2;
			}
		}
	}

	public void MoveRight(){
		if (pos < 3){
			if (pos == 1){
				RigidPlayer.MovePosition (Middle.transform.position);
				pos = 2;
			}
			else if (pos == 2){
				RigidPlayer.MovePosition (Right.transform.position);
				pos = 3;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {/*
	 if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			debuging.SetActive (false);
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			if (touchDeltaPosition.x > 0){// tu en etais la 
				this.MoveRight();
			}
			else if (touchDeltaPosition.x < 0) {
				this.MoveLeft();
			}
		}*/

	}
}
