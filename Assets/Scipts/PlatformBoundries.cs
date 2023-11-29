using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBoundries : MonoBehaviour
{
    public GameObject[] boundries;
    public float platformSpeed = 3f;

    private int boundryIndex = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(boundries[boundryIndex].transform.position, transform.position) < .1f)
        {
            boundryIndex++;
            if (boundryIndex >= boundries.Length)
            {
                boundryIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, boundries[boundryIndex].transform.position, Time.deltaTime * platformSpeed);
    }
}
