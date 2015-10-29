using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	public float DimY = 10.0f;
	public float speed = 5f;
	private Rigidbody2D rigid;
	private Vector2 dest;
	//public float DimX = 10.0f;
	
	
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		dest = rigid.position;
		dest.Set (dest.x, dest.y - 30f);
	}
	
	// Update is called once per frame
	void Update () {
		rigid.transform.position = Vector2.MoveTowards (rigid.position, dest, speed);
		if (rigid.position == dest)
			Destroy(this.gameObject);
	}
}

/*
using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public float DimY = 10.0f;
	//public float DimX = 10.0f;
	

	// Use this for initialization
	void Start () {
	
	}
	public void KillYourself(){
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
*/