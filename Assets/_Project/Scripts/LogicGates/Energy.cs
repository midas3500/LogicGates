using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    [SerializeField] private Button _button;
    
    public bool bit;
    
    // Quando começa o bit é 0
    void Start()
    {
        bit = false;
    }

    // Atualiza o valor que aparece na tela para o jogador todos os frames
    void Update()
    {
        TradeValue();
    }
    
    // Função chamada somente quando o jogador clica o botão
    public void OnClick()
    {
        if (bit == true)
        {
            bit = false;
        }
        else
        {
            bit = true;
        }
    }
    
    // Função que troca o valor do componente filho, no caso do botão é o TMPro que fica nele
    private void TradeValue()
    {
        if (_button != null)
        {
            TextMeshProUGUI myText = _button.GetComponentInChildren<TextMeshProUGUI>();
            
            // se o bit for verdadeiro na tela aparece 1, se for falso aparece 0
            if (bit == true)
            {
                myText.text = "1";
            }
            else if (bit == false)
            {
                myText.text = "0";
            }
        }
    }
    
}

