using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Active();
        StartCoroutine(DestroyItem());
    }


    public IEnumerator DestroyItem()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    public void Active()
    {
        float power = 200f;
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(0, 1f));
        rigidbody2D.AddForce(dir * power);
    }
   
}
