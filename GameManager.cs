using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool can = false;

    // 投票判定がされたか（trueならば投票判定がされたという意味）
    // isPoleA/Bと2つあるのは，どちらに投票されたか区別するため
    public bool isPoleA = false;
    public bool isPoleB = false;
    public int counter1 = 0;
    public int counter2 = 0;

    private graphGenerator graphGenerator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPoleA == true)
        {
            Debug.Log("A is Poled.");
        }
        if (isPoleB == true)
        {
            Debug.Log("B is Poled.");
        }
    }
}
