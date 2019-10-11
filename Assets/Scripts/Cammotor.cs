using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammotor : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = lookAt.position + startOffset;

        //X
        moveVector.x = 0;
        //Y
        moveVector.y = Mathf.Clamp(moveVector.y, 3, 5); 
        //Z

        transform.position = moveVector;
    }
}
