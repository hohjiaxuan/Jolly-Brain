using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wpointLV2 : MonoBehaviour
{
    [SerializeField] private GameObject[] wpoints;
    private int currentwpointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(wpoints[currentwpointIndex].transform.position, transform.position) < .1f)
        {
            currentwpointIndex++;
            if (currentwpointIndex >= wpoints.Length)
            {
                currentwpointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wpoints[currentwpointIndex].transform.position, Time.deltaTime * speed);
    }
}
