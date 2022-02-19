using UnityEngine;  
// 引用  Unity 引擎空間，讓我們可以使用裡面的API(倉庫)
// 類別類別名稱(必須與檔案名稱相同，大小寫必須一樣)
public class Car : MonoBehaviour
{
    //此類別的內容
    #region 欄位 Field
    // 欄位語法
    // 修飾詞 資料類型 欄位名稱 (指點 預設值) 結尾
    // 四大常用資料類型
    // 整  數 int
    // 浮點數 float
    // 字  串 string
    // 布林值 bool
    // 修飾詞
    // 私人:不給外部資料存取，預設，不顯示private
    // 公開:允許外部資料存取，顯示public
    public int cc = 1000;
    public float weight=3.5f;       //f或F
    public string brand="賓士";     //""包覆
    public bool haswindow=true;    //ture   false
    // Unity 常用的資料類型
    // 顏色 Color
    // 固定顏色
    public Color ColorA;
    // 指定顏色
    public Color yellow = Color.yellow;
    public Color blue = Color.blue;
    // 自定顏色
    public Color ColorB = new Color(0.5f, 0, 0.5f);
    public Color ColorC = new Color(0, 0.5f, 0.5f,0.5f);
    // 向量 Vector 2~4
    public Vector2 Vector2;
    public Vector2 V2Right = Vector2.right;
    public Vector2 V2Up = Vector2.up;
    public Vector2 V2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f);
    //輸入按鍵
    public KeyCode Key;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forward = KeyCode.W;
    public KeyCode weapon1 = KeyCode.Alpha1;    //左邊按鍵
    //public KeyCode 
    public KeyCode mouseL = KeyCode.Mouse0;     //滑鼠左鍵
    public KeyCode mouseR = KeyCode.Mouse1;     //滑鼠右鍵
    //遊戲物件(Hierearchy 內白色線條圖示)  預製物 Prefab(藍色盒子)
    public GameObject goCamer;
    public GameObject goApple;
    public GameObject goTrap;
    public GameObject goFireTrap;
    //元件   Component
    //可儲存屬性面板上所有粗體字元件
    //請去掉空格
    public Transform traCar1;
    public Transform teaCamera;
    public Camera cam;
    public SpriteRenderer spr;
    public SpriteRenderer spr2;

    


    #endregion
    

}
//非汽車資料無法執行
