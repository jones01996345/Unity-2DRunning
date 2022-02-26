using System.Runtime.InteropServices;
using UnityEngine;
/// <summary>
/// 認識非動態API
/// 非靜態Non-Static
/// 適用在實體,存在遊戲場景內的物件
/// 必學的三種靜態
/// 1.取得非靜態屬性
/// 2.存取非靜態屬性
/// 3.使用非靜態方法
/// </summary>

public class LearnAPINoStatic : MonoBehaviour
{
    public Transform tracar1;
    public GameObject goCar;
    public Camera cam;
    public SpriteRenderer spr;
    public Transform banana;
    public Rigidbody2D cherries;
    

    

    private void Start()
    {
        #region 教學區
        //靜態跟非靜態的差異
        //  1.非靜態需要一個實體物件
        //  2.定義一個欄位
        //  3.儲存該實體物件
        //實體物件
        //1.遊戲物件 Game Object:在Hierarchy內的白色方塊圖示物件
        //2.預製物 prefab:在Hierarchy內的藍色方塊物件
        //3.元件 component:1與2屬性面板上可折疊

        //非靜態屬性語法
        //1.取得 get
        //欄位名稱，非靜態屬性名稱
        print("汽車的座標"+ tracar1.position);

        //2.存取 set
        //欄位名稱.非靜態屬性名稱 指定 值；
        tracar1.position = new Vector3(3, 6, 5);

        //靜態使用方法
        //3.使用
        //欄位名稱，非靜態方法名稱(對應的引述)
        goCar.SetActive(false);

        #endregion

        #region 練習
        //取得
        print("攝影機深度" + cam.depth);
        print("圖片顏色" + spr.color);

        //存取
        cam.backgroundColor = Random.ColorHSV();
        spr.flipY = true;

        


        

        #endregion

    }
    private void Update()
    {
        //使用
        banana.Rotate(0, 0, 10);
        cherries.AddForce(new Vector2(0, 10));
    }

}
