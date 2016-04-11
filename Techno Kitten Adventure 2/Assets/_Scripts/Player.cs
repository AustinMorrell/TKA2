using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Player : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start () {
	
	}

    void Lerp(float a, float b, float c)
    {
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
    }

    // Update is called once per frame
    void Update ()
    {
        Lerp(Input.GetAxis("Horizontal") * speed, -Input.GetAxis("Vertical") * speed, 0);
    }
}
