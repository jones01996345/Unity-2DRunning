using UnityEngine;  
// �ޥ�  Unity �����Ŷ��A���ڭ̥i�H�ϥθ̭���API(�ܮw)
// ���O���O�W��(�����P�ɮצW�٬ۦP�A�j�p�g�����@��)
public class Car : MonoBehaviour
{
    //�����O�����e
    #region ��� Field
    // ���y�k
    // �׹��� ������� ���W�� (���I �w�]��) ����
    // �|�j�`�θ������
    // ��  �� int
    // �B�I�� float
    // �r  �� string
    // ���L�� bool
    // �׹���
    // �p�H:�����~����Ʀs���A�w�]�A�����private
    // ���}:���\�~����Ʀs���A���public
    public int cc = 1000;
    public float weight=3.5f;       //f��F
    public string brand="���h";     //""�]��
    public bool haswindow=true;    //ture   false
    // Unity �`�Ϊ��������
    // �C�� Color
    // �T�w�C��
    public Color ColorA;
    // ���w�C��
    public Color yellow = Color.yellow;
    public Color blue = Color.blue;
    // �۩w�C��
    public Color ColorB = new Color(0.5f, 0, 0.5f);
    public Color ColorC = new Color(0, 0.5f, 0.5f,0.5f);
    // �V�q Vector 2~4
    public Vector2 Vector2;
    public Vector2 V2Right = Vector2.right;
    public Vector2 V2Up = Vector2.up;
    public Vector2 V2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f);
    //��J����
    public KeyCode Key;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forward = KeyCode.W;
    public KeyCode weapon1 = KeyCode.Alpha1;    //�������
    //public KeyCode 
    public KeyCode mouseL = KeyCode.Mouse0;     //�ƹ�����
    public KeyCode mouseR = KeyCode.Mouse1;     //�ƹ��k��
    //�C������(Hierearchy ���զ�u���ϥ�)  �w�s�� Prefab(�ŦⲰ�l)
    public GameObject goCamer;
    public GameObject goApple;
    public GameObject goTrap;
    public GameObject goFireTrap;
    //����   Component
    //�i�x�s�ݩʭ��O�W�Ҧ�����r����
    //�Хh���Ů�
    public Transform traCar1;
    public Transform teaCamera;
    public Camera cam;
    public SpriteRenderer spr;
    public SpriteRenderer spr2;

    


    #endregion
    

}
//�D�T����ƵL�k����
