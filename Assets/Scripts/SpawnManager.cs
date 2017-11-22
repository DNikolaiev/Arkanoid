using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject[] spawnPoints;
	public GameObject whiteBlock;
	private int randomColor;
	public GameObject redBlock;
	public GameObject blueBlock;
	public GameObject greenBlock;
	public GameObject yellowBlock;
	public GameObject magentaBlock;
	public GameObject orangeBlock;
	public GameObject ball;
	public static SpawnManager instance=null;


	public int count=0;
	private int randomIndex;
	private GameObject spawnobj;

	void Awake()
	{
		if (instance == null)
		{
			instance=this;
		} 
		else  if (instance!=this)
		{
			Destroy (gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		whiteBlock.GetComponent<GameObject> ();
		Spawn ();

	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.exictBall) {
			Instantiate(ball,new Vector2(0f,1f),Quaternion.identity);
			GameManager.instance.exictBall=true;


		}


	}

	private void Spawn()
	{
		

		int objectsToSpawn=Random.Range(0,11);
		for (int i=0;i<spawnPoints.Length;i++)
		{

			randomIndex=Random.Range(0,2);
			if (randomIndex==0&&count<=objectsToSpawn)
			{
				count++;
			}
			else  {

			randomColor=Random.Range(1,8);
			if (randomColor==1)
			spawnobj=whiteBlock;
			else if (randomColor==2)
				spawnobj=redBlock;
			else if (randomColor==3)
				spawnobj=blueBlock;
			else if (randomColor==4)
				spawnobj=greenBlock;
			else if (randomColor==5)
				spawnobj=yellowBlock;
			else if (randomColor==6)
				spawnobj=magentaBlock;
			else if (randomColor==7)
				spawnobj=orangeBlock;
			Instantiate(spawnobj,spawnPoints[i].transform.position,Quaternion.identity);

			}

		}





	}






}
