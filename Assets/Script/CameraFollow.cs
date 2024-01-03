using UnityEngine;
using System.Collections; // Import the System.Collections namespace for IEnumerator

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public float height = 3.0f; // Height above the player
    public float distance = 5.0f; // Distance behind the player
    public float rotationSpeed = 5.0f; // Speed of camera rotation
    public float angleOffset = 30.0f; // Angle offset for the camera
    public float initialMoveDuration = 10.0f; // Increased duration for initial camera movement

    private bool isInitialMoveComplete = false;

    void Start()
    {
        StartCoroutine(InitialCameraMove());
    }

    IEnumerator InitialCameraMove()
    {
        Vector3 desiredPosition = playerTransform.position - playerTransform.forward * distance;
        desiredPosition.y = playerTransform.position.y + height;

        Vector3 startingPos = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < initialMoveDuration)
        {
            transform.position = Vector3.Lerp(startingPos, desiredPosition, (elapsedTime / initialMoveDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = desiredPosition;
        isInitialMoveComplete = true;
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