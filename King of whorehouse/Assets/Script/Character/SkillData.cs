using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillData
{
    private int __id;
    public int value;
    public string name;

    public int Id { get => __id; }

    public SkillData(int id, int value, string name)
    {
        __id = id;
        this.value = value;
        this.name = name;
    }

    //加减来改变值
    public void ChangeValue(int value)
    {
        SetValue(this.value + value);
    }

    public void SetValue(int value)
    {
        this.value = value;
        if (this.value < 0)
            this.value = 0;
        if (this.value > GeneralConst.C_SKILL_MAX)
            this.value = GeneralConst.C_SKILL_MAX;
    }
}
