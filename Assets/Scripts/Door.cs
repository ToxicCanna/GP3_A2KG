using UnityEngine;

public class Door : MonoBehaviour
{
    // Reference to the DoorSlab (the child object to deactivate/activate)
    public GameObject doorSlab;

    private bool isOpen = false;

    // Open the door by deactivating the DoorSlab
    public void OpenDoor()
    {
        if (!isOpen && doorSlab != null)
        {
            doorSlab.SetActive(false);  // Deactivate the DoorSlab to "open" the door
            isOpen = true;
            Debug.Log("Door opened!");
        }
    }

    // Close the door by activating the DoorSlab
    public void CloseDoor()
    {
        if (isOpen && doorSlab != null)
        {
            doorSlab.SetActive(true);  // Activate the DoorSlab to "close" the door
            isOpen = false;
            Debug.Log("Door closed!");
        }
    }
}
