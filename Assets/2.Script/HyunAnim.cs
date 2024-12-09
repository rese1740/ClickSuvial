using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyunAnim : MonoBehaviour
{
    public AnimationClip HyunJun;

    public Animation anim;

    private void Start()
    {
        anim.clip = HyunJun;


        anim.Play();
    }
}
