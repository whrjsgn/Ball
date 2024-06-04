using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.name=="Cube")
            rigid.AddForce(Vector3.up*2, ForceMode.Impulse);
    }
}
