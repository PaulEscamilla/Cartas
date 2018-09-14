using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Numero : MonoBehaviour {

    public int numero;
    public Material m_1,m_2,m_3;

    // Use this for initialization
    void Start () {
       
        numero = Random.Range(0, 4);

        if (numero == 1)
        {
            gameObject.GetComponent<Renderer>().material = this.m_1;
        }
        if (numero == 2)
        {
            gameObject.GetComponent<Renderer>().material = this.m_2;
        }
        if (numero == 3)
        {
            gameObject.GetComponent<Renderer>().material = this.m_3;
        }

    }

     



    // Update is called once per frame
    void Update () {

       

    }
}
