using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject BlockPrefab;

    private GameObject _BlockInstance;
    private int _BlockInitX = 0;
    private int _BlockInitX2 = 10;
    private int _BlockInitY = 0;
    public static int _BlockCount1 = 0;
    public static int _BlockCount2 = 0;
    private static int _BlockMax1 = 0;
    private static int _BlockMax2 = 0;
    private int _BlockStepY = 1;
    private float _TimeStep = 0.1f;
    private float _TimeCount;

    // GameManagerのカウンターをグラフに反映させたい
    private GameManager manager;


    void Start()
    {
        _TimeCount = Time.time;
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_TimeCount + _TimeStep < Time.time)
        {
            GenerateBlock();
            _TimeCount = Time.time;
        }

    }

    void GenerateBlock()
    {
        _BlockMax1 = manager.counter1;
        _BlockMax2 = manager.counter2;

        if (_BlockCount1 < _BlockMax1)
        {
            int xPos = _BlockInitX;
            int yPos = _BlockCount1 * _BlockStepY + _BlockInitY;

            _BlockInstance = Instantiate(BlockPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
            _BlockInstance.name = "Block" + _BlockCount1;
            _BlockInstance.transform.SetParent(transform, false);
            //_BlockInstance.AddComponent<BlockController>();
            _BlockInstance.GetComponent<Renderer>().material.color = Color.blue;

            _BlockCount1++;
        }

        if (_BlockCount2 < _BlockMax2)
        {
            int xPos = _BlockInitX2;
            int yPos = _BlockCount2 * _BlockStepY + _BlockInitY;
            _BlockInstance = Instantiate(BlockPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
            _BlockInstance.name = "Block2_" + _BlockCount2;
            _BlockInstance.transform.SetParent(transform, false);
            //_BlockInstance.AddComponent<BlockController>();
            _BlockInstance.GetComponent<Renderer>().material.color = Color.red;
            _BlockCount2++;
        }
    }
}
