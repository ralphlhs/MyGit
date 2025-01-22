using UnityEngine;
using UnityEngine.UI;
using TMPro;
using PowerDefences;
using Assets.MapleStory;

// ������ ���� ���� �ڵ忡�� ����ϴ� ���Դϴ�.
// ����Ƽ���� ����Ƽ�� Ȱ���� �۾��ϴ� ��Ʈ��Ʈ��� �ݵ�� �߰�.

/// <summary>
/// ó������ ���� ����Ƽ�� ��ũ��Ʈ
/// </summary>

public class GameStart : MonoBehaviour
    //�� Ŭ������ �������� ���, ����Ƽ ���� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� �����Ҽ� �ְ� ���ݴϴ�. 
    //�߰������� ����Ƽ���� �������ִ� ����� ����� �� ����մϴ�. 
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
        //Debug.Log($"{count} �¿� �ݺ� �ٱ�");
        //count++;
    }

    /// <summary>
    /// �׷���.
    /// </summary>
    public void ScripChange()
    {
        test.text = "���� ����!";
    }
}
