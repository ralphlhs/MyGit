
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    //Circle�� ������ ��ġ�� Lerp ��Ű�� ��ũ��Ʈ.

    public GameObject Circle;
    Vector3 pos = new Vector3 (5, -3, 0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Circle.transform.position = Vector3.Lerp(Circle.transform.position, pos, Time.deltaTime);
        //0�� �Է��� ��� �������� �ʽ��ϴ�. 1�� �ִ�ġ�Դϴ�. 
        //������ �ӵ��� ��ǥ �������� �̵��ϰ� ����� ��ũ��Ʈ
        //Vector3.MoveTowards(��������, �� ����, �̵� �ӵ�;
        //Circle.transform.position = Vector3.MoveTowards(Circle.transform.position, pos, Time.deltaTime);

        Circle.transform.position = Vector3.Slerp(Circle.transform.position, pos, Time.deltaTime);
    }
}
