using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    public GameObject instant;
    public Material[] material;
    public Transform pos;
    Renderer rend;
    private int caso;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        caso = 1;
        Instantiate(instant, pos.position, Quaternion.Euler(0, 180, 41));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            if(caso == 1)
            {
                rend.sharedMaterial = material[1];
                caso = caso + 1;
                Debug.Log("Caso 1");
            } else if (caso == 2)
            {
                rend.sharedMaterial = material[2];
                caso = caso + 1;
                Debug.Log("Caso 2");
            } else
            {
                rend.sharedMaterial = material[3];
                Debug.Log("Caso 3");
            }
        }
	}
}
