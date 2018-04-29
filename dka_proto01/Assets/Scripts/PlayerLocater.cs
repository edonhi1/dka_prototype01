using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocater : MonoBehaviour {

    public GameObject player;

	void Start () {
		
	}
	
	void Update () {
        transform.localPosition = new Vector3((player.transform.position.x + 4) * 5, 74, 0);
	}
}
