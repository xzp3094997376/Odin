using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Test : SerializedMonoBehaviour //要使用Odin的序列化功能需要改为从这个类型派生
{
    [BoxGroup("Data_A")]
    public int[,] Data_A = new int[3, 3];
    public int[][] Data_B = new int[3][];
    public List<List<int>> Data_C = new List<List<int>>();
    public Dictionary<string, int> Data_D = new Dictionary<string, int>();


    public enum SomeEnum
    {
        First, Second, Third, Fourth, AndSoOn
    }

    public SomeEnum se;

    [System.Flags]




    public enum SomeBitmaskEnum
    {
        A = 1 << 1,
        B = 1 << 2,
        C = 1 << 3,
        All = A | B | C
    }

    public SomeBitmaskEnum sonBitmaskEnum;
}
