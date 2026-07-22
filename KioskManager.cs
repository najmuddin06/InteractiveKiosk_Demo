using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KioskManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject idlePanel;
    public GameObject menuPanel;
    public GameObject popupPanel;

    [Header("Popup UI Elements")]
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public Image popupBackground;

    [Header("Simulated Hardware Data")]
    public ExhibitData rfidExhibit;
    public ExhibitData qrExhibit;

    void Start()
    {
        ShowIdle();
    }

    void Update()
    {
        // Pressing 'R' simulates scanning an RFID Card
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Simulated RFID Scan Detected!");
            OpenPopup(rfidExhibit);
        }

        // Pressing 'Q' simulates scanning a QR Code
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Simulated QR Code Scan Detected!");
            OpenPopup(qrExhibit);
        }
    }

    public void ShowIdle()
    {
        idlePanel.SetActive(true);
        menuPanel.SetActive(false);
        popupPanel.SetActive(false);
    }

    public void OpenMenu()
    {
        idlePanel.SetActive(false);
        menuPanel.SetActive(true);
        popupPanel.SetActive(false);
    }

    public void OpenPopup(ExhibitData data)
    {
        if (data == null) return;

        idlePanel.SetActive(false);
        menuPanel.SetActive(true);
        popupPanel.SetActive(true);

        titleText.text = data.exhibitName;
        descriptionText.text = data.description;
        if (popupBackground != null) popupBackground.color = data.themeColor;
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}