using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkCreate : MonoBehaviour {
    public GameObject player;
    public GameObject mark;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(mark, player.transform.position, Quaternion.identity);
    }
}
