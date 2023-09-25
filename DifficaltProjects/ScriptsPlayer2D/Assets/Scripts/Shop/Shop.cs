using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject menuShop;
    [SerializeField] private Image ClickNo;
    [SerializeField] private InputPlayerControll openShop;

    public bool GoFurther { get; private set; }

    public void OnButtonClickYes()
    {
        Debug.Log("Yes");
        GoFurther = true;
    }

    public void OnButtonClickNo()
    {
        Debug.Log("No");
        ClickNo.gameObject.SetActive(true);
    }

    private void Awake()
    {
        GoFurther = false;
        Debug.Log(openShop.IsInteractionButtonPressed);
        ClickNo.gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (openShop.IsInteractionButtonPressed)
        {
            Debug.Log(2);
            menuShop.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(openShop.IsInteractionButtonPressed);
        menuShop.SetActive(false);
    }
}
