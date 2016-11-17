using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class dimLight : MonoBehaviour {

    public GameObject light;
    public AudioSource beat;


    // Use this for initialization
    void Start () {


        
	    
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Switch")
        {
            Light beam = gameObject.GetComponentInChildren<Light>();

            if (beam.range > 3)
            {
                beam.range -= 3;
            }
            
        }

        if (col.gameObject.tag == "Tense")
        {
            beat.volume += 0.1f;
        }

        if (col.gameObject.tag == "Loved")
        {
            Light beam = gameObject.GetComponentInChildren<Light>();

            beam.range = 30;
        }

        if (col.gameObject.tag == "Hope")
        {
            Light beam = gameObject.GetComponentInChildren<Light>();

            beam.range += 10;
        }



    }

    void DoThing() {
        //work
    }
}
