using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSecret : MonoBehaviour
{
   
   // Faz o botão secreto levar para o easter egg
   public void OnClick()
   {
      SceneManager.LoadScene(5);
   }
}
