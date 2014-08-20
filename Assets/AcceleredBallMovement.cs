using UnityEngine;
using System.Collections;

public class AcceleredBallMovement : MonoBehaviour {

    public float BallSpeed = 80.0F;
    public bool debug;
    public GameObject Cam;

	// Use this for initialization
	// Update is called once per frame
	void Update () 
    {
        
        Vector3 dir = Vector3.zero;


    //remap axis to position of the device
        if (debug)
            {
            dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        else
            {
                dir.x = Input.acceleration.x;
                dir.z = Input.acceleration.y;
            }
        

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

    //define moving position per time not per frame

        dir *= Time.deltaTime;

    //add force to the object

        transform.rigidbody.AddForce(dir * BallSpeed);

	}
    
    //save start position of the object 

    private Vector3 startPosition; 
    
    void Start()
        {
            startPosition = this.transform.position;
        }

    //reset position to start

    public void Restart()
        {
            this.transform.position = startPosition;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            Cam.GetComponent<OnDeathMenu>().IsPlayerDead = false;
        }

}
