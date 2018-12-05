using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    private Animator anim;
    private Color initialColor;
    private Material m;

    public float range;
    public GameObject player; // colocar a mão do player em vez de fallback object quando for testar com os controles

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        m = GetComponent<Renderer>().material;
        initialColor = m.color;
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
            }
        }
        else {
            m.color = initialColor;
        }
	}

}
