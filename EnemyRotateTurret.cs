using UnityEngine;
using System.Collections;

public class EnemyRotateTurret : BaseRotateTurret {
	public Transform player;
	
	// Update is called once per frame
	override protected void Update () {

        targetPos = player.position + Vector3.up * 0.69f;
		base.Update ();
	}
}
