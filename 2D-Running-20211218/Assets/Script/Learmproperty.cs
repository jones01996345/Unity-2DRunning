using UnityEngine;
/// <summary>
/// �ǲ��ݩ�Property
/// </summary>
public class Learmproperty : MonoBehaviour
{
    //�ݩʻy�k
    //�׹��� ������� �ݩʦW��{ �s���l }
    //�ֳt����  prop+TAB*2
    //get ���o
    //set �s��
    public int L1 { get; set; }
    public string passwordField;
    //unity�w�]7��
    //�߿W�ݩ�
    //�߿W�����Ȫ��y�k:get=>��
    //=>�H�ڹFLambda
    public string passwordProperty { get => "666"; }

    private void Start()
    {
        //Set�s���ݩ�
        L1 = 100;
        //get�����ݩ�
        print("����" + L1);
        //�s�����
        passwordField = "1234567";
        print("���o�ݩ����K�X:" + passwordField);
        //�s���ݩ�
        //passwordProerty = 1234567;        //�߿W�ݩʤ�����w��
        print("���o�ݩʱK�X:" + passwordProperty);

    }
}
