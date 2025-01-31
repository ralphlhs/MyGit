using UnityEditor.Rendering;
using UnityEngine;

[AddComponentMenu("LHS/CreateObject")]

public class CreateObject : MonoBehaviour
{
    public GameObject obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(obj);
        //���� ��� 
        //����� ���� ������ �״�� �����մϴ�. 

        Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
        // ����� ���� �����հ� ��ġ�� ȸ�� ������ �� ������ ������ �����մϴ�.
        // Quaternion.identity = ȸ���� : 0

        //Vector3 : ����� ũ�⸦ �����ϴ� ����. 
        //ĳ������ position, ������Ʈ�� �̵��ӵ�, ������Ʈ ���� �Ÿ� ���� ����� �� ����ϴ� Ŭ����
        //2D -> Vector2 (x, y)
        //3D -> Vector3 (x, y, z)

        //Quaternion : ���� ������Ʈ�� 3���� ������ ����. �� ���⿡�� �ٸ� ���������� ������� ȸ����.
        // ����� ȸ���� �� ǥ�� �� �� �ִ� Ŭ����.
        //180�� ���� ū ���� ���� ǥ���� �Ҽ� ����. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
