using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;
    private Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(Vector3.forward * speed * Time.deltaTime);
        DestroyObject();
    }
    void DestroyObject()
    {
        if(rigid.transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }
}
