using UnityEngine;
using UnityEngine.SceneManagement;  //�ޥ� �����޲z �R�W�Ŷ��A�i�H�ϥ�API
/// <summary>
/// ��������
/// 1.�i�H��������
/// 2.�i�H���}�C��
/// </summary>

public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// ���J����
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
    }

    //unity ���s�P�{�����q�覡
    //1.���}��k
    //2.���s Button ���� on click �i�H���w����k
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();     //���ε{��.���}()-�����C���Aunity�����ΰ���
    }
}
