using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameManager.cs
public class GameManager : MonoBehaviour
{
    [Header("[UI]")]
    public GameObject lobby;
    public GameObject inGame;

    [Header("[SFX]")]
    public GameObject vizualizationObjects;

    [Header("[Environment]")]
    public GameObject originHome;
    public GameObject panelLane;
    public GameObject panelStartLight;
    public GameObject panelDestroyColl;

    [Header("[Music Start]")]
    public Transform panelSpawnPoint; // 패널 생성 위치
    public float beat;                // BPM
    [SerializeField] float timer;     // BPM Timer

    [Header("[플래그 변수]")]
    [SerializeField] bool isStart = false;       // 인게임 진행 상태
    [SerializeField] bool isStop = false;        // 인게임 도중 일시 정지 상태
    [SerializeField] bool isLevelEasy = false;   // Level Easy
    [SerializeField] bool isLevelNormal = false; // Level Normal
    [SerializeField] bool isLevelHard = false;   // Level Hard

    [Header("[패널 프리팹]")]
    public EnumPanel[] Panels;

    public AudioSource _AudioSource_Music;

    private void Awake()
    {
        StartCoroutine(FileIo());

    }

    IEnumerator FileIo()
    {
        WWW tmpWWW = new WWW(@"file://" + @"C:/ wav / 01.wav");

        while (!tmpWWW.isDone)
            yield return null;

        //_AudioSource_Music.clip = tmpWWW.GetAudioClip(true, false);
    }

    private void Update()
    {
        if (isStart)
        {
            if (timer > beat)
            {
                Instantiate(Panels[UnityEngine.Random.Range(0, 16)], panelSpawnPoint);
                timer -= beat;
            }

            timer += Time.deltaTime;
        }
        else if (isStart && isStop)
        {
            // 일시정지 UI 출력
            
            // 패널/시간 정지
        }
        else
        {

            // 타이머, 패널 초기화
        }
        // 경과 시간이 종료되면 결과 출력
    }

    private void LateUpdate()
    {
        // UI : 노래 경과 시간
    }

    public void InGameStart() // Btn Play
    {
        isStart = true;
        lobby.SetActive(false);
        inGame.SetActive(true);
        vizualizationObjects.SetActive(true);
        originHome.SetActive(true);
        panelLane.SetActive(true);
        panelStartLight.SetActive(true);
        panelDestroyColl.SetActive(true);

        // + 콘트롤러 변경
    }

    public void InGameStop() // 일시 정지
    {
        isStop = true;
        // 일시 정지 UI 출력
    }

}