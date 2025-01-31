using UnityEngine;

public class VectorSample2 : MonoBehaviour
{
    //VectorSample�� ���� ����.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1. Normalization(����ȭ)
        // --> ������ ũ�⸦ 1�� �����մϴ�.
        // ���� ������ ������ ũ�⸸ 1�� ����.
        // ũ�⸦ 1�� �����ϸ� ������ ���⸸ ����ϸ� ���� ������ ó���ϱ� ����.
        // ��ǥ���� ����) �Է����� ĳ������ 3D �̵� ���� �� �̵��� �밢�� ���.
        // �Ϲ����� ���� ���⺸�� �̵��ӵ��� �� ���� ��Ȳ�� �߻��� �� ����.
        Vector3 a = new Vector3(1, 2, 0).normalized;

        //2. �� ���� ������ �Ÿ� ���:
        Vector3 positionA = new Vector3(1, 2, 3);
        Vector3 positionB = new Vector3(4, 5, 6);

        float distance = Vector3.Distance(positionA, positionB);
        //�� ������ ������ ũ�Ⱑ ���˴ϴ�.

        //3. ���� ����(Linear Interpolation) -> Lerp
        //--> �� ���� ���� �����Ǿ����� �� ���̿� ��ġ�� ���� �����ϱ� ���� �����Ÿ��� ���� ���������� ����ϴ� ���.
        Vector3 Result = Vector3.Lerp(positionA, positionB, 0.5f);
        // ex) A������ (2, 1)�̰� B������ (6,4)�϶� �� ������ ���� C�� X��ǥ�� �־����ٸ�
        // Y ��ǥ���� �� �� �ֽ��ϴ�.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
