using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon : MonoBehaviour {
    public GameObject[] enenmies;
    public int maxEnemy;
    public float summonInterval;

	void Start () {
        StartCoroutine(EnemySummon());
	}

    IEnumerator EnemySummon()
    {
        for (int i = 0; i < maxEnemy; i++)
        {
            Instantiate(enenmies[1]);
            yield return new WaitForSeconds(summonInterval);
        }        
    }
}
