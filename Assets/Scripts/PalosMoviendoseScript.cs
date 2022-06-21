using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalosMoviendoseScript : MonoBehaviour
{
    public float zMovementSpeed;
    public float zRightLimit;
    public float zLeftLimit;
    public bool toRight;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
         if (toRight == true)
        {
            transform.position += new Vector3(0, 0, zMovementSpeed);
        }
        else
        {
            transform.position -= new Vector3(0, 0, zMovementSpeed);
        }

        if (transform.position.z > zRightLimit)
        {
            toRight = false;

        }
        else if (transform.position.z < zLeftLimit)
        {
            toRight = true;

        }
    }
}
