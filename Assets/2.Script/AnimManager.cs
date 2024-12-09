using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public static AnimManager Instance;

    public Animator animator;

    private void Awake()
    {
        Instance = this;
        animator = GetComponent<Animator>();
    }

    public void TreeAnim()
    {
        animator.SetTrigger("Tree");
    }

    public void StoneAnim()
    {
        Debug.Log(23122);
        animator.SetTrigger("Mine");
    }


    public void PlayAnim()
    {
        animator.SetTrigger("Play");
    }
}
