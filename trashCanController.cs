using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashcanController : MonoBehaviour
{

    private GameManager manager;

    // カメラに缶を認識させるメッセージを送るか（trueなら送る）
    private bool CamMsgFlag = true;

    // 投票メッセージを送るか（trueなら送る）
    private bool VoteMsgFlag = true;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Pole();
    }

    public void Pole()
    {
        // 缶を認識していない場合，認識させるようにメッセージを出す 
        if (!manager.can && CamMsgFlag)
        {
            Debug.Log("Please let the camera recognize your can!");
            CamMsgFlag = false;
        }

        // 缶を認識したら，投票メッセージを出す
        if (manager.can && VoteMsgFlag)
        {
            Debug.Log("Vote Takenoko-no-Sato or Kinoko-no-Yama!");
            VoteMsgFlag = false;
        }

        // 投票判定がされたら，片方のカウンターをインクリメント
        if (manager.can && (manager.isPoleA || manager.isPoleB))
        {
            if (manager.isPoleA)
            {
                manager.counter1++;
                Debug.Log("CounterA is " + manager.counter1);
                manager.isPoleA = false;
            }
            if (manager.isPoleB)
            {
                manager.counter2++;
                Debug.Log("CounterB is " + manager.counter2);
                manager.isPoleB = false;
            }
            CamMsgFlag = true;
            VoteMsgFlag = true;
            manager.can = false;

        }
    }


  
}
