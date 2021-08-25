using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xVelocity = 0;
    [SerializeField] float yVelocity = 0.01f;
    [SerializeField] float zVelocity = 0;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xVelocity, yVelocity, zVelocity);
    }
}
