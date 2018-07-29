using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSoundController : MonoBehaviour {

    public AudioClip audioClip1;
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //ぶつかったときの音
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GROUND"　|| collision.gameObject.tag == "BLOCK")
            {
            audioSource.Play();
        }
    }
}
