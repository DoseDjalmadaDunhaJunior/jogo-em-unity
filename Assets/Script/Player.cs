using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEndine.AI;

public class Player : MonoBehaviour
{
    public int vida;
    public float velocidade;
    public bool voando;
    public string nome;
    public float tempo;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        //verificaVelocidade();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            verificaVelocidade();
        }
    }
    void verificaVelocidade()
    {
        velocidade = distancia / tempo;
        Debug.Log("sua velocidade é: " + velocidade);
        if (velocidade < 40 || velocidade > 70)
        {
            Debug.Log("voce esta trapaceando gay");
        }
        else
        {
            Debug.Log("se fode ai");
        }
    }
}
