using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed* (-1);
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed * (-1);

        transform.Translate(horizontal, 0, vertical);
    }
}
