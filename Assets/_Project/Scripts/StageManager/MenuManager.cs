using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   
   // Faz o botão do menu ir para a próxima cena
   public void OnClick()
   {
      int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
      SceneManager.LoadScene(nextScene);
   }
}
