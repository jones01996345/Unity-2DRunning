using UnityEngine;
/// <summary>學習方法Methop</summary>
public class LearnMethop : MonoBehaviour
{
    //方法語法
    //修飾詞 傳回資料類型 方法名稱 (參數)  {程式內容 陳述式 演算式}
    //void 無傳回:使用此方法時不會有資料傳回

    private void Start()
    {
        //呼叫自訂方法
        //自訂方法名稱();
        Test();
        ShoopFire();
        ShoopIce();
        //有幾個參數就要輸入幾個引數
        //有預設的參數可以不用給引數,以預設為主
        //有多少預設參數時可以使用指名方式 參數名稱:值
        //火球170 咻咻咻 燃燒
        Shoot("火球",170,effect:"燃燒");
        Shoot("冰球",30);
        Shoot("毒球",40);
        Shoot("雷彈",200,"滋滋滋");
        int water = BuyWater(5);
        print("買五罐" + water);
        float Jones = BMI(75, 1.72f);
        print("Jones BMI" + Jones);
        float test = BMI(60, 1.80f);
        print("test BMI" + test);

    }

    //自訂方法:不會自動執行
    //會自動執行的叫事件

    private void Test()
    {
        print("測試");
    }

    //發射火球 發射冰球 發射毒球
    private void ShoopFire()
    {
        print("發射火球");
        print("飛行速度 100");
        print("發射音效");
    }

    private void ShoopIce()
    {
        print("發射冰球");
        print("飛行速度 50");
        print("發射音效");
    }

    //維護性與擴充性
    //參數語法:參數1類型 參數1名稱,參數2類型 參數2名稱
    //參數預設值:參數類型 參數名稱=預設值
    //有預設值的參數必須放在後面
    private void Shoot(string type, int speed,string sound="咻咻咻",string effect="爆炸")     //(文字 名稱,可以加int或float)
    {
        print("<color=yellow>發射" + type+"</color>");
        print("<color=yellow>飛行速度" + speed+ "</color>");
        print("<color=yellow>發射音效" + sound + "</color>");
        print("<color=yellow>爆炸音效" + effect + "</color>");
    }
    //一罐藥水50元
    private int BuyWater(int count)
    {
        int price = count * 50;
        return price;
    }

    //BMI 體重/身高*身高
    /// <summary>不是必要但很重要
    /// 計算BMI
    /// </summary>
    /// <param name="weight">體重</param>
    /// <param name="height">身高</param>
    /// <returns>BMI結果</returns>
    private float BMI(float weight,float height)
    {
        float result = weight / (height * height);
        return result;
    }
}
