using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHandler: MonoBehaviour {
  // 当たった時に呼ばれる関数
    public bool hit = false;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ログを表示する
        hit = true;
    }
}