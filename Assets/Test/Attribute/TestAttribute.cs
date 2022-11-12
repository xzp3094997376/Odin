using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class TestAttribute : MonoBehaviour
{
    [EnumPaging, OnValueChanged("SetCurrentTool")]
    [InfoBox("Example of using EnumPaging together with OnValueChanged.")]
    public UnityEditor.Tool SceneTool;

    private void SetCurrentTool()
    {
        UnityEditor.Tools.current = this.SceneTool;
    }




    [InfoBox("You can also assign the min max values dynamically by refering to members.")]
    [MinMaxSlider("DynamicRange", true)]
    public Vector2 DynamicMinMax;//最大最小值通过DynamicRange控制

    [MinMaxSlider("Min", 10f, true)]
    public Vector2 DynamicMin;//最小值通过DynamicRange.x控制

    [MinMaxSlider(0f, "Max", true)]
    public Vector2 DynamicMax;//最大值通过DynamicRange.y控制
    
    public Vector2 DynamicRange;

    public float Min()
    {   
        return this.DynamicRange.x;
    }
    //public float Min { get { return this.DynamicRange.x; } }

    public float Max { get { return this.DynamicRange.y; } }
}
