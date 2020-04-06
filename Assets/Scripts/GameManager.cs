using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public ScoreText score;
    public float restartDelay = 0;
    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            score.enabled = false;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
