﻿using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    public void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
