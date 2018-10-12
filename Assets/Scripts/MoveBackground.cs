using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Screen.width);
        if (transform.position.x < -6.33f)
        {
            transform.position = new Vector3(6.27f, transform.position.y, transform.position.z);
        }
    }
}
