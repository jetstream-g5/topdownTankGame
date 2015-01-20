using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject BulletPrefab;
	private Transform Turret;
	private GameObject Nozzle;
	// Use this for initialization
	void Start () {
		Transform[] transforms = GetComponentsInChildren<Transform>();
		foreach (Transform t in transforms) 
		{
			if (t.transform.name == "Turret")
			{
				Turret = t.transform;
			}
			if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t.gameObject;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1"))
		{
			Quaternion rotation = Quaternion.Euler (Vector3.up * Turret.transform.rotation.eulerAngles.y);

			Instantiate(BulletPrefab, Nozzle.transform.position, rotation);
		}
	}
}
