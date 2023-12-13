using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{

    // 버튼 클릭 시 호출될 함수
    public void OnButtonClick()
    {
        // 디버그 테스트
        Debug.Log("해치웠나?");

        //Scene전환!
        SceneManager.LoadScene("DepositScene");
    }

}
