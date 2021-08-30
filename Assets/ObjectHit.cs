using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("oh sht, u hit the wall");
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
