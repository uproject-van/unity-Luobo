using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//一个复用类的接口
public interface IReusable
{
    //取出
    void onSpawn();
    //释放
    void onUnspawn();
}
