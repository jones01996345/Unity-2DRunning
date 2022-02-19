using UnityEngine;
/// <summary>
/// 學習屬性Property
/// </summary>
public class Learmproperty : MonoBehaviour
{
    //屬性語法
    //修飾詞 資料類型 屬性名稱{ 存取子 }
    //快速完成  prop+TAB*2
    //get 取得
    //set 存放
    public int L1 { get; set; }
    public string passwordField;
    //unity預設7版
    //唯獨屬性
    //唯獨給予值的語法:get=>值
    //=>黏巴達Lambda
    public string passwordProperty { get => "666"; }

    private void Start()
    {
        //Set存放屬性
        L1 = 100;
        //get取的屬性
        print("等級" + L1);
        //存取欄位
        passwordField = "1234567";
        print("取得屬性欄位密碼:" + passwordField);
        //存取屬性
        //passwordProerty = 1234567;        //唯獨屬性不能指定值
        print("取得屬性密碼:" + passwordProperty);

    }
}
