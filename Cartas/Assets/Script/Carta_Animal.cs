using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta_Animal : MonoBehaviour {

    // Use this for initialization

    public int numero_a;
    public Material m_c, m_d, m_m;

    // Use this for initialization
    void Start()
    {
        
        if (numero_a == 1)
        {
            gameObject.GetComponent<Renderer>().material = this.m_c;

        }
        if (numero_a == 2)
        {
            gameObject.GetComponent<Renderer>().material = this.m_d;
        }
        if (numero_a == 3)
        {
            gameObject.GetComponent<Renderer>().material = this.m_m;
        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}