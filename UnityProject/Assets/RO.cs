using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RO : MonoBehaviour
{
    [Header("任務對話")]
    public string star = "嗨,能幫助我一個忙嗎?";
    [Header("對話速率")]
    public float talkspeed = 1.5f;
    [Header("任務")]
    public bool mission_complete = false;
    public int batery = 0;
    public int bateryfinish = 5;


    void Start()
    {
        Debug.Log(star);
    }


    void Update()
    {

    }
}