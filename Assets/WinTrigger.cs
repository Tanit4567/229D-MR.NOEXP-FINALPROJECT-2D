using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  // ��������� SceneManagement

public class WinTrigger : MonoBehaviour
{
    public PlayerCollector player;  // ��ҧ�֧ʤ�Ի�����纤�ṹ
    public GameObject winText;      // ��ҧ�֧��ͤ��� YOU WIN

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && player.score >= 9)
        {
            winText.SetActive(true);
            StartCoroutine(GoToCreditsAfterDelay());  // ���¡ Coroutine �˹���ôԵ
        }
    }

    private System.Collections.IEnumerator GoToCreditsAfterDelay()
    {
        yield return new WaitForSeconds(5f);  // ˹�ǧ���� 5 �Թҷ�
        SceneManager.LoadScene("CreditsScene");  // ����� Scene ���ç�Ѻ Scene �ôԵ�ͧ�س
    }
}
