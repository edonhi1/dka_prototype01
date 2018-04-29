using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoner : MonoBehaviour {

    public GameObject[] soldiers;

    public void Summon01()
    {
        Instantiate(soldiers[1]);
    }
    public void Summon02()
    {
        Instantiate(soldiers[2]);
    }
    public void Summon03()
    {
        Instantiate(soldiers[3]);
    }
}
