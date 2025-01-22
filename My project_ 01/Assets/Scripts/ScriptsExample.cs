using UnityEngine;
using TMPro;
using UnityEngine.UI;

// ����Ƽ ��Ʈ����Ʈ (Unity Attribute)
// ����Ƽ �����Ϳ� �°� ��ũ��Ʈ�� Ŀ�����ϴ°��� �����մϴ�. 
[AddComponentMenu("CustomUtility/ScripExample")]
public class ScriptsExample : MonoBehaviour
{
    [Range(1, 99)]
    public int level;

    [Range(0, 100)]
    public int volume;

    [Header("�÷��̾��� �̸�")]
    public string player_name;

    [TextArea]
    public string talk01;
    [TextArea(1, 3)]
    public string talk02;
    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("üũ�Ǹ� ���� �������� �ǹ��մϴ�.")]
    public bool isDead = true;
    // �Լ�(Function) C#������ Ŭ���� ���ο��� ����Ǵ� �Լ��� �޼ҵ��� �θ��ϴ�. 

    // �Լ��� Ư�� �ϳ��� ����� �����ϱ� ���� �ۼ��� ��ɹ� ����ü.
    // �ڵ峻���� ����� �Լ��� ���ϴ� �۾� ��ġ���� ȣ���� ���� ����� �� �ֽ��ϴ�. 

    // �Լ��� ���� ���
    // �ڷ���, �Լ��� �̸�(�Ű�����)
    // {
    //   �Լ��� ȣ��������, ������ ��ɹ��� �ۼ��ϴ� �ڸ�;
    // }

    // �Լ�ȣ����
    // �Լ��̸�(����);
    // �Ű����� : �Լ��� ȣ���Ҷ�, ���޹��� �����Ϳ� ���� ǥ��
    // ���� : �Լ��� ȣ���Ҷ� ������ ��.

    [ContextMenu("HelloEveryone")]
    void HelloEveryone() {
        Debug.Log("�����е� ��� �ȳ��ϼ���.");
    }

    void HelloSomeone(string who) {
        Debug.Log($"{who}�� �ȳ��ϼ���.");
    }

    public TextMeshProUGUI textMeshPro;

    public TMP_InputField inputField;

    public void ChangeName()
    {
        textMeshPro.text = inputField.text;
    }
}
