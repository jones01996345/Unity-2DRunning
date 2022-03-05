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
    /// 延遲載入場景
    /// </summary>
    public void DelayLoadScene()
    {
        //使用MonoBehaviour的API的語法
        //方法名稱(對應引數)
        Invoke("LoadScene", 1.5f);  //延遲呼叫("方法名稱"，延遲秒數) -  延遲1.5秒
    }
    /// <summary>
    /// 載入場景
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("關卡 1");
    }

    public void DelayQuitGame()
    {
        Invoke("QuitGame", 1.5f);
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
