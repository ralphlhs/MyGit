using System;
using UnityEngine;

[Flags]
public enum FRUIT
{
    None = 0,
    ��� = 1 << 0,
    �� = 1 << 1,
    �� = 1 << 2,
    �ٳ��� = 1 << 3,
    ���� = 1 << 4,
    �� = 1 << 5,
    ��纣�� = 1 << 6
}
public enum RAINBOW
{
    ��, ��, ��, ��, ��, ��, ��
}

[AddComponentMenu("CustomUtility/HyungSeobLEE")]
public class HyungSeobLEE : MonoBehaviour
{

    public bool isJump = true;

    public int money;

    [Range(0, 100)]
    public int fieldView;

    public RAINBOW RAINBOW;
    public FRUIT fruit;

}
