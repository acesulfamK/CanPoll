using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canController : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager manager;
    

    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void watchCan()
    {
        manager.can = true;
        Debug.Log("watch can");
    }
}
