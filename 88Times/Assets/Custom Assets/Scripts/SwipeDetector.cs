using UnityEngine;
using System.Collections;

public class SwipeDetector : MonoBehaviour {
	private bool GameActive = false;
	public GameObject debuging;
	private GameObject Player;
	private playerController ScriptController;
	
	public float minSwipeDistY;
	
	public float minSwipeDistX;
	
	public float speed = 10f;
	
	private Vector2 startPos;
	
	private bool left = false;
	
	private bool right = false;


	public bool GetGamePaused(){
		return(GameActive);
	}
	public void SetGameActive(bool IsActive){
		GameActive = IsActive;
	}


	void Start(){
		Player = GameObject.Find ("player");
		ScriptController = (playerController)Player.GetComponent(typeof(playerController));
		
	}
	void Update()
	{
		if (GameActive) {
		
			//#if UNITY_ANDROID
			if (Input.touchCount > 0) {
			
				Touch touch = Input.touches [0];
			
			
			
				switch (touch.phase) {
				
				case TouchPhase.Began:
				
					startPos = touch.position;
					Debug.Log (startPos);
				
					break;
				
				
				
				case TouchPhase.Ended:
				
				
					float swipeDistVertical = (new Vector3 (0, touch.position.y, 0) - new Vector3 (0, startPos.y, 0)).magnitude;
				
					if (swipeDistVertical > minSwipeDistY) {
					
						float swipeValue = Mathf.Sign (touch.position.y - startPos.y);
					
						if (swipeValue > 0) {//up swipe
						
							//Jump ();
						} else if (swipeValue < 0) {//down swipe
						
							//Shrink ();
						}
					
					}
				
					float swipeDistHorizontal = (new Vector3 (touch.position.x, 0, 0) - new Vector3 (startPos.x, 0, 0)).magnitude;
				
					if (swipeDistHorizontal > minSwipeDistX) {
					
						float swipeValue = Mathf.Sign (touch.position.x - startPos.x);
					
						if (swipeValue > 0) {//right swipe
							right = true;
						} else if (swipeValue < 0) {//left swipe
							left = true;
						}
					}
					break;
				}
			}
		
			if (left)
				left = ScriptController.MoveLeft ();//return false si la position est atteint
		else if (right)
				right = ScriptController.MoveRight ();

			if (ScriptController.LifePoint==0f)
				GameActive = false;
		}
	}
}

