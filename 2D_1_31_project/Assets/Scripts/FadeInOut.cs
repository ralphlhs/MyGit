using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public RawImage images;
    private Color color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        images = GetComponent<RawImage>();
        images.color = Color.cyan;
    }

    public void OnColorChangeclick()
    {
        StartCoroutine("Fade");
    }
    IEnumerator Fade()
    {
        
        yield return new WaitForSeconds(1.0f);
        //images.color = Color(12);
    }


    //void Typing()
    //{
    //    message.text = "";
    //    int typing_count = 0;
    //    while (typing_count != content.Length)
    //    {
    //        if (typing_count < content.Length)
    //        {
    //            message.text += content[typing_count].ToString();
    //            typing_count++;
    //        }
    //        yield return new WaitForSeconds(delay);
    //    }

    //    //현재 delay만큼 대기한다.
    //}
}
