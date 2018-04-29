using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMove : MonoBehaviour {
    public UISprite _sprite;
    public GameObject player;
    private Player pm;
    public bool isWalking;

    private void Start()
    {
        pm = player.GetComponent<Player>();
        isWalking = false;
    }

    private void Update()
    {
        if (isWalking)
        {
            pm.RightArrow();
        }   
    }

    void OnPress()
    {
        switch (isWalking)
        {
            case true:
                isWalking = false;
                break;
            case false:
                isWalking = true;
                break;
        }
    }

    void OnHover(bool isOver)
    {
        _sprite.cachedTransform.localScale = (isOver) ? Vector3.one * 1.1f : Vector3.one;
    }
}
