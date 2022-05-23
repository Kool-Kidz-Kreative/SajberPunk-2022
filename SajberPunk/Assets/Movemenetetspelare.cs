using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemenetetspelare : MonoBehaviour
{
    public int IShowSpeed;
    Rigidbody SpelareRB;
    // Start is called before the first frame update
    void Start()
    {
        SpelareRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            SpelareRB.drag = 0;
            SpelareRB.velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * IShowSpeed;
        }
    }
}
