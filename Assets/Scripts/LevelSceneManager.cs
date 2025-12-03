using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneManager : MonoBehaviour
{
    [SerializeField] private string levelCode;
    
    /// <summary>
    /// Loads the level named after the input string
    /// </summary>
    /// <param name="levelName"></param>
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    /// <summary>
    /// Loads Scene Manager level code
    /// </summary>
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelCode);
    }
}
