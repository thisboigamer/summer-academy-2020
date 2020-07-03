using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    private void Update()
    {
        rb.AddForce (0, 0, -2000 * Time.deltaTime);
    }
}
