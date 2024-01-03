using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public float height = 3.0f; // Height above the player
    public float distance = 5.0f; // Distance behind the player
    public float rotationSpeed = 5.0f; // Speed of camera rotation
    public float angleOffset = 30.0f; // Angle offset for the camera

    private bool isInitialMoveComplete = false;

    void Start()
    {
        MoveCameraToPlayer();
        isInitialMoveComplete = true;
    }

    void MoveCameraToPlayer()
    {
        if (playerTransform != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = playerTransform.position - playerTransform.forward * distance;
            desiredPosition.y = playerTransform.position.y + height;

            // Set the camera position instantly to the desired position
            transform.position = desiredPosition;

            // Calculate the rotation towards the player's forward direction with an offset
            Quaternion lookRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
            transform.rotation = Quaternion.Euler(lookRotation.eulerAngles + new Vector3(angleOffset, 0, 0));
        }
    }

    void LateUpdate()
    {
        if (isInitialMoveComplete && playerTransform != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = playerTransform.position - playerTransform.forward * distance;
            desiredPosition.y = playerTransform.position.y + height;

            // Move the camera smoothly towards the desired position
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);

            // Calculate the rotation towards the player's forward direction with an offset
            Quaternion lookRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(lookRotation.eulerAngles + new Vector3(angleOffset, 0, 0)), Time.deltaTime * rotationSpeed);
        }
    }
}