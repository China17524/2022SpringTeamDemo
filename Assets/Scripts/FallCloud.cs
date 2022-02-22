using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCloud : MonoBehaviour
{
    private GameObject setcloud;
    void Start()
    {
        setcloud = GameObject.Find("SetCloud");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("Fall",1);
            
        }
        if(collision.gameObject.CompareTag("Miss"))
        {
            setcloud.GetComponent<FallFloor>().Create();
        }
    }
    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
