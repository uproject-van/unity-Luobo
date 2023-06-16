using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : Singleton<Sound>
{
    //背景音乐
    AudioSource _m_bgSound;
    //音效
    AudioSource _m_effectSound;

    //音频相关资源路径
    public string ResourceDir = "";

    //音乐大小
    public float BgVolume
    {
        get { return _m_bgSound.volume; }
    }

    //音效大小
    public float EffectVolume
    {
        get { return _m_effectSound.volume; }
    }

    //设置音乐大小
    public void setBgVolume(float _volume)
    {
        _m_bgSound.volume = _volume;
    }

    //设置音效大小
    public void setEffectVolume(float _volume)
    {
        _m_effectSound.volume = _volume;
    }

    //播放音乐
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

        //加载音频
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
