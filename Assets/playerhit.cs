using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    int health = 15;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            health -= 5;
            Debug.Log(health);
        }
    }
}
