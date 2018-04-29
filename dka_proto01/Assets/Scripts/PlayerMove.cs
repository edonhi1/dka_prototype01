using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private GameObject player;
    public int speed;

	void Start () {
        player = this.gameObject;
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }

    public void LeftArrow()
    {
        player.transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    public void RightArrow()
    {
        player.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
