using UnityEngine;
/// <summary>
/// ��V�]�w�t�α���
/// </summary>

public class Player : MonoBehaviour
{
    //�]�B�t�� ���D�t�� �O�_�Ʀ� �O�_���`
    //�ʵe�ѼƸ��D �Ʀ�P���`
    //����ݩ� Attribute
    //Header ���D
    //Range �d��:�ȭ��ƭȫ��A���,float int
    //Tooltip ����
    [Header("�]�B�t��"), Range(0,500)]
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

}
