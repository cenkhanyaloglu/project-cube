using UnityEngine;

public class RulesDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject panelRules;
    [SerializeField]
    private GameObject levelSelect;

    public void PanelRulesController()
    {
        levelSelect.SetActive(false);
        panelRules.SetActive(true);
    }

    public void ButtonReturnController()
    {
        panelRules.SetActive(false);
        levelSelect.SetActive(true);
        
    }
}
