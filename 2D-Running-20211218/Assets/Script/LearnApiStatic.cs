using UnityEngine;
/// <summary>
/// �{��API
/// �R�A Static
/// �D���骫��A���s�b�C��������������
/// ���Ǫ��T���R�A
/// 1.���o�R�A�ݩ�
/// 2.�s���R�A�ݩ�
/// 3.�ϥ��R�A��k
/// </summary>

public class LearnApiStatic : MonoBehaviour
{
    private void Start()
    {
        //�R�A�ݩʻy�k
        //1.���o get
        //���O�W�١A�R�A�ݩʦW��
        print("��P�v" + Mathf.PI);
        print("�L���j" + Mathf.Infinity);

        //�m��
        print("�Ҧ���v���ƶq" + Camera.allCamerasCount);
        print("2D�����q�j�p" + Physics2D.gravity);
          

        //2.�s�� set
        //���O�W��.�R�A�ݩʦW�� ���w �ȡF
        Cursor.visible = true;      //���÷ƹ�

        //�m��
        Physics2D.gravity = new Vector2(0, -20);
        print("2D���O��-20" + Physics2D.gravity);
        Time.timeScale = 0.5f;
        print("�ɶ��C�ʧ@" + Time.time);
        


        //�R�A�ϥΤ�k
        //3.�ϥ�
        //���O�W�١A�R�A��k�W��(�������ޭz)
        float abs= Mathf.Abs(-66.6f);
        print("�����" + abs);

        //�m��
        float numder999 =Mathf.Round(9.999f);
        print("�|�ˤ��J" + numder999);
        float number998 = Mathf.Ceil(9.999f);
        print("�L����i��" + number998);
        float number997 = Mathf.Floor(9.999f);
        print("�L����i��" + number997);

        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis= Vector3.Distance(a, b);
        print("����I���Z��" + dis);
        Application.OpenURL("https://unity.com/");

    }

    private void Update()
    {
        //print("�C���g�L�ɶ�" + Time.time);
        print("�O�_��J���N����<color=red>" + Input.anyKeyDown+"</color>");
        print("�O�_���U�ťի�<color=yellow>" + Input.GetKeyDown(KeyCode.Space)+ "</color>");
    }
}
