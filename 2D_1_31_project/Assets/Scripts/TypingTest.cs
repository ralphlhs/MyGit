using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingTest : MonoBehaviour
{
    public Text message; // Ÿ������ �ؽ�Ʈ.
    [SerializeField] [TextArea] private string content; //����� ����.
    [SerializeField] private float delay = 0.1f; // �д� �ӵ�

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    public void OnMassageclick()
    {
        StartCoroutine("Typing");
    }

    public void ByTwo()
    {
        if (delay == 0.5f)
            delay = 0.1f;
        else delay = 0.5f;
    }
    IEnumerator Typing()
    {
        message.text = "";
        int typing_count = 0;
        while (typing_count != content.Length)
        {
            if (typing_count < content.Length)
            {
                message.text += content[typing_count].ToString();
                typing_count++;
            } 
            yield return new WaitForSeconds(delay);
        }
       
        //���� delay��ŭ ����Ѵ�.
    }

}
