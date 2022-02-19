using TMPro;
using UnityEngine;
/// <summary>
/// 學習判斷式
/// if
/// switch
/// </summary>
public class LearmCondition : MonoBehaviour
{
    public bool haskey = true;
    public int combo = 10;
    public string weapon;

    // 列舉 enum(下拉式選單)
    // 1.定義列舉
    public enum Season
    {
        spring,summer,fall,winter
    }
    // 2.實作列舉
    public Season season;

    private void Start()
    {
        #region if 判斷式
        //if語法
        //if(布林值){ 程式區塊 演算法 陳述式}
        //快速完成if+TAB*2

        //布林值等於ture會執行{}內的程式
        //布林值等於false不執行
        //實驗:使用 ture 與  false  差異
        if (true)
        {
            print("我是判斷式if");
        }
        if (false)                  //不會執行
        {
            print("我式判斷式if");
        }
        //當布林值等於 true 會執行 if {} 內容
        //當布林值等於 false 會執行 else {} 內容

        //如果 有鑰匙 開門
        if (haskey)
        {
            print("開門");
        }
        //否則 沒有鑰匙  不能開門
        else
        {
            print("不開門");
        }
        #endregion

        #region switch 語法
        //switch語法
        //switch(判斷的資料)
        // {
        //  case  值1:
        //       程式內容;
        //       程式內容;
        //       程式內容;
        //       斷開
        //  case  值2:
        //       程式內容;
        //       程式內容;
        //       程式內容;
        //       斷開
        //  default:
        //       程式內容;
        //       程式內容;
        //       程式內容;
        //       斷開
        // }

        //如果武器  是  刀子 攻擊力 30
        //如果武器  是  刺刀 攻擊力 50
        //如果武器  是  光劍 攻擊力 150
        switch (weapon)
        {
            case "刀子":
                print("攻擊力30");
                break;
            case "刺刀":
                print("攻擊力50");
                break;
            case "光劍":
                print("攻擊力150");
                break;
            default:
                print("這不是武器");
                break;
        }
        #endregion

        //switch + enum
        switch (season)
        {
            case Season.spring:
                print("春天");
                break;
            case Season.summer:
                print("夏天");
                break;
            case Season.fall:
                print("秋天");
                break;
            case Season.winter:
                print("冬天");
                break;
        }


    }

    private void Update()
    {
        
        //else if 必須寫在if下方,數量沒有限制
        //else if(布林值){ 程式區塊 演算法 陳述式}
        //如果連擊等於10攻擊力就加10
        if (combo == 10)
        {
            print("攻擊力加10");
        }
        //如果連擊等於100攻擊力就加100
        else if (combo == 100)
        {
            print("攻擊力加100");
        }
        //如果連擊等於500攻擊力就加500
        else if (combo == 500)
        {
            print("攻擊力加500");
        }
    }
}
