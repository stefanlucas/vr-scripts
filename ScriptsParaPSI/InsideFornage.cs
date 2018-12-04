using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideFornage : MonoBehaviour {

    public AudioClip music;
    public AudioSource src;

	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "peca")
        {
            src.Play();
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void Start()
    {
        src.clip = music;
    }
}
