using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameManager.cs
public class GameManager : MonoBehaviour
{
    [Header("[UI]")]
    public GameObject lobby;
    public GameObject inGame;

    [Header("[Environment]")]
    public GameObject originHome;
    public GameObject panelLane;
    public GameObject panelStartLight;
    public GameObject panelDestroyColl;

    [Header("[패널 프리팹]")]
    public GameObject prefabBlockUp;
    public GameObject prefabBlockRight;
    public GameObject refabBlockLeft;
    public GameObject prefabQuiz;
    public GameObject prefabMotion_0;

    // Pooling 초기화
    [SerializeField] GameObject[] targetPool;
    // Panel Pooling
    GameObject[] BlockUp;
    GameObject[] BlockRight;
    GameObject[] BlockLeft;
    GameObject[] Quiz;
    GameObject[] Motion_0;
    // SFX Pooling
    // Sounds

    [Header("[Music Start]")]
    public Transform panelSpawnPoint; // 패널 생성 위치
    public float beat;
    [SerializeField] float timer;

    [Header("[플래그 변수]")]
    [SerializeField] bool isStart = false; // 인게임 진행 상태
    [SerializeField] bool isStop = false;  // 인게임 도중 일시 정지 상태
    [SerializeField] bool isLevelEasy   = false;  // Level Easy
    [SerializeField] bool isLevelNormal = false;  // Level Normal
    [SerializeField] bool isLevelHard   = false;  // Level Hard

    private void Awake()
    {
        BlockUp    = new GameObject[10];
        BlockRight = new GameObject[10];
        BlockLeft  = new GameObject[10];
        Quiz        = new GameObject[10];
        Motion_0    = new GameObject[10];

        PoolGenerate();
    }

    void PoolGenerate()
    {
        // #1. Panels
        for (int index = 0; index < BlockUp.Length; index++)
        {
            BlockUp[index] = Instantiate(prefabBlockUp);
            BlockUp[index].SetActive(false);
        }
        for (int index = 0; index < BlockRight.Length; index++)
        {
            BlockRight[index] = Instantiate(prefabBlockRight);
            BlockRight[index].SetActive(false);
        }
        for (int index = 0; index < BlockLeft.Length; index++)
        {
            BlockLeft[index] = Instantiate(refabBlockLeft);
            BlockLeft[index].SetActive(false);
        }
        for (int index = 0; index < Quiz.Length; index++)
        {
            Quiz[index] = Instantiate(prefabQuiz);
            Quiz[index].SetActive(false);
        }
        for (int index = 0; index < Motion_0.Length; index++)
        {
            Motion_0[index] = Instantiate(prefabMotion_0);
            Motion_0[index].SetActive(false);
        }

        // #2. SFX

        // #3. Sounds
    }

    public GameObject MakeObj(int number)
    {
        switch (number)
        {
            case 0:
                targetPool = BlockUp;
                break;
            case 1:
                targetPool = BlockRight;
                break;
            case 2:
                targetPool = BlockLeft;
                break;
            case 3:
                targetPool = Quiz;
                break;
            case 4:
                targetPool = Motion_0;
                break;
        }

        // 풀링 타겟 갯수만큼 비활성화된 오브젝트에 접근하여 활성화 후, 반환
        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }
        return null;
    }

    public void InGameStart()
    {
        isStart = true;

        lobby.SetActive(false);
        originHome.SetActive(true);
        panelLane.SetActive(true);
        panelStartLight.SetActive(true);
        panelDestroyColl.SetActive(true);

        IngamePanelGenerate();
    }

    void IngamePanelGenerate()
    {
        if (!isStart) return;

        if (timer > beat)
        {
            GameObject panel = MakeObj(Random.Range(0, 5));
            panel.transform.position = panelSpawnPoint.position;

            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}