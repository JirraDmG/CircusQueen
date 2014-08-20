using UnityEngine;
using System.Collections;

public class SpotlightOverBall : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SpotlightFollow();
    }

    private void SpotlightFollow()
    {
        Vector3 spotlightPos = target.position - offset;
        transform.position = spotlightPos;
    }
    
}
