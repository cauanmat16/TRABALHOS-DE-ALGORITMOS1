using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public int velocidade = 10;
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
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 direção = new Vector3(x, y: 0, z: y);
        rb.AddForce(direção * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
