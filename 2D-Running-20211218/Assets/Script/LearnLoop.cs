using UnityEngine;
/// <summary>
/// �ǲ߰j��
/// 1.while
/// 2.do while
/// 3.for
/// 4.foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    // �j��@��
    // �B�z���ƪ��{��

    public int[] scores = new int[20];

    private void Start()
    {
        #region �j��for�Pwhile
        // ��X������
        print("��");
        print("��");
        print("��");
        print("��");
        print("��");

        // while �j��y�k
        // �Pif �P�_�������ۦP
        // if (���L��){ �{���϶� }
        // while (���L��){ �{���϶� }

        //���L�Ȭ�true����{}�@��
        if (true)
        {
            print("�P�_�� if");
        }

        //���L�Ȭ�true�������{}
        /*
        while (true)
        {
            print("�j�� while");
        }
        */

        int count = 0;
        while (count<5)
        {
            print("�� while");
            count++;
        }
        //for(��l��;���L��;�j�鵲���|���檺�{��)
        for (int i = 0; i < 5; i++)
        {
            print("�� for");
        }
        //�Ʀr1~100
        for (int i = 1; i < 101; i++)
        {
            print("��X�Ʀr:"+i);
        }
        #endregion

        //�j��P�}�C����
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = 80 + i;
        }
    }
}
