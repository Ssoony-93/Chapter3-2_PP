using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WButtonClick : MonoBehaviour
{
       
    public void OnButtonClick()
    {
        // 디버그 테스트
        //Debug.Log("왜안되지?");
        //싱글톤 활용


        //Scene전환!
        SceneManager.LoadScene("WithDrawalScene");
    }
 
}
