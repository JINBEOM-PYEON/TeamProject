using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotobject : MonoBehaviour
{
    public float rotSpeed = 100f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));    
    }
}
