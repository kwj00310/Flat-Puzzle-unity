using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance; // 싱글턴 인스턴스
    public Text scoreText; // UI에서 점수를 표시할 Text 컴포넌트
    public Text TimerText; // UI에서 점수를 표시할 Text 컴포넌트

    void Awake()
    {
        // 싱글턴 패턴을 활용하여 인스턴스 관리
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬이 변경되어도 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 중복 인스턴스가 생성되면 파괴
        }
    }

    public void UpdateScoreText(int newScore)
    {
        // 점수 업데이트 메소드, 점수가 변경될 때 호출됨
        scoreText.text =newScore.ToString();
        
    }
    public void UpdateTimerText(int newTimer)
    {
        TimerText.text =newTimer.ToString();
    }
}