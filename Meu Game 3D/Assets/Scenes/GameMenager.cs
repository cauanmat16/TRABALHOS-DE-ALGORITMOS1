using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;

    public int restantes;

    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moedas>().Length;
        hud.text = $"Moeda restante: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes}";

        if (restantes <= 0)
        {
            //ganhou o jogo 
            msgVitoria.text = "Parabéns!";
            source.PlayOneShot(clipVitoria);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}




