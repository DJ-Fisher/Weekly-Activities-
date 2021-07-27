using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week9 : MonoBehaviour
{
    public Rigidbody FallingSphere;
    private Vector3 RandomLocation;

    // Start is called before the first frame update
    void Start()
    {
        RandomLocation = new Vector3(Random.Range(0, 51), Random.Range(0, 51), Random.Range(0, 51));
    }

    private void OnTriggerEnter(Collider other)
    {
        FallingSphere.transform.position = (RandomLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
