using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;

[RequireComponent(typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    public GameObject objectGenerator;
    public GameObject objectGenerator2;
    
    // �߻� ����� �������ִ� Ŭ��
    // �浹�� ������Ʈ�� ���������ִ� ���ҵ� �����մϴ�. 
    void Start()
    {
        objectGenerator = GameObject.Find("ObjectGenerator");
        objectGenerator2 = GameObject.Find("Pig");
        //������ �ش� �̸��� ���� ���ӿ�����Ʈ�� ã�� �� ���� ������ GameObject.Find("")���
        //objectGenerator = GameObject.FindWithTag("ObjectGenerator");
        //obj = FindObjectOfType<ObjectGenerator>();<>�ȿ� �־��� Ÿ�Կ� �´� ������Ʈ�� Ž��
        //���� ����� Find()
        //������ �˻� ���̰� �ʹ����� ���� ���ʿ��ϰ� ���� ���ϰ� �߻��� �� ����.
        // ���� �׶����� Tag�� Type������ �˻� ������ �����ؼ� ã�� ����� ���.
    }


    /// <summary>
    /// ��ü�� �߻��ϴ� ����� ���� �Լ�(�޼ҵ�)
    /// </summary>
    public void Shoot(Vector3 direction)
    {
        gameObject.GetComponent<Rigidbody>().AddForce (direction, ForceMode.Impulse);
        Debug.Log("�¾ҽ��ϴ�.");
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        GetComponentInChildren<ParticleSystem>().Play();
        if (collision.gameObject.tag == "terrain")
        {
            Destroy(gameObject, 1.0f);
        }

        else if (collision.gameObject.tag == "Pig")
        {
            Destroy(objectGenerator2, 0.3f);
            objectGenerator.GetComponent<ObjectGenerator>().PigKilling();
        }
        else {
            objectGenerator.GetComponent<ObjectGenerator>().ScorePlus(10);
        }
    }
}
