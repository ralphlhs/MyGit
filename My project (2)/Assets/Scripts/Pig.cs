using UnityEngine;
using TMPro;
//using static UnityEngine.Rendering.DebugUI;

public class Pighooter : MonoBehaviour
{
    public GameObject gameObject2;
    public TextMeshProUGUI text;

    // �߻� ����� �������ִ� Ŭ�ִ� ���ҵ� �����մϴ�. 
    void Start()
    {
    }


    /// <summary>
    /// ��ü�� �߻��ϴ� ����� ���� �Լ�(�޼ҵ�)
    /// </summary>
    

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //GetComponentInChildren<ParticleSystem>().Play();
       

        if (collision.gameObject.tag == "Pig")
        {
            gameObject2.SetActive(false);
            Destroy(gameObject2, 1.0f);
   
            text.text = "������ �׾���!!";
        }
        else
        {
            //objectGenerator.GetComponent<ObjectGenerator>().ScorePlus(10);
        }


    }

}