using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearmOperator: MonoBehaviour
{
    public float a = 100;
    public float b = 50;
    public int c = 60;
    public int d = 5;
    public int e = 1;

    private void Start()
    {
        #region �B��l:�ƾ�
        //�[ +
        print("�[�k" + (a + b));  //150
        //�� -
        print("��k" + (a - b));  //50
        //�� *
        print("���k" + (a * b));  //5000
        //�� /
        print("���k" + (a / b));  //2
        //�l %
        print("�l�k" + (a % b));  //0

        //�[�@
        // = ���w�Ÿ�:������k��B��A�⵲�G���w������
        e = e +1;
        print("e �B�⵲�G:" + e);   // 2
        //����
        e++;
        print("e �B�⵲�G" + e);    // 3
        //�A�δ�ke--;
        //�[�Q
        e = e + 10;                // 13
        print("e �B�⵲�G:" + e);
        //�A�Υ[����l  += -= /= *=
        e +=10;                    // 23
        print("e �B�⵲�G:" + e);
        e -= 5;                    // 18
        print("e �B�⵲�G:" + e);
        e *= 10;                   // 180
        print("e �B�⵲�G:" + e);
        e /= 6;                    // 30
        print("e �B�⵲�G:" + e);

        #endregion

        #region �B��l:���
        //����᪺���G�����L��:ture false
        //�j��    >
        print("�j��" + (c > d));      //ture
        //�p��    <
        print("�p��" + (c < d));      //false
        //�j�󵥩�  >=
        print("�j�󵥩�" + (c >= d));   //ture
        //�p�󵥩�  <=
        print("�p�󵥩�" + (c <= d));   //false
        //����    == 
        print("����" + (c == d));     //false
        //������   !=
        print("������" + (c != d));    //ture

        #endregion

        #region �B��l:�޿�
        //����᪺���G�����L��:ture  false
        //�޿�B��l�O�w�塞�L�ȹB��
        //�åB  &&(shift + 7)
        //�u�n�䤤�@�ӥ��L�Ȭ�false ���G�N�O false
        print(true && true);        //ture
        print(true && false);       //false
        print(false && true);       //false
        print(false && false);      //false
        //�ε� ||(shift+��)
        //�u�n�䤤�@�ӥ��L�Ȭ� ture ���G�N�O ture
        print(true || true);        //ture
        print(true || false);       //ture
        print(false || true);       //ture
        print(false || false);      //false
        //�A�� !
        //�N���L���ܬۤ�
        print(!true);   // false
        print(!false);  // ture


        #endregion

    }
}
