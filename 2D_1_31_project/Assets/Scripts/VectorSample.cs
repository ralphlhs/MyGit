using UnityEngine;

public class VectorSample : MonoBehaviour
{

    //기본 벡터 (x, y, z)순으로 값이작성.
    //0,0,0

    Vector3 vec = new Vector3();
    float x, y, z;


    //유니티 기본 벡터(제공 값);
    //Vector3 a = Vector3.up;
    //up(0,1,0), down(0,-1,0), left(-1,0,0), right(1, 0, 0), forward(0,0,1), back(0,0,1) one(1,1,1) zero(0,0,0)
    //벡터 기본 연산(덧셈, 뺄셈, 나눗셈, 곱셈)
    Vector3 a = new Vector3(1, 2, 0);
    Vector3 b = new Vector3(3, 4, 0);
    float point = 5.0f;
    Vector3 some = Vector3.zero;

    Vector3 Asite = new Vector3(10, 0, 0);
    Vector3 Bsite = new Vector3(5, 0, 0);


    void Start()
    {
        //덧셈 : 단계적으로 하나씩 차례대로 처리한다.
        //순서가 변경되어도 결과는 같습니다. 
        //특정 포지션에서 점프한 느낌의 계산 처리.
        Vector3 c = a + b;
        var trap_air = some + new Vector3(0, point);
        //var는 C#에서 값을 기준으로데이터를 자동으로 설정하는 키워드입니다. 
        //현재 코드 기준으로는 뒤의 값이 Vector3 이기 때문에 var는 Vector3.

        //뺄셈
        //한 오프젝트에서 다른 오브젝트까지의 거리와 바향을 구하는 상황에 사용합니다. 
        //뺄셈의 경우는 순서가 중요합니다.
        Vector3 d = a - b;
        Vector3 distance = Asite - Bsite;
        //이 거리를 측정 후 지정한 거리와 같거나 가깝다면 공격해라 같은 코드를 짜기 좋습니다. 

        //곱셈
        //벡터의 각 성분에 스칼라 값을 곱합니다. 
        //벡터 * 스칼라 => 원본가 동일한 방향을 가리키는 벡터.
        //방향 자체에는 영향을 안주고 벡터의 크기를 변경하는 경우에 사용합니다. 
        Vector3 e = a * 2;

        Vector3 Positon = Vector3.one;
        Positon = Positon * 4;

        //내적과 외적
        //내적 : 2D, 3D 다 가능.
        // >> 두 벡터의 성분을 곱하고 그 결과를모두 더하는 연산 방식.
        Vector3 k = new Vector3(1, 2, 3);
        Vector3 l = new Vector3(4, 5, 6);

        float dot = Vector3.Dot(k, l);
        //k*l = (k.x * l.x) + (k.y * l.y) + (k.z * l.z);
        //이 계산은 각 좌표가 얼마나 평행한지를 판단합니다.
        // >> 두 벡터 사이의 각도.

        //외적 : 3D에서 사용.(3D 그래픽)
        //법선 벡터 계산 시에 사용됩니다. (법선은 평면이나 직선에 대하여 수직인 것을 의미)
        Vector3 cross = Vector3.Cross(k, l);
        //k*l = (ky * lz - kz*ly, kz*lx * kx *lz, kx*ky = ky * kx)

        //벡터의 크기(벡터의 길이)
        Vector3 m = new Vector3(1, 2, 3);
        float mag = m.magnitude;
        //벡터의 각 성분의 제곱 합의 제곱근


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Haha() {
        Vector3 custom_vec = new Vector3(x, y, z);
        Debug.Log("하하호호");
    }
}
