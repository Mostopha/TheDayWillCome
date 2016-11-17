using UnityEngine;
using System.Collections;

public class playerControllerScript : MonoBehaviour {
    public Rigidbody2D rb;
    public float moveSpeed;
    public float speedMultiplier;
    public Vector2 drag;

	public float bobForce;
	public AnimationCurve curve;

    private float currentXSpeed;
   

    // Use this for initialization
    void Start() {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Horizontal") > 0)
        {
            //set the velocity of the rigid body
            rb.velocity = new Vector2(moveSpeed * speedMultiplier, rb.velocity.y);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            //set the velocity of the rigid body
            rb.velocity = new Vector2(-moveSpeed * speedMultiplier, rb.velocity.y);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            //set the velocity of the rigid body
			rb.velocity = new Vector2(rb.velocity.x,moveSpeed * speedMultiplier);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            //set the velocity of the rigid body
			rb.velocity = new Vector2(rb.velocity.x,-moveSpeed * speedMultiplier);
        }

		float bob = curve.Evaluate (Mathf.PingPong(Time.time, 1));

		rb.AddForce (Vector3.up * bob * bobForce);

    }
}

