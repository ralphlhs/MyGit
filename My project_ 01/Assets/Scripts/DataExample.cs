using System;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    �� = 1 << 0, 
    �� = 1 << 1,
    ȭ = 1 << 2,
    �� = 1 << 3,
    �� = 1 << 4,
    �� = 1 << 5,
    �� = 1 << 6
}

public enum JOB
{
    ������, ������, �����, ����, �ҹ��
}

public class DataExample : MonoBehaviour
{
    public string[] schedules = new string[] { }; // �迭, ���� �������� ����
    public DAY workDay;
    public JOB job;

    private void Start()
    {
        // ������ ��ü�� ������ ����մϴ�.
        for (int i = 0; i < schedules.Length; i++)
        {
            Debug.Log(schedules[i]);
        }
        Debug.Log(workDay);
        Debug.Log(job);
    }
}
