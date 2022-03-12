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

    private int score;
    private float hpMax;

    private void Start()
    {
        hpMax = hp;
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();

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
        imgHp.fillAmount = hp / hpMax;
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

    }

    /// <summary>
    /// ���a�I��D��γ���
    /// </summary>
    /// <param name="collision"></param>
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
    }

}
