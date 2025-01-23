using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMove : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * 5 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
