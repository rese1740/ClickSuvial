using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingText : MonoBehaviour
{
    public Text uiText; // UI Text 컴포넌트
    public float typingSpeed = 0.5f; // 타이핑 속도

    void Awake()
    {
        Debug.Log(13213213132123.2);
        string message = "End........?";
        StartCoroutine(TypeText(message));
    }

    IEnumerator TypeText(string message)
    {
        uiText.text = ""; // 텍스트 초기화
        foreach (char letter in message.ToCharArray())
        {
            uiText.text += letter; // 한 글자씩 추가
            yield return new WaitForSeconds(typingSpeed); // 대기
        }

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Start");
    }
}

