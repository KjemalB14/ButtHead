using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationalSpeed = 2f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, 360 * rotationalSpeed * Time.deltaTime);
    }
}
