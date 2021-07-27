using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TheSkyIsFalling : MonoBehaviour
{
    public UnityEvent dealCubeDamage = new UnityEvent();
    public Rigidbody Sphere;
    public Vector3 startingPosition = new Vector3(0, 5, 0);
    public float cubeHealth = 100;
    private void OnTriggerEnter(Collider Sphere)
    {

    }

    void FallingSky(float SphereDamage)
    {
        cubeHealth -= SphereDamage;
        Sphere.transform.position = startingPosition;
        Sphere.velocity = new Vector3(0,0,0);
        print(cubeHealth);

        if (cubeHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        dealCubeDamage.AddListener(FallingSky);
    }
    void OnDisable()
    {
        dealCubeDamage.RemoveListener(FallingSky);
    }
}
