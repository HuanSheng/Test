using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public GameObject Cube;
    public float Speed;
	void Update () {

        float xspeed = Input.GetAxis("Horizontal");
        float yspeed = Input.GetAxis("Vertical");

	}
}
