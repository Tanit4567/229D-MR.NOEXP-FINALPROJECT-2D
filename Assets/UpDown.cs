using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float amplitude = 1f; 
    public float speed = 1f;     

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; 
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startPos.x, startPos.y + y, startPos.z);
    }
}
