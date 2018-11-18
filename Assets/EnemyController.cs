using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody rb;

    public float beginning;
    public float end;

    Vector3 start;
    Vector3 speed = new Vector3(0, 0, -10);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = new Vector3(transform.position.x, 0.5f, beginning);
    }

    void Update () {

        rb.velocity = speed;

        if(transform.position.z <= end)
        {
            transform.position = start;
        }
	}
}
