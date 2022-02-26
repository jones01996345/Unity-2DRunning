using UnityEngine;
/// <summary>
/// 認識API
/// 靜態 Static
/// 非實體物件，不存在遊戲場景內的物件
/// 必學的三種靜態
/// 1.取得靜態屬性
/// 2.存取靜態屬性
/// 3.使用靜態方法
/// </summary>

public class LearnApiStatic : MonoBehaviour
{
    private void Start()
    {
        //靜態屬性語法
        //1.取得 get
        //類別名稱，靜態屬性名稱
        print("圓周率" + Mathf.PI);
        print("無限大" + Mathf.Infinity);

        //練習
        print("所有攝影機數量" + Camera.allCamerasCount);
        print("2D的重量大小" + Physics2D.gravity);
          

        //2.存取 set
        //類別名稱.靜態屬性名稱 指定 值；
        Cursor.visible = true;      //隱藏滑鼠

        //練習
        Physics2D.gravity = new Vector2(0, -20);
        print("2D重力為-20" + Physics2D.gravity);
        Time.timeScale = 0.5f;
        print("時間慢動作" + Time.time);
        


        //靜態使用方法
        //3.使用
        //類別名稱，靜態方法名稱(對應的引述)
        float abs= Mathf.Abs(-66.6f);
        print("絕對值" + abs);

        //練習
        float numder999 =Mathf.Round(9.999f);
        print("四捨五入" + numder999);
        float number998 = Mathf.Ceil(9.999f);
        print("無條件進位" + number998);
        float number997 = Mathf.Floor(9.999f);
        print("無條件進位" + number997);

        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis= Vector3.Distance(a, b);
        print("兩個點的距離" + dis);
        Application.OpenURL("https://unity.com/");

    }

    private void Update()
    {
        //print("遊戲經過時間" + Time.time);
        print("是否輸入任意按鍵<color=red>" + Input.anyKeyDown+"</color>");
        print("是否按下空白建<color=yellow>" + Input.GetKeyDown(KeyCode.Space)+ "</color>");
    }
}
