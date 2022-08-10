using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// GameManager.cs
public class GameManager : MonoBehaviour
{
    private static GameManager _instance; // 싱글톤 패턴을 사용하기 위한 인스턴스 변수

    public static GameManager Instance // 인스턴스에 접근하기 위한 프로퍼티
    {
        get
        {
            if (!_instance) // 인스턴스가 없는 경우에 접근하려 하면 인스턴스를 할당해준다.
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null) Debug.Log("No Singleton Obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this) // 인스턴스가 존재하는 경우
            Destroy(gameObject);    //   새로 생기는 인스턴스를 삭제
        DontDestroyOnLoad(gameObject); // 장면이 전환되더라도 선언되었던 인스턴스가 파괴되지 않는다.
    }




    public void StartNewGame()
    {
        StageLevel();
    }

    public void StageLevel() {}
    public void Score() { }
    public void PlayTime() { }
}

// Example.cs
public class Example : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.StartNewGame();
    }
}