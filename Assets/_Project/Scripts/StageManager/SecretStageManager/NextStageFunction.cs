using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStageFunction : MonoBehaviour
{
    // Função pra passar pra proxima cena, nesse contexto seria a próxima frase / pergunta
    public void OnClick()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}
