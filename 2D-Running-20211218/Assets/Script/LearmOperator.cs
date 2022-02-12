using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearmOperator: MonoBehaviour
{
    public float a = 100;
    public float b = 50;
    public int c = 60;
    public int d = 5;

    private void Start()
    {
        #region 運算子:數學
        //加 +
        print("加法" + (a + b));  //150
        //減 -
        print("減法" + (a - b));  //50
        //乘 *
        print("乘法" + (a * b));  //5000
        //除 /
        print("除法" + (a / b));  //2
        //餘 %
        print("餘法" + (a % b));  //0
        #endregion

        #region 運算子:比較
        //比較後的結果為布林值:ture false
        //大於    >
        print("大於" + (c > d));      //ture
        //小於    <
        print("小於" + (c < d));      //false
        //大於等於  >=
        print("大於等於" + (c >= d));   //ture
        //小於等於  <=
        print("小於等於" + (c <= d));   //false
        //等於    == 
        print("等於" + (c == d));     //false
        //不等於   !=
        print("不等於" + (c != d));    //ture

        #endregion

        #region 運算子:邏輯
        //比較後的結果為布林值:ture  false
        //邏輯運算子是針對布林值運算
        //並且  &&(shift + 7)
        //只要其中一個布林值為false 結果就是 false
        print(true && true);        //ture
        print(true && false);       //false
        print(false && true);       //false
        print(false && false);      //false
        //或著 ||(shift+鎮)
        //只要其中一個布林值為 ture 結果就是 ture
        print(true || true);        //ture
        print(true || false);       //ture
        print(false || true);       //ture
        print(false || false);      //false
        //顛倒 !
        //將布林值變相反
        print(!true);   // false
        print(!false);  // ture


        #endregion

    }
}
