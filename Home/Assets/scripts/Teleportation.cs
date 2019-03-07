using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {
    public float x;
    public float y;
    public float z;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
            other.transform.position = new Vector3(x, y, z);

    }
}
