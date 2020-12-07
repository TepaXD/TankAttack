using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Static means it's a variable of the class, not instance
    public static int score;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score;
    }
}
