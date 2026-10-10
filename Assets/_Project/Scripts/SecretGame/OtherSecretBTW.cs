using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OtherSecretBTW : MonoBehaviour
{
    // Area pra criação de variaveis usando o serializefield pra mostrar na unity mesmo sendo uma variavel privada
    [SerializeField] private int _count = 0;
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI myText;
    
    // função acionada a cade frame consultando quanto é o valor do contador
    void Update()
    {
        UpdateTrollTexts();
    }

    // função que somente é chamada quando o jogador clica o botão
    public void OnClick()
    {
        _count += 1;
    }

    // função criada para aparecer textos na tela conversando com o jogador
    public void UpdateTrollTexts()
    {
        if (_button != null)
        {
            switch (_count)
            {
                case 1:
                    myText.text = "Esse botão não faz nada coloquei ai só pra tapar o espaço em branco";
                    break;
                case 2:
                    myText.text = "É sério não tem nada mesmo, não é como se tivesse um segredo quando você clica 1000 vezes";
                    break;
                case 3:
                    myText.text = "Da pra parar?!";
                    break;
                case 4:
                    myText.text = "sério para!";
                    break;
                case 10:
                    myText.text = "Nem ficar quieto faz você parar?";
                    break;
                case 20:
                    myText.text = "";
                    break;
                case 30:
                    myText.text = "Desisto, tava tentando te ajudar a não perder seu tempo";
                    break;
                case 40:
                    myText.text = "VAI ESTUDAR FIQUEI MÓ COTA FAZENDO SISTEMA DE ARRASTAR";
                    break;
                case 50:
                    myText.text = "Desisto.";
                    break;
                case 100:
                    myText.text = "Da próxima eu deixo em branco mesmo não quero nem saber";
                    break;
                case 200:
                    myText.text = "Fiz o jogo pra ajudar com esse conteúdo e ao invés de jogar ficam procurando segredo :(";
                    break;
                case 300:
                    myText.text = "Não falo mais nada de verdade agora se quiser fica ai";
                    break;
                case 600:
                    myText.text = "Agora chega de verdade";
                    break;
                case 610:
                    myText.text = "";
                    break;
                case 1000:
                    myText.text = "Eu falei que não tinha nada!";
                    break;
            }
        }
    }
}