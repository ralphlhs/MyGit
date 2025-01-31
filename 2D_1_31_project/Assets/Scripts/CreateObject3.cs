using UnityEngine;

public class CreateObject3 : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject sample;

    [SerializeField]
    private int dummy;

    //직렬화
    //데이터나 오브젝트를 재구성 할 수 있는 형태(포맷)으로 변환하는 과정 
    //유니티에서는 간단하게 private 형태의 데이터를 인스펙터에서 읽을수 있게 설정해준다라고 이해해.

    private void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/TableBody Variant");
        // Resources.Load<T>("폴더위치/에셋명");
        // T는 데이터의 형태를 적어주는 위치입니다. 
        //Sprite sprite = Resources.Load<Sprite>("Sprites/sprite01");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sample = Instantiate(prefab);
            sample.AddComponent<VectorSample>().Haha();
            //gameObject.AddComponent<T>
            //오브젝트에 컴포넌트 기능을 추가하는 기능입니다.
            //GetComponent<T>
            //오브젝트가 가지고 있는 컴포넌트의 기능을 얻어오는 기능.
            //스크립트에서 해당 컴포넌트의 기능을 가져와서 사용하고 싶을 경우 사용합니다. 
        }
    }

}
