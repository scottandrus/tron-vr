using UnityEngine;
using System.Collections;

public class BikeMove : MonoBehaviour {
	public Transform cubePrefab;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
		if(translation > 0) {
			Instantiate(cubePrefab, transform.position, transform.rotation);
		}
	}
}
