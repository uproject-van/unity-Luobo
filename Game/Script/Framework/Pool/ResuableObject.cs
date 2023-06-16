using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//复用的抽象类
public abstract class ResuableObject : MonoBehaviour,IReusable
{
    public abstract void onSpawn();

    public abstract void onUnspawn();
}
