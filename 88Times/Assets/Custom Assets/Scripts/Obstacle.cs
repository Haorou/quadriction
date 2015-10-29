using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	public float DimY = 10.0f;
	public float speed = 5f;
	private Rigidbody rigid;
	private Vector3 dest;
	//public float DimX = 10.0f;
	
	
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		dest = rigid.position;
		dest.Set (dest.x, dest.y - 30f, dest.z);
	}
	
	// Update is called once per frame
	void Update () {
		rigid.transform.position = Vector2.MoveTowards (rigid.position, dest, speed * Time.deltaTime);
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