using UnityEngine;
using TMPro;
//using static UnityEngine.Rendering.DebugUI;

public class Pighooter : MonoBehaviour
{
    public GameObject gameObject2;
    public TextMeshProUGUI text;

    // 발사 기능을 제공해주는 클주는 역할도 진행합니다. 
    void Start()
    {
    }


    /// <summary>
    /// 물체를 발사하는 기능을 가진 함수(메소드)
    /// </summary>
    

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //GetComponentInChildren<ParticleSystem>().Play();
       

        if (collision.gameObject.tag == "Pig")
        {
            gameObject2.SetActive(false);
            Destroy(gameObject2, 1.0f);
   
            text.text = "돼지가 죽었다!!";
        }
        else
        {
            //objectGenerator.GetComponent<ObjectGenerator>().ScorePlus(10);
        }


    }

}