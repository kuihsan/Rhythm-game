using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractUI1 : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract1 playerInteract1;
    [SerializeField] private TextMeshProUGUI interectTextMeshProUGUI;

    private void Update()
    {
        if(playerInteract1.GetInteractableObject() != null)
        {
            Show(playerInteract1.GetInteractableObject());
        }
        else
        {
            Hide();
        }
    }

    private void Show(NPCInteract1 npcInteract1)
    {
        containerGameObject.SetActive(true);
        interectTextMeshProUGUI.text = npcInteract1.GetInteractText();
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
