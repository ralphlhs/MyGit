using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextCount : MonoBehaviour
{
    public Text text;
    //public TextMeshProUGUI textMeshPro;
    public int count;
    //�ؽ�Ʈ�� ī��Ʈ�� ����ϴ� ����� ����.
    //ī��Ʈ�� ��� 1�� �����ϴ� ���·� ó��.
    void Start()
    {
        //�ڷ�ƾ �����
        //StartCoroutine("�Լ��� �̸�");
        //1. ���ڿ��� ���� �Լ��� ã�Ƽ� �����ϴ� ���
        //->> ��Ÿ�� �߻��ص� ������ �߻����� ����. ������ ����� ������� ����.
        // StopCoroutine()�� ���� �ܺο��� �����ϴ� ���� �����մϴ�.

        //StopCoroutine(�Լ��̸�());
        //2. �ش� �Լ��� ȣ���� ���� ����� ��ȯ�޴� ����.
        // >> ��Ÿ�߻��� ���� üũ ����.
        // StopCoroutine()�� ���� �ܺο��� �����ϴ� ���� �Ұ����մϴ�.

        StartCoroutine("CountPlus");
        //�ش� �ڷ�ƾ ���� �����
        //StopCoroutine("CountPlus");



        //StartCoroutine(CountPlus());
        //�Լ� ���� ���� ��� 
    }

    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            text.text = count.ToString("N0");
            //N0�� ���� 3�ڸ��� �������� ,�� ǥ���ϴ� format�Դϴ�. 1,000����.
            //yield return null;
            //���� �������� �Ѿ�ϴ�.
            yield return new WaitForSeconds(1);
        }

        /* Debug.Log("�Ͻ�����, ����ũ �׽�Ʈ");
         //yield return new WaitForSeconds(1);
         // yield�� �Ͻ������� CPU�� ������ �ٸ� �Լ��� �����ϴ� Ű�����Դϴ�. 
         Debug.Log("�丸 �԰� �ò�.");
         yield return new WaitForSeconds(5);
         Debug.Log("���� �ٽ� ������.");*/
    }
}
