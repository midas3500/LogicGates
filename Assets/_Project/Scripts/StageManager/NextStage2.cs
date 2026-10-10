using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage2 : MonoBehaviour
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


    // Função pra passar de casa se as portas estiverem certas, a função compara os nomes com a variavel.
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
            if (_currentGate3.CurrentGate == "xorGate")
            {
                _checkedSlot3 = true;
            }
            else
            {
                _checkedSlot3 = false;
            }
        }
        // se tudo estiver certo o jogador passa pra ultima dificuldade
        if (_checkedSlot1 == true && _checkedSlot2 == true && _checkedSlot3 == true)
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
        }
    }
}