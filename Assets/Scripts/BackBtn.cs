using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BButtonClick : MonoBehaviour
{
       
    public void OnButtonClick()
    {
        // ����� �׽�Ʈ
        //Debug.Log("�־ȵ���?");
        //�̱��� Ȱ��


        //Scene��ȯ!
        SceneManager.LoadScene("MainScene");
    }
 
}
