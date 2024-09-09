 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public int velocidade = 10;
    public int ForcaPulo = 10;
    public bool noChao = false;

    private Rigidbody rb;
    private AudioSource source;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" start ");
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chão")
        {
            noChao = true;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("  update ");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direção = new Vector3(x, y: 0, z: y);
        rb.AddForce(direção * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            //pulo 
            source.Play();
            rb.AddForce(Vector3.up * ForcaPulo, ForceMode.Impulse);
        }

        if (transform.position.y < -5)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}



