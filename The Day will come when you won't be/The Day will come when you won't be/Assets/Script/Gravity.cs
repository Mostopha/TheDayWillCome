using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	public Rigidbody2D rb;
	public float maxDistance;
	public float defaultForce;


	public AnimationCurve curve;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float currentDistance = Vector3.Distance (transform.position, rb.transform.position);
		if (currentDistance < maxDistance) {
			Vector3 forceDirection = (transform.position - rb.transform.position).normalized;
			rb.AddForce(forceDirection * ((defaultForce * Time.fixedDeltaTime) * (maxDistance - currentDistance)));

		}
			
	}
}
