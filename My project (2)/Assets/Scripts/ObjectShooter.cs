using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;

[RequireComponent(typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    public GameObject objectGenerator;
    public GameObject objectGenerator2;
    
    // 발사 기능을 제공해주는 클라스
    // 충돌시 오브젝트를 고정시켜주는 역할도 진행합니다. 
    void Start()
    {
        objectGenerator = GameObject.Find("ObjectGenerator");
        objectGenerator2 = GameObject.Find("Pig");
        //씬에서 해당 이름을 가진 게임오브젝트를 찾아 그 값을 얻어오는 GameObject.Find("")기능
        //objectGenerator = GameObject.FindWithTag("ObjectGenerator");
        //obj = FindObjectOfType<ObjectGenerator>();<>안에 넣어준 타입에 맞는 오브젝트를 탐색
        //가장 쉬운건 Find()
        //하지만 검색 범이가 너무많아 지면 불필요하게 성능 저하가 발생할 수 있음.
        // 따라서 그때부터 Tag나 Type등으로 검색 범위를 제한해서 찾는 방식을 사용.
    }


    /// <summary>
    /// 물체를 발사하는 기능을 가진 함수(메소드)
    /// </summary>
    public void Shoot(Vector3 direction)
    {
        gameObject.GetComponent<Rigidbody>().AddForce (direction, ForceMode.Impulse);
        Debug.Log("맞았습니다.");
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
