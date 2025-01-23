using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMove : MonoBehaviour
{
    public Button btnLeft, btnRight;

    void Start()
    {
        btnLeft.onClick.AddListener(MoveLeft);
        btnRight.onClick.AddListener(MoveRight);
    }

    void MoveLeft()
    {
        if (transform.position.x != -1)
        {
            transform.Translate(-1, 0, 0);
        }
    }
    
    void MoveRight()
    {
        if (transform.position.x != 1)
        {
            transform.Translate(1, 0, 0);
        }
    }
}
