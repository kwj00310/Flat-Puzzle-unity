using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance; // �̱��� �ν��Ͻ�
    public Text scoreText; // UI���� ������ ǥ���� Text ������Ʈ
    public Text TimerText; // UI���� ������ ǥ���� Text ������Ʈ

    void Awake()
    {
        // �̱��� ������ Ȱ���Ͽ� �ν��Ͻ� ����
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ���� ����Ǿ �ı����� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject); // �ߺ� �ν��Ͻ��� �����Ǹ� �ı�
        }
    }

    public void UpdateScoreText(int newScore)
    {
        // ���� ������Ʈ �޼ҵ�, ������ ����� �� ȣ���
        scoreText.text =newScore.ToString();
        
    }
    public void UpdateTimerText(int newTimer)
    {
        TimerText.text =newTimer.ToString();
    }
}