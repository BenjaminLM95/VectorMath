using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class TestVectors : MonoBehaviour
{
    public Transform otherObject;


    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 targetPosition = new Vector3(otherObject.position.x, transform.position.y, otherObject.position.z);
        transform.LookAt(targetPosition);
    }

    private void OnDrawGizmos()
    {
        //Gizmos().DrawLine(Vector.zero, transform.position.normalized);
        /*Vector3 directionTo = (transform.position - otherObject.transform.position);
        otherObject.transform.position = directionTo; */
        Vector3 targetPosition = new Vector3(otherObject.position.x, transform.position.y, otherObject.position.z);
        transform.LookAt(targetPosition);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero, (transform.position - otherObject.transform.position));
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, (otherObject.transform.position - transform.position));

    }

    public void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 600, 50), $"Vector {transform.position} Magnitude {transform.position.magnitude} Normalized {transform.position.normalized} Magnitude {transform.position.normalized.magnitude} ");

    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
