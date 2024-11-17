using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // This method is triggered when the player enters the trigger collider of an interactable object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object implements the IInteract interface
        IInteract interactable = other.GetComponent<IInteract>();
        if (interactable != null)
        {
            // If we entered an interactable object's trigger zone, automatically interact with it
            interactable.Interact();
        }
    }
}