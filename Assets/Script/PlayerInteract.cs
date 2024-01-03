using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    PlayerMovement pm;
    private void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            float interactRange = 5f;
            Collider [] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out NPCInteract npcInteract))
                {
                    npcInteract.Interact();
                    pm.movementSpeed = 0;
                }
                else
                {
                    //pm.movementSpeed = 5;
                }
            }
        }
        
    }

    public NPCInteract GetInteractableObject()
    {
        List<NPCInteract> npcInteractList = new List<NPCInteract>();
        float interactRange = 3f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out NPCInteract npcInteract))
            {
                npcInteractList.Add(npcInteract);  
            }
        }

        NPCInteract closestNPCInteract = null;
        foreach (NPCInteract npcInteract in npcInteractList)
        {
            if(closestNPCInteract == null)
            {
                closestNPCInteract = npcInteract;
            }
            else
            {
                if(Vector3.Distance(transform.position, npcInteract.transform.position) <
                   Vector3.Distance(transform.position, closestNPCInteract.transform.position))
                {
                    closestNPCInteract = npcInteract;
                }
            }
        }

        return closestNPCInteract;
    }

}
