using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoVRotation : MonoBehaviour
{
    [SerializeField] private float angle;
    [SerializeField] private float increment;
    private Quaternion maxAngle = new Quaternion();
    private Quaternion minAngle = new Quaternion();

    void Awake()
    {
        maxAngle = Quaternion.Euler(0, 0, 75);
        minAngle = Quaternion.Euler(0, 0, -75);
    }

    void Start()
    {
        InvokeRepeating("Rotate", 0, increment);
    }

    private void Rotate()
    {
        
        transform.Rotate(0, 0, angle);

        if(transform.rotation == maxAngle || transform.rotation == minAngle)
        {
            angle *= -1;
        }
    }
}
