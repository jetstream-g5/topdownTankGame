using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour
{
    private float reloadTime;
    public float timeToReload;
    public GameObject bulletPrefab;
    public float ShootingRange;
    private Transform turret;
    private Transform nozzle;
    // Use this for initialization
    void Start()
    {
        reloadTime = 0;

        Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {

            print("found" + t.gameObject.name);
            if (t.gameObject.name == "Turret")
            {
                turret = t;
            }
            if (t.gameObject.name == "Nozzle")
            {
                nozzle = t;

                print("found nozzle");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        reloadTime += Time.deltaTime;
        if (reloadTime >= timeToReload)
        {
            CheckForPlayer();
        }
    }
    private void CheckForPlayer()
    {
        Ray myRay = new Ray();
        myRay.origin = turret.position;
        myRay.direction = turret.forward;

        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo, ShootingRange))
        {
            string hitObject = hitInfo.collider.gameObject.name;

            if (hitObject == "Tank")
            {

                print("bullet!!!!");
                Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);

                reloadTime = 0f;
            }
        }


    }
}