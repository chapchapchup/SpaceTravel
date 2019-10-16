using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    public float planetSpeed;
    public float outScreen = -7;


    void Update()
    {
        transform.position += Vector3.down * planetSpeed * Time.deltaTime;

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        if (pos.y < outScreen)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
