using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���õĳ�����
public abstract class ResuableObject : MonoBehaviour,IReusable
{
    public abstract void onSpawn();

    public abstract void onUnspawn();
}
