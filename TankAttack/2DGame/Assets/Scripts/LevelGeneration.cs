using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public int rotation;
    public int rand;

    public GameObject[] obstacles;

    void Awake()
    {
        rand = Random.Range(0, obstacles.Length);
        rotation = Random.Range(0, 2);
}
    // Start is called before the first frame update
    void Start()
    {
        if(rotation == 0)
        {
            Instantiate(obstacles[rand], transform.position, Quaternion.identity);
        } else
        {
            Instantiate(obstacles[rand], transform.position, Quaternion.Euler(0.0f, 0.0f, 90f));
        }
        
    }
}
