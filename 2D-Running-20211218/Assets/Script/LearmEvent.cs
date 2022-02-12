using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearmEvent : MonoBehaviour
{
    //開始事件:
    //開始遊戲時執行此事件一次
    private void Start()
    {
        //輸出(輸出資料); print();
        print("哈囉,沃德:D");
    }
    //更新事件
    //開始遊戲後每秒約執行六十次 60Fps
    //處理持續執行的行為
    private void Update()
    {
        print("我在 Update 事件內~");
    }
}
