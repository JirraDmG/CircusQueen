using UnityEngine;
using System.Collections;

public class CameraFollowingBall : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

	// Update is called once per frame
    void Update()
    {
    CameraFollow();
    }

	private void CameraFollow () 
        {
            Vector3 cameraPos = target.position - offset;
            transform.position = cameraPos;
        }
    
}

