using UnityEngine;
using UnityEngine.SceneManagement;  //引用 場景管理 命名空間，可以使用API
/// <summary>
/// 場景控制
/// 1.可以切換場景
/// 2.可以離開遊戲
/// </summary>

public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 載入場景
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("關卡 1");
    }

    //unity 按鈕與程式溝通方式
    //1.公開方法
    //2.按鈕 Button 元件 on click 可以指定此方法
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();     //應用程式.離開()-關閉遊戲，unity內不用執行
    }
}
