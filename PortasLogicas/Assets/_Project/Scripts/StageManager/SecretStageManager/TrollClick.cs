using UnityEngine;

public class TrollClick : MonoBehaviour
{
    // Faz o botão sumir quando a pessoa clica(nunca vai ser usado até porque é 10 a resposta mesmo quem clicaria em outra coisa)
    public void OnClick()
    {
        Destroy(gameObject);
    }
    
}
