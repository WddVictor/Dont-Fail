using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public TweenScale logoTweenScale;

    private bool isReadyForGame = false;// 表示是否可以进入游戏
	// Use this for initialization
	void Start () {
        logoTweenScale.AddOnFinished(this.OnLogoTweenFinished);
	}
	
	// Update is called once per frame
	void Update () {
        logoTweenScale.PlayForward();
        if(isReadyForGame && Input.GetMouseButton(0))
        {
            //显示菜单界面
            isReadyForGame = false;
            SceneManager.LoadScene(1);
        }
	}

    private void OnLogoTweenFinished()
    {
        isReadyForGame = true;
    }
}
