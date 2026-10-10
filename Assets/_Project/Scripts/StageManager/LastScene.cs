using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour
{
    
    [Header("Check Slots")]
    [SerializeField] private Slot _currentGate1;
    [SerializeField] private Slot _currentGate2;
    [SerializeField] private Slot _currentGate3;
    
    
    [Header("CheckIf")]
    [SerializeField] private bool _checkedSlot1;
    [SerializeField] private bool _checkedSlot2;
    [SerializeField] private bool _checkedSlot3;
    
    
    
    // Checa todos os frames se o jogador fez certo
    void Update()
    {
        CheckSlots();
    }


    // Função pra passar de casa se as portas estiverem certas, a função compara os nomes com a variavel.
    private void CheckSlots()
    {
        if (_currentGate1 != null && _currentGate2 != null && _currentGate3 != null)
        {
            if (_currentGate1.CurrentGate == "xorGate")
            {
                _checkedSlot1 = true;
            }
            else
            {
                _checkedSlot1 = false;
            }
            if (_currentGate2.CurrentGate == "andGate")
            {
                _checkedSlot2 = true;
            }
            else
            {
                _checkedSlot2 = false;
            }
            if (_currentGate3.CurrentGate == "xorGate")
            {
                _checkedSlot3 = true;
            }
            else
            {
                _checkedSlot3 = false;
            }
        }
        // se estiver tudo certo passa para os agradecimentos
        if (_checkedSlot1 == true && _checkedSlot2 == true && _checkedSlot3 == true)
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
        }
    }
}