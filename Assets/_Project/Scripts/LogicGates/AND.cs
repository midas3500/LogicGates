using UnityEngine;

public class AND : MonoBehaviour
{
    [SerializeField] private bool _passedEnergy;
    public bool PassedEnergy => _passedEnergy;

    public Slot currentSlot;

    void Update()
    {
        ANDGate();
    }

    void ANDGate()
    {
        // esse if é pra unity não dar erro se não tiver em nenhum
        if (currentSlot == null)
        {
            _passedEnergy = false;
            return;
        }
        

        if (currentSlot.bit1 != null && currentSlot.bit2 != null)
        {
            // ficou meio confuso mas, o current slot serve pro slot ir direto pro inspector da
            // porta lógica, o bit1 é a variavel no slot que ta sendo puxada do energy, e no
            // energy tem a variavel bit que é responsavel pela energia, o Slot funciona como
            // um centro de tudo pra organizar na hora que for colocado algo naquele slot especifico
            
            if (currentSlot.bit1.bit == true && currentSlot.bit2.bit == true) 
            {
                _passedEnergy = true;
            }
            else
            {
                _passedEnergy = false;
            }
        }
        
        // Aqui é caso o slot n pegue energia diretamente da fonte principal e sim de outro slot
        else if (currentSlot.otherSlot1 != null && currentSlot.otherSlot2 != null)
        {
            // Checa se a energia é true para os dois
            if (currentSlot.otherSlot1.slotEnergy == true && currentSlot.otherSlot2.slotEnergy == true)
            {
                _passedEnergy = true;
            }
            else
            {
                _passedEnergy = false;
            }
        }
        // caso seja outra coisa vai dar false
        else
        {
            _passedEnergy = false;
        }
    }
}
