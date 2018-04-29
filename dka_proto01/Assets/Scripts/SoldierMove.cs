using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour {

    public float moveSpd;
	
	void Update () {
        transform.Translate(moveSpd * Time.deltaTime, 0, 0);
	}
}
