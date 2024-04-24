using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector3 startPosition;
    //public GameObject food;
    
    void Start()
    {
        startPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Debug.Log("Wack");
            transform.position = startPosition;
        }
    }

    //void Update()
    //{
    //    if (gameObject.tag == "floor")
    //    {
    //        transform.position = startPosition;
    //    }
    //}
}
