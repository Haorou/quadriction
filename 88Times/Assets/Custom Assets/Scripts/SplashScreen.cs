using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	public GameObject Quadriction;
	public GameObject Gamagora;
	public float SplashTime = 1.0f;
	public float NextSplash = 0.0f;
	private bool AlreadyChanged = false;

	private GameObject Principal;
	private Yggdrasil Yggdrasil;


	// Use this for initialization
	void Start () {
		Principal = GameObject.Find ("Principal");
		Yggdrasil = (Yggdrasil)Principal.GetComponent(typeof(Yggdrasil));

		this.Gamagora.SetActive (false);
		this.Quadriction.SetActive (false);
		this.Gamagora.SetActive (true);
		this.NextSplash = Time.time + SplashTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > NextSplash && !AlreadyChanged) {
			this.Gamagora.SetActive (false);
			this.Quadriction.SetActive (true);
			this.NextSplash = Time.time + SplashTime;
			AlreadyChanged = true;
		} 
		else if ( Time.time > NextSplash && AlreadyChanged){
			Yggdrasil.ChangeScene ("Game");
		}
	}
}
