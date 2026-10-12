using TMPro;
using UnityEngine;

public class HUDCanvas : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

    public static HUDCanvas instance;

    private int coins;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateText();
    }

    public void AddCoin()
    {
        coins++;
        UpdateText();
    }

    private void UpdateText()
    {
        coinText.text = $"Coins Collected: {coins}";
    }
}
