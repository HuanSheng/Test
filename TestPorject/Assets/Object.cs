using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public GameObject Cube;

	void Update () {

        float xspeed = Input.GetAxis("Horizontal");
        float yspeed = Input.GetAxis("Vertical");

        Cube.transform.Translate(xspeed * Time.deltaTime, yspeed * Time.deltaTime, 0);
	}
}
