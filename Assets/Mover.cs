using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //setting z velocity
    [SerializeField] float yVelocity = 0;
    [SerializeField] float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = Input.GetAxis(axisName: "Horizontal") * speed *Time.deltaTime;
        float zVelocity = Input.GetAxis(axisName: "Vertical") * speed * Time.deltaTime;
        transform.Translate(xVelocity, yVelocity , zVelocity);
    }
}
