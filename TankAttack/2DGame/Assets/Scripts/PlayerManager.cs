using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isDead;

    private void Awake()
    {
        isDead = false;
    }
}
