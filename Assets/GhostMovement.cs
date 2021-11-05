using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float increment;

    public Vector2 targetPos;

    public float speed;

    private void Awake()
    {
        targetPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    public void MoveUp()
    {
        targetPos += new Vector2(0, increment);
    }

    public void MoveDown()
    {
        targetPos -= new Vector2(0, increment);
    }
}
