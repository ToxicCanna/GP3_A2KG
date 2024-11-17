using UnityEngine;

public class Switch : MonoBehaviour, IInteract  // Implement IInteract
{
    // Reference to the Lever and Door that this switch controls
    public Transform lever;
    public Door linkedDoor;

    private Vector3 initialLeverPosition;
    private bool isActivated = false;  // Track the state of the switch (activated or not)

    private void Start()
    {
        // Store the initial position of the lever
        if (lever != null)
        {
            initialLeverPosition = lever.localPosition;
        }
    }

    // Implement the Interact method from IInteract
    public void Interact()
    {
        // Check if the lever and door are assigned
        if (lever != null && linkedDoor != null)
        {
            // Toggle the lever position between its initial and moved position
            if (!isActivated)
            {
                lever.localPosition = initialLeverPosition + new Vector3(0, 1, 0);  // Move lever up by 1 on Y-axis
                linkedDoor.OpenDoor();  // Open the door
                isActivated = true;
            }
            else
            {
                lever.localPosition = initialLeverPosition;  // Reset lever to its initial position
                linkedDoor.CloseDoor();  // Close the door
                isActivated = false;
            }
        }
    }
}
