using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 7.0f;
	// Use this for initialization
	void Start () {
        Debug.Log("START");
    }
    
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            //transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }
}
