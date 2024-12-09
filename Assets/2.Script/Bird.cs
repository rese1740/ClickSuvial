using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public static Bird Instance;

    public float speed = 2.0f; // 이동 속도
    public float distance = 15f; // 이동 거리
    private Vector3 startPosition;
    private Vector3 targetPosition;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(distance, 0, 0);
    }

    public void DestroyBird()
    {
        PlayerUI.Instance.birdnow = true;
        Destroy(gameObject);
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        // 목표 위치에 도달하면 방향을 바꿉니다.
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // 방향 전환
            targetPosition = targetPosition == startPosition ? startPosition + new Vector3(distance, 0, 0) : startPosition;

            // 회전 방향 설정
            if (targetPosition == startPosition + new Vector3(distance, 0, 0))
            {
                transform.localScale = new Vector3(1, 1, 1); // 오른쪽으로 이동 시 정방향
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1); // 왼쪽으로 이동 시 반전
            }
        }
    }

    IEnumerator Sadadad()
    {
        yield return null;
    }
}

