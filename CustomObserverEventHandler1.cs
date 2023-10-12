using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CustomObserverEventHandler1 : DefaultObserverEventHandler
{

    private GameManager manager;


    public bool tracking_flag = false;

    protected override void Start()
    {  
        base.Start (); // Probably, When DefaultObserverEventHandler is used, this line is necessary.
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {

    }

    protected override void OnTrackingFound ()
    {
        tracking_flag = true;
        Debug.Log("tracked trash2");
        // ここにマーカーが認識された時の初期化内容を記述
        if (manager.can == true) 
        {
            manager.isPoleB = true;
            Debug.Log("ispoleB");
        }
        
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost ();
        // ここにマーカーが見えなくなったときの処理を記述
    }
}
