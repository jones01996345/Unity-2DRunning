using UnityEngine;
/// <summary>
/// 學習陣列Array
/// </summary>
public class LearnArray : MonoBehaviour
{
    //陣列作用
    //儲存相同類型的多筆資料

    //使用欄位儲存資料
    public int ack1 = 10;
    public int ack2 = 20;
    public int ack3 = 30;

    //陣列語法
    //資料類型[]
    public int[] acks;

    //陣列初始值
    //1.指定陣列資料數量不定值
    public float[] speeds = new float[5];
    //2.指定陣列資料值
    public string[] props = { "紅水", "藍水", "金水" };
    public Vector3[] positions = { new Vector3(0, 1, 1), new Vector3(1, 2, 3) };
    public bool[] complate = { true, true, false, false };

    private void Start()
    {
        //存取陣列資料
        // 1.存放陣列資料
        //陣列名稱[編號] = 值;
        //將陣列一筆資料改為70
        acks[0] = 70;
        //2.使用陣列會遇到的錯誤:超出陣列範圍
        //IndexOutOfRange  - 編號不存在
        //acks[3] = 122;

        //取得陣列資料
        //陣列名稱[編號]
        print("第二筆道具資料" + props[1]);
        print("第一筆座標資料" + positions[0]);

        //取得陣列數量 Length
        print("布林值陣列數量" + complate.Length);
        print("道具陣列數量" + props.Length);
    }

}
