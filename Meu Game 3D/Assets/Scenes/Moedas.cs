using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    public int velocidadeGiro = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
}
    
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}
