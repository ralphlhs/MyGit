using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//플레이어의 이동 (리지드 바디)
// 해당 기능을 통해 이 스크립트를 컴포넌트로서 사용할 경우 
// 적어놓은 컴포넌트를 요구하게 됩니다. 
// 1. 해당 컴포넌트가 없는 오브젝트에 연결한 경우에는 자동은 연결을 진행
// 2. 이 스크립트가 연결된 상태라면 그 오브젝트는 대상의 컴포넌트를 제거할 수 없습니다.
[AddComponentMenu("LHS/Movement")]
[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    public int getCount = 0;
    public int jumpCount;
    public String count = "점수";
    public double jump_force = 3.5; // double은 3.0뒤에 f를 안쓴다. 소수점 6자리까지 정확하게 계산.
    public bool is_Jump = false;
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI textMeshPro1;
    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();  
        // GetComponent<T> 해당컴포넌트의 값을 얻어오는 기능. T에는 컴포넌트의 형태를 작성해줍니다.
        // 컴포넌트의 형태가 다르다면 오류 발생
        // 해당데이터가 존재하지 않을 경우라면 null을 반환하게 됩니다. 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        float _x = Input.GetAxisRaw("Horizontal");
        float _y = Input.GetAxisRaw("Vertical");
        // GetAxisRaw('키이름')은 인풋 매니저의 키를 얻어오면서 클릭에 따라 -1,0,1 수치로 값을 얻어옵니다. 
        // Horizontal : 수평 이동 a,d 키나 키보드의 왼쪽, 오른쪽 키
        // Vertical :  수직 이동 w,s 키나 키보드의 위쪽, 아래쪽 키
        // 위의 코드를 통해 움직일 방향을 계산합니다.
        Vector3 _velocty = new Vector3(_x, _y, 0) * speed * Time.deltaTime; // 속력 = 방향 * 속도;

        transform.position += _velocty;
    }

    private void Jump()
    {
        //사용자가 키보드 Space 키를 입력한다면
        if (Input.GetKeyDown(KeyCode.Space)) {
            //!는 조건의 반대로 처리하는 경우 false
            //조건의 결과가 true일 경우 false
            //조건의 결과가 false일 경우 true
            if (!is_Jump)
            {
                is_Jump = true; // 점프상태로 변경합니다.
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
                // type casting 
                // (타입이름) 변수를 통해 해당 변수를 설정된타입으로 변경
                // 단 캐스팅이 가능한 범위내에서
                // 주로 int => float 같은 경우는 가능
                // 데이터 타입이 서로 호환되지 않는 경우라면 사용 불가.
            }
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 유니티에서 크기를 비교하는 연산자.
        // a == b 크기가 같다.
        // a!= b 크기가 다르다.
        // 충돌체의 게임 오브젝트의 레이어가 7과 비교했을때 크기가 같다면
        if (collision.gameObject.layer == 7) {
            is_Jump = false;
            jumpCount++;
            textMeshPro1.text = jumpCount.ToString() + " 번 뛰었습니다.";
        }
        Debug.Log("땅을 밟았습니다.");

        if (collision.gameObject.layer == 8)
        {
            getCount++;
            textMeshPro.text = getCount.ToString() + " 를 먹었습니다.";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("골인!");
            SceneManager.LoadScene(0);
        }
    }







}
