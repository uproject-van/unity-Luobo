using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : Singleton<Sound>
{
    //��������
    AudioSource _m_bgSound;
    //��Ч
    AudioSource _m_effectSound;

    //��Ƶ�����Դ·��
    public string ResourceDir = "";

    //���ִ�С
    public float BgVolume
    {
        get { return _m_bgSound.volume; }
    }

    //��Ч��С
    public float EffectVolume
    {
        get { return _m_effectSound.volume; }
    }

    //�������ִ�С
    public void setBgVolume(float _volume)
    {
        _m_bgSound.volume = _volume;
    }

    //������Ч��С
    public void setEffectVolume(float _volume)
    {
        _m_effectSound.volume = _volume;
    }

    //��������
    public void playerBgSound(string _audioName)
    {
        if (null == _m_bgSound)
            return;

        if (null != _m_bgSound.clip && _m_bgSound.clip.name == _audioName)
            return;

        string path;
        if (string.IsNullOrEmpty(ResourceDir))
            path = _audioName;
        else
            path = ResourceDir + "/" + _audioName;

        //������Ƶ
        AudioClip clip = Resources.Load<AudioClip>(path);
        if(null != clip)
        {
            _m_bgSound.clip = clip;
            _m_bgSound.Play();
        }
    }

    protected override void Awake()
    {
        base.Awake();

        _m_bgSound = gameObject.AddComponent<AudioSource>();
        _m_bgSound.playOnAwake = false;
        _m_bgSound.loop = true;

        _m_effectSound = gameObject.AddComponent<AudioSource>();
    }
}
