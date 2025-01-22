using UnityEngine;

/// <summary>
/// ť�긦 ȸ����Ű�� Ŭ����.
/// </summary>
public class Cube_rotate : MonoBehaviour
{
    #region �ʱ⳻��
    // �ڷ��� (type) ���α׷��� �����͸� �Ǵ��ϴ� ����
    // int: integer. float:Float. bool:Boolean(True, False). string : ������ ������ ǥ���մϴ�(����)
    // ���� : � Ư�� �� �ϳ��� �����ϱ� ���� �̸��� ���� �������.
    #endregion[Tooltip(����)]

    private Transform trans;
    #region ����
    public float x;
    public float y; //����Ƽ �����Ϳ��� �����Ǵ� ����
    public float speed;
    private int sample; // ����Ƽ �����Ϳ��� �����ȵǴ� ����
    #endregion

    Vector3 vec = new Vector3();

    #region �Լ�
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans =  GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.trans.Rotate(vec.x, (y+20)*Time.deltaTime, vec.z);
        this.trans.Rotate(new Vector3(x * Time.deltaTime, y * Time.deltaTime, 0));
        //FPS (Frame Per Second) : �ʴ� ������
        //deltaTime : �� �������� �Ϸ�Ǳ� ���� �ɸ��� �ð�
        Moving();
    }
    #endregion

    void Moving()
    {
        float horizontal = Input.GetAxis("Horizontal");
        this.trans.position += new Vector3(horizontal * speed * Time.deltaTime, 0, 0);
        float vertical = Input.GetAxis("Vertical");
        this.trans.position += new Vector3(0, 0, vertical * speed * Time.deltaTime);
    }
}
