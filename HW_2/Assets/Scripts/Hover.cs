using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody Bolt_2;
    public float mult;
    public float moveForce;
    public float turnTorque;
    
    void Start()
    {
        Bolt_2 = GetComponent<Rigidbody>();
    }

    public Transform[] anchors = new Transform[4];
    public RaycastHit[] hits = new RaycastHit[4];

    void FixedUpdate()
    {
        for (int i = 0; i < 4; i++)
            ApplyF(anchors[i], hits[i]);

        Bolt_2.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        Bolt_2.AddTorque(Input.GetAxis("Horizontal") * turnTorque * transform.up);

    }

    void ApplyF(Transform anchor, RaycastHit hit)
    {
        if (Physics.Raycast(anchor.position, -anchor.up, out hit))
        {
            float force = 0;
            force = Mathf.Abs(1 / (hit.point.y - anchor.position.y));
            Bolt_2.AddForceAtPosition(transform.up * force * mult, anchor.position, ForceMode.Acceleration);
        }
    }
}