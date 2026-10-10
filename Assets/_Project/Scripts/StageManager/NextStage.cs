using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    
    [Header("Check Slots")]
    [SerializeField] private Slot _currentGate1;
    [SerializeField] private Slot _currentGate2;
    [SerializeField] private Slot _currentGate3;
    
    
    [Header("CheckIf")]
    [SerializeField] private bool _checkedSlot1;
    [SerializeField] private bool _checkedSlot2;
    [SerializeField] private bool _checkedSlot3;
    
    
    
    // função chamada em todos os frames para verificar se esta certo
    void Update()
    {
        CheckSlots();
    }


    // Checa os slots para saber se o jogador colocou as portas lógicas no lugar certo
    private void CheckSlots()
    {
        if (_currentGate1 != null && _currentGate2 != null && _currentGate3 != null)
        {
            if (_currentGate1.CurrentGate == "andGate")
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
            if (_currentGate3.CurrentGate == "orGate")
            {
                _checkedSlot3 = true;
            }
            else
            {
                _checkedSlot3 = false;
            }
        }

        // Se todas as portas estiverem certas o jogador passa pra próxima fase
        if (_checkedSlot1 == true && _checkedSlot2 == true && _checkedSlot3 == true)
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
        }
    }
}
