using UnityEngine;
/// <summary>
/// 學習迴圈
/// 1.while
/// 2.do while
/// 3.for
/// 4.foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    // 迴圈作用
    // 處理重複的程式

    public int[] scores = new int[20];

    private void Start()
    {
        #region 迴圈for與while
        // 輸出五次嗨
        print("嗨");
        print("嗨");
        print("嗨");
        print("嗨");
        print("嗨");

        // while 迴圈語法
        // 與if 判斷式完全相同
        // if (布林值){ 程式區塊 }
        // while (布林值){ 程式區塊 }

        //當布林值為true執行{}一次
        if (true)
        {
            print("判斷式 if");
        }

        //當布林值為true持續執行{}
        /*
        while (true)
        {
            print("迴圈 while");
        }
        */

        int count = 0;
        while (count<5)
        {
            print("嗨 while");
            count++;
        }
        //for(初始值;布林值;迴圈結束會執行的程式)
        for (int i = 0; i < 5; i++)
        {
            print("嗨 for");
        }
        //數字1~100
        for (int i = 1; i < 101; i++)
        {
            print("輸出數字:"+i);
        }
        #endregion

        //迴圈與陣列應用
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = 80 + i;
        }
    }
}
