using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            float interactRange = 5f;
            Collider [] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out NPCInteract1 npcInteract1))
                {
                    npcInteract1.Interact();
                }
                else
                {
                    //pm.movementSpeed = 5;
                }
            }
        }
        
    }

    public NPCInteract1 GetInteractableObject()
    {
        List<NPCInteract1> npcInteractList = new List<NPCInteract1>();
        float interactRange = 3f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out NPCInteract1 npcInteract1))
            {
                npcInteractList.Add(npcInteract1);
            }
        }

        NPCInteract1 closestNPCInteract = null;
        foreach (NPCInteract1 npcInteract1 in npcInteractList)
        {
            if (closestNPCInteract == null)
            {
                closestNPCInteract = npcInteract1;
            }
            else
            {
                if (Vector3.Distance(transform.position, npcInteract1.transform.position) <
                   Vector3.Distance(transform.position, closestNPCInteract.transform.position))
                {
                    closestNPCInteract = npcInteract1;
                }
            }
        }

        return closestNPCInteract;
    }

}
