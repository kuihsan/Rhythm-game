using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour
{
    [SerializeField] private string interactText;

    private Animator animator;

    public GameObject Canvas1;
    public GameObject Canvas;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    void Start()
    {
        // Ensure canvas is inactive when the scene starts
        if (Canvas1 != null)
        {
            Canvas1.SetActive(false);
        }
    }

    public void Interact()
    {
        // Check if the canvas reference is not null and then enable it
        if (Canvas1 != null)
        {
            Canvas1.SetActive(true);
            Canvas.SetActive(false);
        }
        animator.SetTrigger("Talk");
    }

    public string GetInteractText()
    {
        return interactText;
    }
}