using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 컴포넌트 캐시 처리할 변수
    Transform tr;
    Animation anim;

    public float moveSpeed = 8.0f;
    public float turnSpeed = 200.0f;

    private void Start()
    {
        // Component를 추출해 변수에 대입
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();

        // 애니메이션 실행
        anim.Play("Idle");
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h); // 전후좌우 이동 방향 벡터 계산
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime); // Translate(이동 방향 * 속력 * Time.deltaTime) 이동 로직
        tr.Rotate(r * Vector3.up * turnSpeed * Time.deltaTime);        // Vector3.up 축을 기준으로 turnSpeed만큼의 속도로 회전

        PlayerAnim(h, v); // 주인공 캐릭터의 애니메이션 설정
    }

    void PlayerAnim(float h, float v) // 키보드 입력값을 기준으로 동작할 애니메이션 수행
    {
        if      (v >=  0.1f) anim.CrossFade("RunF", 0.25f); // 전진 애니메이션 실행
        else if (v <= -0.1f) anim.CrossFade("RunB", 0.25f); // 후진 애니메이션 실행
        else if (h >=  0.1f) anim.CrossFade("RunR", 0.25f); // 오른쪽 이동 애니메이션 실행
        else if (h <= -0.1f) anim.CrossFade("RunL", 0.25f); // 왼쪽 이동 애니메이션 실행
        else                 anim.CrossFade("Idle", 0.25f); // 정지 시 대기 애니메이션 실행
    }
}