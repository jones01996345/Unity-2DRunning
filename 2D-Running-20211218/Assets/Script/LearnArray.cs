using UnityEngine;
/// <summary>
/// �ǲ߰}�CArray
/// </summary>
public class LearnArray : MonoBehaviour
{
    //�}�C�@��
    //�x�s�ۦP�������h�����

    //�ϥ�����x�s���
    public int ack1 = 10;
    public int ack2 = 20;
    public int ack3 = 30;

    //�}�C�y�k
    //�������[]
    public int[] acks;

    //�}�C��l��
    //1.���w�}�C��Ƽƶq���w��
    public float[] speeds = new float[5];
    //2.���w�}�C��ƭ�
    public string[] props = { "����", "�Ť�", "����" };
    public Vector3[] positions = { new Vector3(0, 1, 1), new Vector3(1, 2, 3) };
    public bool[] complate = { true, true, false, false };

    private void Start()
    {
        //�s���}�C���
        // 1.�s��}�C���
        //�}�C�W��[�s��] = ��;
        //�N�}�C�@����Ƨאּ70
        acks[0] = 70;
        //2.�ϥΰ}�C�|�J�쪺���~:�W�X�}�C�d��
        //IndexOutOfRange  - �s�����s�b
        //acks[3] = 122;

        //���o�}�C���
        //�}�C�W��[�s��]
        print("�ĤG���D����" + props[1]);
        print("�Ĥ@���y�и��" + positions[0]);

        //���o�}�C�ƶq Length
        print("���L�Ȱ}�C�ƶq" + complate.Length);
        print("�D��}�C�ƶq" + props.Length);
    }

}
