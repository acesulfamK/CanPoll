using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CustomObserverEventHandler2 : DefaultObserverEventHandler
{

    private GameManager manager;


    public bool tracking_flag = false;

    protected override void Start()
    {  
        base.Start ();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {

    }

    protected override void OnTrackingFound ()
    {
        tracking_flag = true;
        Debug.Log("tracked can");

        // ここにマーカーが認識された時の初期化内容を記述
        manager.can = true;
        Debug.Log("watch can");

    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost ();
        // ここにマーカーが見えなくなったときの処理を記述
    }
}
