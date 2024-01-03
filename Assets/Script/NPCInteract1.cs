using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract1 : MonoBehaviour
{
    [SerializeField] private string interactText;

    private Animator animator;

    public GameObject Canvas2;
    public GameObject Canvas4;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    void Start()
    {
        // Ensure canvas is inactive when the scene starts
        if (Canvas2 != null)
        {
            Canvas2.SetActive(false);
        }
    }

    public void Interact()
    {
        // Check if the canvas reference is not null and then enable it
        if (Canvas2 != null)
        {
            Canvas2.SetActive(true);
            Canvas4.SetActive(false);
        }
        animator.SetTrigger("Talk");
    }

    public string GetInteractText()
    {
        return interactText;
    }
}