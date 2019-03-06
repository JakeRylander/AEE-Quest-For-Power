using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whip : MonoBehaviour {

    private Player player;
    private GameObject goplayer;

    // Use this for initialization
    void Start () {
        goplayer = GameObject.FindWithTag("Player");
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        if(player != null)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                transform.position = goplayer.transform.position + new Vector3(-1f, -1.08f, 0);
            }

            else
            {
                transform.position = goplayer.transform.position + new Vector3(1f, -1.08f, 0);
            }
        }
        

    }
}
