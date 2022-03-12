using UnityEngine;
/// <summary>
/// ��V�]�w�t�α���
/// </summary>

public class Player : MonoBehaviour
{
    #region ���
    //�]�B�t�� ���D�t�� �O�_�Ʀ� �O�_���`
    //�ʵe�ѼƸ��D �Ʀ�P���`
    //����ݩ� Attribute
    //Header ���D
    //Range �d��:�ȭ��ƭȫ��A���,float int
    //Tooltip ����
    [Header("�]�B�t��"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("���D����"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("�x�s����O�_�Ʀ�")]
    public bool isSlide;
    [Tooltip("�x�s����O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "�}���Ʀ�";
    public string parameterDead = "Ĳ�o���`";

    [Header("���D����")]
    public KeyCode keyJump = KeyCode.Space;

    //�s��transform���Ĥ@�ؤ覡
    //public Transform traPlayer;

    //�ݩʭ��O...>Debug �Ҧ��i�H�ݨ�p�H���
    private Rigidbody2D rig;
    [Header("���D�q�Ƴ̤j��"), Range(0, 5)]
    public int countJumpMax = 2;
    public int countJump;
    [Header("�ˬd�a�O�첾")]
    public Vector3 v3GroundOffset;
    [Header("�ˬd�a�O�ؤo")]
    public Vector3 v3GroundSize = Vector3.one;
    [Header("�a�O���ϼh")]
    public LayerMask layerGround;
    //private Animation aniold;   //�ª� �ʵe�t��
    //private Animator aninew;    //�s�� �ʵe�t��
    private Animator ani;

    [Header("�Ʀ����")]
    public KeyCode KeySlide = KeyCode.DownArrow;

    public CapsuleCollider2D cc2d;


    #endregion


    #region �ƥ�
    //ø�s�ϥܨƥ�:�bunity��ø�s���U�Ϊ��ϥܡA�]�t:�u�B��ΡB��δX��ϧ�(�����Ҥ��|����)
    private void OnDrawGizmos()
    {
        //1�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.35f);
        //2.ø�s�ϥ�
        //�ϥ�.ø�s����(�����I�A�ؤo)
        Gizmos.DrawCube(transform.position + v3GroundOffset, v3GroundSize);
    }

    private void Start()
    {
        //GetComponent<��������>-<>�x���A�Ҧ�����
        //���o���w����
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();
        //���D�q�� ���w�� �̤j��
        countJump = countJumpMax;
    }

    private void Update()
    {
        Run();
        Jump();
        Slide();
    }
    #endregion
    

    #region ��k
   

    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {
        //�s��transform���Ĥ@�ؤ覡
        //���a�첾,�ܦ�(x�Ay�Az)
        //Time.daltaTime �@�V���ɶ�
        //traPlayer.Translate(speed * Time.deltaTime, 0, 0);

        //�s��transform���ĤG�ؤ覡
        //1.��n����transform�P���b����P�@���h
        //�y�k:
        //transform.�����W��
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        //�O�_���U���D=��J.���o������U(���w����)
         bool intputJump=Input.GetKeyDown(keyJump);
        //print("�O�_���U���D" + intputJump);

        //�p�G ���U���D�åB���D�q�Ƥj��s�N���W��
        if (intputJump&&countJump>0)
        {
            //print("���D");
            //����A�K�[���O(�G���V�q)
            rig.AddForce(new Vector2(0, jump));
            //���D���ɭԡA����ƴ�@
            countJump--;
            //�ʵe.�]�wĲ�o(�ʵe�ѼƦW��)
            ani.SetTrigger(parameterJump);
        }
        //2D�I��=2D���z.����л\(�����I,�ؤo,����,�ϼh)
        Collider2D hit = Physics2D.OverlapBox(transform.position + v3GroundOffset, v3GroundSize, 0, layerGround);
        print("���a�����O�[�t��" + rig.velocity);
        //�p�G2D�I������s�b�åB���骺�[�t��Y<0(���U����)
        if (hit &&rig.velocity.y<0)
        {
            //���D���� ���w �̤j���D����
            countJump = countJumpMax;
        }
    }
    /// <summary>
    /// �Ʀ�
    /// </summary>
    private void Slide()
    {
        //�P�_�O�_�Ʀ�
        //��s�Ʀ�ʵe
        if (Input.GetKey(KeySlide))
        {
            ani.SetBool(parameterSlide, true);
            //�Ʀ� 0.2,-0.85/2,1.2
            cc2d.offset = new Vector2(0.2f, -0.85f);
            cc2d.size = new Vector2(2, 1.2f);
            cc2d.direction = CapsuleDirection2D.Horizontal;
            
        }
        else
        {
            ani.SetBool(parameterSlide, false);
            //���� 0.2.-0.3/1.2,2.5
            cc2d.offset = new Vector2(0.2f, -0.3f);
            cc2d.size = new Vector2(1.2f, 2.5f);
            cc2d.direction = CapsuleDirection2D.Vertical;

        }
        //��s�Ʀ�I����
        //���� 0.2.-0.3/1.2,2.5

    }

    #endregion
}
