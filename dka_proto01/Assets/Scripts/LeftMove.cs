using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour {
    public UISprite _sprite;
    public GameObject player;
    private PlayerMove pm;
    public bool isWalking;

    private void Start()
    {
        pm = player.GetComponent<PlayerMove>();
        isWalking = false;
    }

    private void Update()
    {
        if (isWalking)
        {
            pm.LeftArrow();
        }
    }

    void OnPress()      //누르기 시작할 때, 누르고 있다가 뗄 때 호출
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
