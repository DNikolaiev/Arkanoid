using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float initialVelocity=575f;
	public Rigidbody2D rb2D;
	public float speed=8;
	private bool ballInGame;
	public GameObject ball;
	public SpawnManager spawnMngr;


	// Use this for initialization
	void Start () {
		ballInGame = false;
		rb2D.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.Space)&&ballInGame==false)
		{
			Vector2 bounce=new Vector2(150f,initialVelocity);
			ballInGame=true;
			rb2D.isKinematic=false;
			rb2D.AddForce(bounce,ForceMode2D.Force);
		}


	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Vector2 velX = new Vector2 (rb2D.velocity.x, rb2D.velocity.y);
		if (other.collider.tag == "Player") {
			velX.x = this.rb2D.velocity.x / 2 + other.rigidbody.velocity.x / 3;
			rb2D.velocity = velX;

			float x=hitFactor(transform.position,other.transform.position, other.collider.bounds.size.x);
			Vector2 dir=new Vector2(x,1);
			rb2D.velocity=dir*speed;
		}

		else if(other.collider.tag=="Wall")
		{
			Destroy(this.gameObject);
			GameManager.instance.LoseLife();
			GameManager.instance.exictBall=false;

		}

		else if (other.collider.tag=="block")
		{
			GameManager.instance.score++;

		}


	}

	float hitFactor(Vector2 ballPos,Vector2 playerPos, float width)
	{
		return (ballPos.x-playerPos.x)/width;
	}

}
