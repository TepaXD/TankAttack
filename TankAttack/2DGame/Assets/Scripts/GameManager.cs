using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float waitTime = 2f;

    public GameObject gameOverUI;

    public void GameOver()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
        }
    }
}
