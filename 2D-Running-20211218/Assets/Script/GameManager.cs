using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �C���޲z��
/// �����q�B�ɶ��P���ƺ޲z
/// </summary>

public class GameManager : MonoBehaviour
{
    [Header("���")]
    public Image imgHp;
    [Header("�ɶ�")]
    public Text testTime;
    [Header("����")]
    public Text testScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;
    [Header("�D�����")]
    public string tagProp = "�D��";
    [Header("��������")]
    public string tagTrap = "����";
    [Header("�����e��")]
    public CanvasGroup groupFinal;
    [Header("�����e�����D")]
    public Text textFinalTitle;
    [Header("��ܵ����e�����j")]
    public float showFinalInterval;
    [Header("���`�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("�L���ϰ�W��")]
    public string namePass = "�L���ϰ�";
    
    

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
    /// ��s�����ɶ�
    /// </summary>
    private void UpdateTimeUI()
    {
        //print("��e�����ɶ�:" + Time.timeSinceLevelLoad);
        //Tostring()�N����ର�r��
        //()���i�H�榡�Ʀr��AF�I��:�p���I��X��A�ҦpF2�p���I����
        testTime.text = "�ɶ�:" + Time.timeSinceLevelLoad.ToString("F1");
    }
    /// <summary>
    /// ��s�������
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }
    /// <summary>
    /// �[���ƥB��s����
    /// </summary>
    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        testScore.text = "����" + score;
    }

    /// <summary>
    /// �y���ˮ`�åB��s����
    /// </summary>
    /// <param name="damage">�y�����ˮ`</param>
    private void TakeDamageAndUpdateUI(float damage)
    {
        hp -=damage;
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }
    /// <summary>
    /// �C������
    /// </summary>
    private void Lose()
    {
        if (hp == 0 && groupFinal.alpha==0)  //�p�G ��q ���� 0 �åB �����e��
        {
            textFinalTitle.text = "�D�ԥ���";
            groupFinal.interactable = true;

            ani.SetTrigger(parameterDead);
            player.enabled = false;

            //���𭫽ƩI�s("��k�W��"�A����ɶ��A���j)
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }
    private void Win()
    {
        textFinalTitle.text = "�D�Ԧ��\";

        groupFinal.interactable = true;

        player.enabled = false;

        //���𭫽ƩI�s("��k�W��"�A����ɶ��A���j)
        InvokeRepeating("ShowFinal", 0, showFinalInterval);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("���a�I�쪫��:" + collision.name);
        if (collision.tag==tagProp)
        {
            
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);
            // Destroy(����)�R������
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
