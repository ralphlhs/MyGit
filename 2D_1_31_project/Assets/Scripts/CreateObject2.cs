using System;
using UnityEngine;

[AddComponentMenu("LHS/CreateObject")]

public class CreateObject2 : MonoBehaviour
{

    public GameObject prefab;

    private GameObject square;
   
    void Start()
    {
       

       // Destroy(square, 5.0f);
    }
    //int x = Random.Range(1, 45);
    // Update is called once per frame
    void Update()
    {
    }

    public void Destroys()
    {
        Destroy(square);
    }

    public void Create()
    {
        square = Instantiate(prefab);
    }
}
