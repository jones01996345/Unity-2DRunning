using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 遊戲管理器
/// 角色血量、時間與分數管理
/// </summary>

public class GameManager : MonoBehaviour
{
    [Header("血條")]
    public Image imgHp;
    [Header("時間")]
    public Text testTime;
    [Header("分數")]
    public Text testScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;
    [Header("道具標籤")]
    public string tagProp = "道具";
    [Header("陷阱標籤")]
    public string tagTrap = "陷阱";
    [Header("結束畫面")]
    public CanvasGroup groupFinal;
    [Header("結束畫面標題")]
    public Text textFinalTitle;
    [Header("顯示結束畫面間隔")]
    public float showFinalInterval;
    [Header("死亡動畫參數")]
    public string parameterDead = "觸發死亡";
    [Header("過關區域名稱")]
    public string namePass = "過關區域";
    
    

    private int score;
    private float hpMax;
    private Animator ani;
    private Player player;


    private void Start()
    {
        ani=GetComponent<Animator>();
        player = GetComponent<Player>();
        hpMax = hp;
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();

    }

    private void ShowFinal()
    {
        groupFinal.alpha += 0.2f;

    }
    /// <summary>
    /// 更新介面時間
    /// </summary>
    private void UpdateTimeUI()
    {
        //print("當前場景時間:" + Time.timeSinceLevelLoad);
        //Tostring()將資料轉為字串
        //()內可以格式化字串，F點數:小數點後幾位，例如F2小數點後兩位
        testTime.text = "時間:" + Time.timeSinceLevelLoad.ToString("F1");
    }
    /// <summary>
    /// 更新血條介面
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }
    /// <summary>
    /// 加分數且更新介面
    /// </summary>
    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        testScore.text = "分數" + score;
    }

    /// <summary>
    /// 造成傷害並且更新介面
    /// </summary>
    /// <param name="damage">造成的傷害</param>
    private void TakeDamageAndUpdateUI(float damage)
    {
        hp -=damage;
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }
    /// <summary>
    /// 遊戲失敗
    /// </summary>
    private void Lose()
    {
        if (hp == 0 && groupFinal.alpha==0)  //如果 血量 等於 0 並且 結束畫面
        {
            textFinalTitle.text = "挑戰失敗";
            groupFinal.interactable = true;

            ani.SetTrigger(parameterDead);
            player.enabled = false;

            //延遲重複呼叫("方法名稱"，延遲時間，間隔)
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }
    private void Win()
    {
        textFinalTitle.text = "挑戰成功";

        groupFinal.interactable = true;

        player.enabled = false;

        //延遲重複呼叫("方法名稱"，延遲時間，間隔)
        InvokeRepeating("ShowFinal", 0, showFinalInterval);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("玩家碰到物件:" + collision.name);
        if (collision.tag==tagProp)
        {
            
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);
            // Destroy(物件)刪除物件
            Destroy(collision.gameObject);

        }
        if (collision.tag==tagTrap)
        {
            TakeDamageAndUpdateUI(collision.GetComponent<Trap>().damage);
        }
        if (collision.name==namePass)
        {
            Win();
        }
    }

}
