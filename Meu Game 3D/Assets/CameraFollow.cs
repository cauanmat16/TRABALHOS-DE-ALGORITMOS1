using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _alvo;
    public int suavidade = 5;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        _alvo = GameObject.FindWithTag("Player").transform;
        offset = _alvo.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posFinal = _alvo.position - offset;
        transform.position = Vector3.Lerp(transform.position, posFinal, suavidade * Time.deltaTime);
    }
}
