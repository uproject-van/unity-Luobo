using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _m_instance = null;

    public T instance
    {
        get
        {
            return _m_instance;
        }
    }

    protected virtual void Awake()
    {
        _m_instance = this as T;
    }
}
