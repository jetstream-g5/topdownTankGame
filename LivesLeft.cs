using UnityEngine;
using System.Collections;

public class LivesLeft : MonoBehaviour {

	public int Lives = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		//print("what hit me?" + coll.gameObject.name);
		if(coll.gameObject.name == "Bullet(Clone)")
		{
			Lives --;
			if(Lives <= 0)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
