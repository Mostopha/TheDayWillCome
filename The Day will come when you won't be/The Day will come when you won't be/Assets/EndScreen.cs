using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndScreen : MonoBehaviour {

    public TextMesh textMesh;
    public string newString;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collider)
    {

        MeshRenderer meshy = gameObject.GetComponent<MeshRenderer>();
        BoxCollider2D boxy = gameObject.GetComponent<BoxCollider2D>();
        AudioSource sound = gameObject.GetComponent<AudioSource>();

        Destroy(boxy);
        Destroy(meshy);

        textMesh.text = newString;
        Debug.Log("Collision");

        // textMesh.color = paint;

        textMesh.color = Color.red;
        textMesh.characterSize *= 1;


        sound.Play();
        Invoke("End", 3);
    }

    void End()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
