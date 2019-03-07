using UnityEngine;

public class BeachTeleportataion : MonoBehaviour {

    public float x;
    public float y;
    public float z;
    public Animator cam1;
    public Animator cam2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
            other.transform.position = new Vector3(x, y, z);
        cam2.SetBool("tel", true);
        cam1.SetBool("trans", true);
        
    }
}
