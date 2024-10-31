using UnityEngine;

public class SimpleCameraScript : MonoBehaviour
{
    public Transform target; // El objeto al que seguirá la cámara
    public float smoothness = 5f; // Velocidad de suavizado
    private Vector3 offset; // Distancia entre la cámara y el target

    void Start()
    {
        if (target == null)
            Debug.LogError("No hay un objeto asignado como 'Target'");

        // Calcular la distancia inicial entre la cámara y el target
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset; // Posición deseada de la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothness * Time.deltaTime); // Mover la cámara suavemente hacia la posición deseada
    }
}
