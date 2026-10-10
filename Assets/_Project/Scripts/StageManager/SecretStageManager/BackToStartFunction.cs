using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStartFunction : MonoBehaviour
{
    
    // Volta pro menu do gênio quiz
    public void OnClick()
    {
        SceneManager.LoadScene(5);
    }
    
    
}
