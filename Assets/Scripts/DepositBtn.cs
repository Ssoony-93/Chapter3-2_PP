using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{

    // ��ư Ŭ�� �� ȣ��� �Լ�
    public void OnButtonClick()
    {
        // ����� �׽�Ʈ
        Debug.Log("��ġ����?");

        //Scene��ȯ!
        SceneManager.LoadScene("DepositScene");
    }

}
