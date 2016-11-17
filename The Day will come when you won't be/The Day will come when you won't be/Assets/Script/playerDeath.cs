using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class playerDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Death")
        {

            Destroy(gameObject);

          

        }
            
    }

   
}
