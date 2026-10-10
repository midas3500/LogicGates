using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    // Quando o jogador termina o jogo pode clicar para voltar ao menu
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
