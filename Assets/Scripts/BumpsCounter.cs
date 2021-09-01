using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpsCounter : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You bumped into " + hits + " objects");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
