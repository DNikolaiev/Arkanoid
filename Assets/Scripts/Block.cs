using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public  SpriteRenderer spren;
	public static Block instance=null;

	void Start()
	{
		spren.GetComponent<SpriteRenderer> ();

	}
	void Awake()
	{
		if (instance == null)
		{
			instance=this;
		} 

	}


	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag=="Ball")
		{
			Destroy (this.gameObject);
            GameManager.instance.CheckForWin();
		}
	}

	// Use this for initialization

	
	// Update is called once per frame

}
