using TMPro;
using UnityEngine;
/// <summary>
/// �ǲߧP�_��
/// if
/// switch
/// </summary>
public class LearmCondition : MonoBehaviour
{
    public bool haskey = true;
    public int combo = 10;
    public string weapon;

    // �C�| enum(�U�Ԧ����)
    // 1.�w�q�C�|
    public enum Season
    {
        spring,summer,fall,winter
    }
    // 2.��@�C�|
    public Season season;

    private void Start()
    {
        #region if �P�_��
        //if�y�k
        //if(���L��){ �{���϶� �t��k ���z��}
        //�ֳt����if+TAB*2

        //���L�ȵ���ture�|����{}�����{��
        //���L�ȵ���false������
        //����:�ϥ� ture �P  false  �t��
        if (true)
        {
            print("�ڬO�P�_��if");
        }
        if (false)                  //���|����
        {
            print("�ڦ��P�_��if");
        }
        //���L�ȵ��� true �|���� if {} ���e
        //���L�ȵ��� false �|���� else {} ���e

        //�p�G ���_�� �}��
        if (haskey)
        {
            print("�}��");
        }
        //�_�h �S���_��  ����}��
        else
        {
            print("���}��");
        }
        #endregion

        #region switch �y�k
        //switch�y�k
        //switch(�P�_�����)
        // {
        //  case  ��1:
        //       �{�����e;
        //       �{�����e;
        //       �{�����e;
        //       �_�}
        //  case  ��2:
        //       �{�����e;
        //       �{�����e;
        //       �{�����e;
        //       �_�}
        //  default:
        //       �{�����e;
        //       �{�����e;
        //       �{�����e;
        //       �_�}
        // }

        //�p�G�Z��  �O  �M�l �����O 30
        //�p�G�Z��  �O  ��M �����O 50
        //�p�G�Z��  �O  ���C �����O 150
        switch (weapon)
        {
            case "�M�l":
                print("�����O30");
                break;
            case "��M":
                print("�����O50");
                break;
            case "���C":
                print("�����O150");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
        #endregion

        //switch + enum
        switch (season)
        {
            case Season.spring:
                print("�K��");
                break;
            case Season.summer:
                print("�L��");
                break;
            case Season.fall:
                print("���");
                break;
            case Season.winter:
                print("�V��");
                break;
        }


    }

    private void Update()
    {
        
        //else if �����g�bif�U��,�ƶq�S������
        //else if(���L��){ �{���϶� �t��k ���z��}
        //�p�G�s������10�����O�N�[10
        if (combo == 10)
        {
            print("�����O�[10");
        }
        //�p�G�s������100�����O�N�[100
        else if (combo == 100)
        {
            print("�����O�[100");
        }
        //�p�G�s������500�����O�N�[500
        else if (combo == 500)
        {
            print("�����O�[500");
        }
    }
}
