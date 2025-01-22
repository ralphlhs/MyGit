using UnityEngine;
using UnityEngine.UI;
using TMPro;
using PowerDefences;
using Assets.MapleStory;

// 다음에 적힌 것을 코드에서 사용하는 중입니다.
// 유니티에서 유니티를 활용해 작업하는 스트립트라면 반드시 추가.

/// <summary>
/// 처음으로 만들어본 유니티의 스크립트
/// </summary>

public class GameStart : MonoBehaviour
    //는 클래스에 연결했을 경우, 유니티 씬에 존재하는 오브제트에 스크립트를 연결할수 있게 해줍니다. 
    //추가적으로 유니티에서 제공해주는 기능을 사용할 때 사용합니다. 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private TextMeshProUGUI test;

    private QuestMaker q;

    void Start()
    {
        test.text =  "Game Re-start!";
    }
    int count = 0;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{count} 좌우 반복 뛰기");
        //count++;
    }

    /// <summary>
    /// 그렇군.
    /// </summary>
    public void ScripChange()
    {
        test.text = "게임 시작!";
    }
}
