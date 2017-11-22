using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public  float speed=15f;
	public float maxWidth=4f;


	public static bool playerCanMove=true;


	Rigidbody2D rb2D;
	BoxCollider2D col;
	float x;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void FixedUpdate () {


			x = Input.GetAxis ("Horizontal") * Time.fixedDeltaTime * speed;

		Vector2 target = this.transform.position + transform.right * x;
		target.x = Mathf.Clamp (target.x, -maxWidth, maxWidth);
		if (playerCanMove)
		rb2D.MovePosition (target);

	}






}
