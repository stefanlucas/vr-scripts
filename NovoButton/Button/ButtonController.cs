using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    private Animator anim;
    private Color initialColor;
    private Material m;
    // change material
    public GameObject instant;
    public Material material0;
    public Material material1;
    public Material material2;
    public Material material3;
    Renderer rend;
    public Transform pos;
    private int caso;
    //
    public float range;
    public GameObject player; // colocar a mão do player em vez de fallback object quando for testar com os controles

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        m = GetComponent<Renderer>().material;
        initialColor = m.color;
        // change material
        
        rend = instant.GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = material0;
        caso = 1;
        //Instantiate(instant, pos.position, Quaternion.identity);
        //
    }
	
	// Update is called once per frame
	void Update () {
        Transform other = player.GetComponent<Transform>();
        float dist = Vector3.Distance(other.position, transform.position);
        //Debug.Log("Distância = " + dist + " posição player=" + other.position + " posição botão=" + transform.position);

        if (dist < range) {
            m.color = Color.green;
            if (Input.GetButtonDown("Fire1")) { // mudar para o input dos controles de realidade virtual 
                anim.SetTrigger("Clicked");
                // change material
                if (caso == 1)
                {
                    rend.material = material1;
                    caso = caso + 1;
                    Debug.Log("Caso 1");
                }
                else if (caso == 2)
                {
                    rend.material = material2;
                    caso = caso + 1;
                    Debug.Log("Caso 2");
                }
                else
                {
                    rend.material = material3;
                    Debug.Log("Caso 3");
                }
                //
            }
        }
        else {
            m.color = initialColor;
        }
	}

}
