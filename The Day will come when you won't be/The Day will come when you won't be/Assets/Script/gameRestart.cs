using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameRestart : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            Invoke("Restart", 1f);
        }


	}

    void Restart()
    {

        Scene grief = SceneManager.GetActiveScene();
        SceneManager.LoadScene(grief.name);

    }

}
