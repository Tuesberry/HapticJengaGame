using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaController : MonoBehaviour
{
    //public float speed = 3f;
    // Start is called before the first frame update
    void Awake()
    {

    }

    public void FeedVector(Vector3 inputVector)
    {

        transform.rotation = Quaternion.Euler(inputVector);
        //transform.Rotate(Vector3.up * speed);// = inputVector;// Quaternion.Euler(inputVector);
        //Debug.Log(transform.rotation); 
        //Debug.Log(inputVector); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
