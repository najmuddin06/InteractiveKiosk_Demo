using UnityEngine;

[CreateAssetMenu(fileName = "NewExhibit", menuName = "Kiosk/Exhibit Data")]
public class ExhibitData : ScriptableObject
{
    public string exhibitName;
    [TextArea(3, 5)]
    public string description;
    public Color themeColor = Color.cyan;
}