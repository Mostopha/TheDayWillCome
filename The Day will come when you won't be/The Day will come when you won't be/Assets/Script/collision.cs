using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class collision : MonoBehaviour {
	public TextMesh textMesh;
	public string newString;
	public GameObject target;
    //public Color paint;

	// Use this for initialization
	void Start () {

   
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("Thing");

       


    }

    void OnCollisionEnter2D(Collision2D collider)
    {

        MeshRenderer meshy = target.GetComponent<MeshRenderer>();
        BoxCollider2D boxy = target.GetComponent<BoxCollider2D>();
        AudioSource sound = target.GetComponent<AudioSource>();

        Destroy(boxy);
        Destroy(meshy);

		Destroy (target,3f);
		textMesh.text = newString;
        Destroy(gameObject);
		Debug.Log ("Collision");

        // textMesh.color = paint;

        textMesh.color = Color.blue;
		textMesh.characterSize *= 2;


        sound.Play();
       
    }
}
