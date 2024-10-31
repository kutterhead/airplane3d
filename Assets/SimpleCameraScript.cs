using UnityEngine;

public class SimpleCameraScript : MonoBehaviour
{
    public Transform target; // El objeto al que seguir� la c�mara
    public float smoothness = 5f; // Velocidad de suavizado
    private Vector3 offset; // Distancia entre la c�mara y el target

    void Start()
    {
        if (target == null)
            Debug.LogError("No hay un objeto asignado como 'Target'");

        // Calcular la distancia inicial entre la c�mara y el target
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset; // Posici�n deseada de la c�mara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothness * Time.deltaTime); // Mover la c�mara suavemente hacia la posici�n deseada
    }
}
