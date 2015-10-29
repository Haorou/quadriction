using UnityEngine;
using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	public int LifePoint = 3;
	public GameObject Left, Middle, Right;
	private int pos = 2 ;
	private Rigidbody RigidPlayer;
	public GameObject debuging;
	private float speed = 0.5f;
	
	// Use this for initialization
	void Start () {
		RigidPlayer = GetComponent<Rigidbody>();
		RigidPlayer.MovePosition (Middle.transform.position);
		pos = 2;
	}
	
	public bool MoveLeft(){
		Vector3 dest = Vector3.zero;
		Vector3 curr = RigidPlayer.position;
		
		if (pos > 1) {
			{
				if (pos == 2) {
					dest = Left.transform.position;
				} else if (pos == 3) {
					dest = Middle.transform.position;
				}
			}
			if (curr == dest) {
				if (dest == Left.transform.position)
					pos = 1;
				else if (dest == Middle.transform.position)
					pos = 2;
				return false;
			} else 
				RigidPlayer.position = Vector3.MoveTowards (curr, dest, speed);
		} else if (pos == 1)
			return false;

		return true;
	}
	
	
	public bool MoveRight(){
		Vector3 dest = Vector3.zero;
		Vector3 curr = RigidPlayer.position;
		
		if (pos < 3) {
			{
				if (pos == 2) {
					dest = Right.transform.position;
				} else if (pos == 1) {
					dest = Middle.transform.position;
				}
			}
			if (curr == dest) {
				if (dest == Right.transform.position)
					pos = 3;
				else if (dest == Middle.transform.position)
					pos = 2;
				return false;
			} else 
				RigidPlayer.position = Vector3.MoveTowards (curr, dest, speed);
		} else if (pos == 3)
			return false;
		return true;
	}

	void OnTriggerEnter(Collider other){
		LifePoint--;
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
