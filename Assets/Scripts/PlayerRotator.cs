using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 lookPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(lookPosition);
        }
        Debug.DrawRay(ray.origin, ray.direction*100, Color.green);
    }
}
