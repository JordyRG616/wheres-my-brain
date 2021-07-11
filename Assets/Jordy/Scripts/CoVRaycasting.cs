using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoVRaycasting : MonoBehaviour
{
    [SerializeField] private Transform[] directions;

    void Awake()
    {
        
    }

    void Update()
    {
        CastRays();
    }

    private void CastRays()
    {
        foreach(Transform direction in directions)
        {
            Debug.DrawLine(transform.position, direction.position, Color.magenta, .1f);

            Vector3 difference = direction.position - this.transform.position;

            RaycastHit2D hit = Physics2D.Raycast(this.transform.position, difference, difference.magnitude);

            if(hit == true && hit.transform.CompareTag("Player"))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }

    

   

}
