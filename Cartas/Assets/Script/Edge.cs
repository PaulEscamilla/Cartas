using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour {

    public Material m_edge;

    // Use this for initialization
    void Start () {
		
	}

    protected void DrawEdge() {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, .03f);
        go.transform.GetComponent<Renderer>().material = this.m_edge;

        go.transform.localScale = new Vector3(2.5f, 3.5f, .01f);

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    private void OnMouseDown()
    {
        this.DrawEdge();
    }
}
