using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameManager.cs
public class GameManager : MonoBehaviour
{
    [Header("Prefab_Panels")]
    public GameObject Prefab_Block_Right;
    public GameObject Prefab_Block_Left;
    public GameObject Prefab_Block_Up;
    public GameObject Prefab_Quiz;
    public GameObject Prefab_Motion_0;

    // Panel Pooling
    GameObject[] Block_Right;
    GameObject[] Block_Left;
    GameObject[] Block_Up;
    GameObject[] Quiz;
    GameObject[] Motion_0;

    // SFX
    // Sounds

    // 초기화
    GameObject[] targetPool;

    public Transform panelSpawnPoint; // 패널 스타트 위치
    public float beat;
    private float timer;

    private void Awake()
    {
        Block_Right = new GameObject[10];
        Block_Left  = new GameObject[10];
        Block_Up    = new GameObject[10];
        Quiz        = new GameObject[10];
        Motion_0    = new GameObject[10];

        Generate();

        //panelObjs = new string[] { "Block_Right",
        //                           "Block_Left",
        //                           "Block_Up",
        //                           "Quiz",
        //                           "Motion_0" };
    }

    private void Update()
    {
        IngamePanelGenerate();
    }

    void Generate()
    {
        // #1. Panels
        for (int index = 0; index < Block_Right.Length; index++)
        {
            Block_Right[index] = Instantiate(Prefab_Block_Right); // 풀링오브젝트 생성
            Block_Right[index].SetActive(false); // 비활성화
        }
        for (int index = 0; index < Block_Left.Length; index++)
        {
            Block_Left[index] = Instantiate(Prefab_Block_Left);
            Block_Left[index].SetActive(false);
        }
        for (int index = 0; index < Block_Up.Length; index++)
        {
            Block_Up[index] = Instantiate(Prefab_Block_Up);
            Block_Up[index].SetActive(false);
        }
        for (int index = 0; index < Quiz.Length; index++)
        {
            Quiz[index] = Instantiate(Prefab_Quiz);
            Quiz[index].SetActive(false);
        }
        for (int index = 0; index < Motion_0.Length; index++)
        {
            Motion_0[index] = Instantiate(Prefab_Motion_0);
            Motion_0[index].SetActive(false);
        }

        // #2. SFX

        // #3. Sounds
    }

    public GameObject MakeObj(int type)
    {
        switch (type)
        {
            case 0:
                targetPool = Block_Right;
                break;
            case 1:
                targetPool = Block_Left;
                break;
            case 2:
                targetPool = Block_Up;
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

    void IngamePanelGenerate()
    {

        if (timer > beat)
        {
            GameObject panel = MakeObj(Random.Range(0, 5));
            panel.transform.position = panelSpawnPoint.position;

            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}