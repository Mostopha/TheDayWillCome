using UnityEngine;
using System.Collections;

public class DepressionCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        MeshRenderer meshy = gameObject.GetComponent<MeshRenderer>();
        AudioSource sound = gameObject.GetComponent<AudioSource>();
        BoxCollider2D boxy = gameObject.GetComponent<BoxCollider2D>();

        sound.Play();

        Destroy(meshy);
        Destroy(boxy);
        Destroy(gameObject, 3f);
    }
}
