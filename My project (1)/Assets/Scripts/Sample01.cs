using UnityEngine;

[AddComponentMenu("LHS/Sample01")]

public enum RAINBOW
{
    빨, 주, 노, 초, 파, 남, 보
}
public class Sample01 : MonoBehaviour
{

    public bool isJump;
    public string[] basket;
    public int money;

    [Range(1, 99)]
    public float fieldOfView;

    public RAINBOW rainbow;






    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

