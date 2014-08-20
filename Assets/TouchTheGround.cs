using UnityEngine;
using System.Collections;

public class TouchTheGround : MonoBehaviour  {

    public GameObject Cam;

    void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision entered, checking for collision conditions");
            if (collision.gameObject.name == "RollingBall")
            {
                Debug.Log("Ball recognized,we hit the ground");
                Cam.GetComponent<OnDeathMenu>().IsPlayerDead = true;                
            }
        }


}
