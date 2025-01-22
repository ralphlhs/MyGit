using System;
using UnityEngine;

[Flags]
public enum FRUIT
{
    None = 0,
    사과 = 1 << 0,
    배 = 1 << 1,
    귤 = 1 << 2,
    바나나 = 1 << 3,
    망고 = 1 << 4,
    감 = 1 << 5,
    블루베리 = 1 << 6
}
public enum RAINBOW
{
    빨, 주, 노, 초, 파, 남, 보
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
