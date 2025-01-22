using UnityEngine;

/// <summary>
/// 큐브를 회전시키는 클래스.
/// </summary>
public class Cube_rotate : MonoBehaviour
{
    #region 필기내용
    // 자료형 (type) 프로그램이 데이터를 판단하는 기준
    // int: integer. float:Float. bool:Boolean(True, False). string : 문자의 집합을 표현합니다(묶음)
    // 변수 : 어떤 특정 값 하나를 저장하기 위해 이름을 붙인 저장공간.
    #endregion[Tooltip(내용)]

    private Transform trans;
    #region 변수
    public float x;
    public float y; //유니티 에디터에서 공개되는 변수
    public float speed;
    private int sample; // 유니티 에디터에서 공개안되는 변수
    #endregion

    Vector3 vec = new Vector3();

    #region 함수
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
        //FPS (Frame Per Second) : 초당 프레임
        //deltaTime : 전 프레임이 완료되기 까지 걸리는 시간
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
