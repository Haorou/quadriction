using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour {
	private bool GameActive = false;
	private float Word_Speed = 10.0f;
	
	public List<GameObject> Obstacles;
	private List<GameObject> ObstacleList;
	
	public GameObject TriggerLeft;
	public GameObject TriggerMiddle;
	public GameObject TroggerRight;
	
	public float AllocDist = 15.0f;
	private float AllocPos = -2.0f;
	
	private bool Left = false;
	private bool Middle = false;
	private bool Right = false;
	
	private float AllocTime = 0.5f;
	private float NextAlloc = 0.0f;
	private int y = 0;
	
	private int RandLine = 0;
	private int RandObstacle = 0;
	
	private Obstacle you;
	
	private int debugCount = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (GameActive) {
			if (!Left && !Middle && !Right && Time.time > NextAlloc+0.5f){
				Debug.Log ("ICI");
				RandLine = (int) Random.Range(1.0f, 3.99f);
				switch (RandLine){
				case 1:
					AllocPos = -2.0f;
					break;
				case 2:
					AllocPos = 0.0f;
					break;
				case 3:
					AllocPos = 2.0f;
					break;
				}
				
				RandObstacle = (int) Random.Range(0.0f, (Obstacles.Count - 0.01f));
				GameObject NewObstacle;
				NewObstacle = Instantiate(Obstacles[RandObstacle], new Vector2(AllocPos,AllocDist), transform.rotation) as GameObject;
				NextAlloc = Time.time + AllocTime;
			}
			
			
		}
	}
	
	public bool GetGamePaused(){
		return(GameActive);
	}
	public void SetGameActive(bool IsActive){
		GameActive = IsActive;
	}
	
	public void SetTriggerOn (string name){
		switch (name) {
		case "Left":
			bool Left = true;
			break;
		case "Middle":
			bool Middle = true;
			break;
		case "Right":
			bool Right = true;
			break;
			
		}
	}
	public void SetTriggerOff (string name){
		switch (name) {
		case "Left":
			bool Left = false;
			break;
		case "Middle":
			bool Middle = false;
			break;
		case "Right":
			bool Right = false;
			break;
			
		}
	}
}
/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour {
	private bool GameActive = true;
	private float Word_Speed = 10.0f;

	public List<GameObject> Obstacles;
	private List<GameObject> ObstacleList;

	public GameObject TriggerLeft;
	public GameObject TriggerMiddle;
	public GameObject TroggerRight;

	public float AllocDist = 15.0f;
	private float AllocPos = -2.0f;

	private bool Left = false;
	private bool Middle = false;
	private bool Right = false;

	private float AllocTime = 0.5f;
	private float NextAlloc = 0.0f;
	private int y = 0;

	private int RandLine = 0;
	private int RandObstacle = 0;

	private Obstacle you;

	private int debugCount = 0;
	// Use this for initialization
	void Start () {
		ObstacleList = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameActive) {
			Debug.Log ("Left " + Left + "Middle " + Middle + "Right " + Right);
			if (!Left && !Middle && !Right && Time.time > NextAlloc+0.5f){
				RandLine = (int) Random.Range(1.0f, 3.99f);
				switch (RandLine){
				case 1:
					AllocPos = -2.0f;
					break;
				case 2:
					AllocPos = 0.0f;
					break;
				case 3:
					AllocPos = 2.0f;
					break;
				}

				RandObstacle = (int) Random.Range(0.0f, (Obstacles.Count - 0.01f));
				GameObject NewObstacle;
				NewObstacle = Instantiate(Obstacles[RandObstacle], new Vector2(AllocPos,AllocDist), transform.rotation) as GameObject;
				ObstacleList.Add(NewObstacle);
				debugCount++;
				NextAlloc = Time.time + AllocTime;
				//print ("Debug " +debugCount + "ObstacleList " + ObstacleList.Count);
			}

			y = ObstacleList.Count;
			for (int i = 0; i < y; i++){
				//print (i);
				ObstacleList[i].transform.Translate(Vector2.down *3.0f * Time.deltaTime, Space.World);
				if (ObstacleList[i].transform.position.y <= -10.0f){
					you = (Obstacle)ObstacleList[i].GetComponent(typeof(Obstacle));
					you.KillYourself();
					ObstacleList.RemoveAt(i);
					debugCount--;
					y--;
				}
			}
		}
	}

	bool GetGamePaused(){
		return(GameActive);
	}
	void SetGamePaused(bool IsActive){
		GameActive = IsActive;
	}
	
	public void SetTriggerOn (string name){
		switch (name) {
		case "Left":
			bool Left = true;
			break;
		case "Middle":
			bool Middle = true;
			break;
		case "Right":
			bool Right = true;
			break;
			
		}
	}
	public void SetTriggerOff (string name){
		switch (name) {
		case "Left":
			bool Left = false;
			break;
		case "Middle":
			bool Middle = false;
			break;
		case "Right":
			bool Right = false;
			break;
			
		}
	}
}*/
