using UnityEngine;

[AddComponentMenu("LHS/Sample01")]

public enum RAINBOW
{
    ��, ��, ��, ��, ��, ��, ��
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

