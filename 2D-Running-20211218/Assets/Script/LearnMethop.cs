using UnityEngine;
/// <summary>�ǲߤ�kMethop</summary>
public class LearnMethop : MonoBehaviour
{
    //��k�y�k
    //�׹��� �Ǧ^������� ��k�W�� (�Ѽ�)  {�{�����e ���z�� �t�⦡}
    //void �L�Ǧ^:�ϥΦ���k�ɤ��|����ƶǦ^

    private void Start()
    {
        //�I�s�ۭq��k
        //�ۭq��k�W��();
        Test();
        ShoopFire();
        ShoopIce();
        //���X�ӰѼƴN�n��J�X�Ӥ޼�
        //���w�]���Ѽƥi�H���ε��޼�,�H�w�]���D
        //���h�ֹw�]�ѼƮɥi�H�ϥΫ��W�覡 �ѼƦW��:��
        //���y170 ������ �U�N
        Shoot("���y",170,effect:"�U�N");
        Shoot("�B�y",30);
        Shoot("�r�y",40);
        Shoot("�p�u",200,"������");
        int water = BuyWater(5);
        print("�R����" + water);
        float Jones = BMI(75, 1.72f);
        print("Jones BMI" + Jones);
        float test = BMI(60, 1.80f);
        print("test BMI" + test);

    }

    //�ۭq��k:���|�۰ʰ���
    //�|�۰ʰ��檺�s�ƥ�

    private void Test()
    {
        print("����");
    }

    //�o�g���y �o�g�B�y �o�g�r�y
    private void ShoopFire()
    {
        print("�o�g���y");
        print("����t�� 100");
        print("�o�g����");
    }

    private void ShoopIce()
    {
        print("�o�g�B�y");
        print("����t�� 50");
        print("�o�g����");
    }

    //���@�ʻP�X�R��
    //�Ѽƻy�k:�Ѽ�1���� �Ѽ�1�W��,�Ѽ�2���� �Ѽ�2�W��
    //�Ѽƹw�]��:�Ѽ����� �ѼƦW��=�w�]��
    //���w�]�Ȫ��Ѽƥ�����b�᭱
    private void Shoot(string type, int speed,string sound="������",string effect="�z��")     //(��r �W��,�i�H�[int��float)
    {
        print("<color=yellow>�o�g" + type+"</color>");
        print("<color=yellow>����t��" + speed+ "</color>");
        print("<color=yellow>�o�g����" + sound + "</color>");
        print("<color=yellow>�z������" + effect + "</color>");
    }
    //�@���Ĥ�50��
    private int BuyWater(int count)
    {
        int price = count * 50;
        return price;
    }

    //BMI �魫/����*����
    /// <summary>���O���n���ܭ��n
    /// �p��BMI
    /// </summary>
    /// <param name="weight">�魫</param>
    /// <param name="height">����</param>
    /// <returns>BMI���G</returns>
    private float BMI(float weight,float height)
    {
        float result = weight / (height * height);
        return result;
    }
}
