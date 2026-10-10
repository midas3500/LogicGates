using System;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Slot : MonoBehaviour
{
    // Parte de criação de variaveis 
    
    public DragNDrop CurrentItem;
    public bool IsOccupied => CurrentItem != null;
    
    [SerializeField] private TextMeshProUGUI resultSlot;
    public Energy bit1;
    public Energy bit2;


    public Slot otherSlot1;
    public Slot otherSlot2;
    
    public bool slotEnergy;

    public string CurrentGate;
    
    
    // função chamada em todos os frames para trocar a HUD
    private void Update()
    {
        TradeValue();
    }
    
    
    // Troca o valor do slot na tela de 0 pra 1 ou vice versa
    void TradeValue()
    {
        if (CurrentItem == null)
        {
            if (resultSlot != null) resultSlot.text = "0";
            return;
        }

        // Procura no próprio objeto ou nos filhos dele
        OR orGate = CurrentItem.GetComponentInChildren<OR>();
        AND andGate = CurrentItem.GetComponentInChildren<AND>();
        XOR xorGate = CurrentItem.GetComponentInChildren<XOR>();

        
        // Diz que o slot está com devida porta(para puxar os dados de cada porta e mostrar 1 ou 0)
        if (orGate != null)
        {
            orGate.currentSlot = this;
            CurrentGate = "orGate";
            
            if (orGate.PassedEnergy == true)
            {
                resultSlot.text = "1";
                slotEnergy = true;
            }
            else 
            {
                resultSlot.text = "0";
                slotEnergy = false;
            }
            
        }
        else if (andGate != null)
        {
            andGate.currentSlot = this;
            CurrentGate = "andGate";
            
            if (andGate.PassedEnergy == true)
            {
                resultSlot.text = "1";
                slotEnergy = true;
            }
            else 
            {
                resultSlot.text = "0";
                slotEnergy = false;
            }
        }
        else if (xorGate != null)
        {
            xorGate.currentSlot = this;
            CurrentGate = "xorGate";
            
            if (xorGate.PassedEnergy == true)
            {
                resultSlot.text = "1";
                slotEnergy = true;
            }
            else 
            {
                resultSlot.text = "0";  
                slotEnergy = false;
            }
        }
        else
        {   
            // Se encontrou a peça mas não esta feita
            resultSlot.text = "Sem Porta";
        }
    }
    
    
    
}