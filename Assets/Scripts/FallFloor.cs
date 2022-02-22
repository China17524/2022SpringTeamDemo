using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    [SerializeField]private GameObject obj;
    [SerializeField]private Vector3 pos = new Vector3(206.18f, 16.7f, 2.3f);

    void Start()
    {
        GameObject obj1 =Instantiate (obj, pos, Quaternion.identity);
        obj1.transform.parent = this.transform;
    }

    public void Create()
    {
        foreach(Transform child in gameObject.transform){
            Destroy(child.gameObject);
        }
        GameObject obj1 = Instantiate (obj, pos, Quaternion.identity);
        obj1.transform.parent = this.transform;
    }
}
