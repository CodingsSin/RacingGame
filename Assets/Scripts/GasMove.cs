using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMove : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * 5 * Time.deltaTime);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GameManager.instance.GetGas();
    }
}
