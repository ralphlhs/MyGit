using UnityEngine;

public class CreateObject3 : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject sample;

    [SerializeField]
    private int dummy;

    //����ȭ
    //�����ͳ� ������Ʈ�� �籸�� �� �� �ִ� ����(����)���� ��ȯ�ϴ� ���� 
    //����Ƽ������ �����ϰ� private ������ �����͸� �ν����Ϳ��� ������ �ְ� �������شٶ�� ������.

    private void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/TableBody Variant");
        // Resources.Load<T>("������ġ/���¸�");
        // T�� �������� ���¸� �����ִ� ��ġ�Դϴ�. 
        //Sprite sprite = Resources.Load<Sprite>("Sprites/sprite01");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sample = Instantiate(prefab);
            sample.AddComponent<VectorSample>().Haha();
            //gameObject.AddComponent<T>
            //������Ʈ�� ������Ʈ ����� �߰��ϴ� ����Դϴ�.
            //GetComponent<T>
            //������Ʈ�� ������ �ִ� ������Ʈ�� ����� ������ ���.
            //��ũ��Ʈ���� �ش� ������Ʈ�� ����� �����ͼ� ����ϰ� ���� ��� ����մϴ�. 
        }
    }

}
