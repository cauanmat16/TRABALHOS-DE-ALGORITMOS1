using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public int velociade = 10;
    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" start ");
        TryGetComponent( out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("  update ");
    }
}
