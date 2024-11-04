using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SynchronizedRotation : MonoBehaviour
{
    public Transform _gameObject;
    private float faceY; 
    // Start is called before the first frame update
     
    private void OnDrawGizmos()
    {
        transform.LookAt(_gameObject);

    }
}
