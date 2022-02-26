using System.Runtime.InteropServices;
using UnityEngine;
/// <summary>
/// �{�ѫD�ʺAAPI
/// �D�R�ANon-Static
/// �A�Φb����,�s�b�C��������������
/// ���Ǫ��T���R�A
/// 1.���o�D�R�A�ݩ�
/// 2.�s���D�R�A�ݩ�
/// 3.�ϥΫD�R�A��k
/// </summary>

public class LearnAPINoStatic : MonoBehaviour
{
    public Transform tracar1;
    public GameObject goCar;
    public Camera cam;
    public SpriteRenderer spr;
    public Transform banana;
    public Rigidbody2D cherries;
    

    

    private void Start()
    {
        #region �оǰ�
        //�R�A��D�R�A���t��
        //  1.�D�R�A�ݭn�@�ӹ��骫��
        //  2.�w�q�@�����
        //  3.�x�s�ӹ��骫��
        //���骫��
        //1.�C������ Game Object:�bHierarchy�����զ����ϥܪ���
        //2.�w�s�� prefab:�bHierarchy�����Ŧ�������
        //3.���� component:1�P2�ݩʭ��O�W�i���|

        //�D�R�A�ݩʻy�k
        //1.���o get
        //���W�١A�D�R�A�ݩʦW��
        print("�T�����y��"+ tracar1.position);

        //2.�s�� set
        //���W��.�D�R�A�ݩʦW�� ���w �ȡF
        tracar1.position = new Vector3(3, 6, 5);

        //�R�A�ϥΤ�k
        //3.�ϥ�
        //���W�١A�D�R�A��k�W��(�������ޭz)
        goCar.SetActive(false);

        #endregion

        #region �m��
        //���o
        print("��v���`��" + cam.depth);
        print("�Ϥ��C��" + spr.color);

        //�s��
        cam.backgroundColor = Random.ColorHSV();
        spr.flipY = true;

        


        

        #endregion

    }
    private void Update()
    {
        //�ϥ�
        banana.Rotate(0, 0, 10);
        cherries.AddForce(new Vector2(0, 10));
    }

}
