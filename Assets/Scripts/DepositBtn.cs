using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DButtonClick : MonoBehaviour
{

    // 버튼 클릭 시 호출될 함수
    public void OnButtonClick()
    {
        // 디버그 테스트
        //Debug.Log("왜안되지?");
        //싱글톤 활용


        //Scene전환!
        SceneManager.LoadScene("DepositScene");
    }

}