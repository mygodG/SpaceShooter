﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    private void Start()
    {
        this.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
