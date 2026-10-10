using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Parte destinada a criação de variaveis
    
    [SerializeField] private Image _targetImage;
    [SerializeField] private RectTransform _dragRectTransform;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private CanvasGroup _canvasGroup;

    private Vector3 _startPosition;

    public Slot currentSlot;

    void Awake()
    {
        _dragRectTransform = GetComponent<RectTransform>();
        _canvas = GetComponentInParent<Canvas>();
        _canvasGroup = GetComponent<CanvasGroup>();
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    
    // Inicia a função de arrastar e deixa a imagem mais transparente enquanto estiver arrastando(Pesquisei sobre no canal Vinicius Programming)
    public void OnBeginDrag(PointerEventData eventData)
    {
        _startPosition = _dragRectTransform.position;

        if (_canvasGroup != null)
        {
            _canvasGroup.alpha = 0.8f;
            _canvasGroup.blocksRaycasts = false;
        }
    }

    // FAz o objeto seguir o mouse como se tivesse segurando mesmo
    public void OnDrag(PointerEventData eventData)
    {
        if (_canvas != null)
        {
            _dragRectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
        }
    }

    // Faz a função contrária do "OnBeginDrag" e o objeto volta a sua cor original, e também ancora a posição no meio do slot
    public void OnEndDrag(PointerEventData eventData)
    {
        if (_canvasGroup != null)
        {
            _canvasGroup.alpha = 1f;
            _canvasGroup.blocksRaycasts = true;
        }

        // Se soltou num lugar invalido o objeto irá voltar para onde estava
        if (eventData.pointerEnter == null)
        {
            BackToStart();
            return;
        }

        GameObject target = eventData.pointerEnter;

        // Faz o objeto verificar se o objeto é um slot ou não pela tag
        if (target.CompareTag("Slot"))
        {
            Slot slot = target.GetComponent<Slot>();

            if (slot == null || (slot.IsOccupied && slot.CurrentItem != this))
            {
                BackToStart();
                return;
            }

            if (currentSlot != null && currentSlot != slot)
                currentSlot.CurrentItem = null;

            currentSlot = slot;
            slot.CurrentItem = this;
            _dragRectTransform.position = slot.GetComponent<RectTransform>().position;
        }
        else if (target.CompareTag("Pallete"))
        {
            if (currentSlot != null)
            {
                currentSlot.CurrentGate = "";
                currentSlot.CurrentItem = null;
                currentSlot = null;
            }
            _dragRectTransform.position = target.GetComponent<RectTransform>().position;
        }
        else
        {
            // Se não era válido ele volta onde estava
            BackToStart();
        }
    }

    // Função pra fazer o objeto voltar onde estava anteriormente(usada na função acima)
    private void BackToStart()
    {
        _dragRectTransform.position = _startPosition;
    }
}