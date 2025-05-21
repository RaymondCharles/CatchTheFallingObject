using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance;

    public int misses = 0;
    public int maxMisses = 3;

    public TextMeshProUGUI messageText;
    public GameObject restartButton;

    void Awake()
    {
        Instance = this;
    }

    public void Miss()
    {
        misses++;
        Debug.Log("Missed: " + misses);

        if (misses >= maxMisses)
        {
            messageText.gameObject.SetActive(true);     // show "Game Over"
            messageText.text =  " Game Over! ";
            restartButton.SetActive(true);              // show restart button
            Time.timeScale = 0;                          // pause game
        }
    }
}
