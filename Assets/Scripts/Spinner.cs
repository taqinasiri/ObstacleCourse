using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float XAngle;
    [SerializeField] private float YAngle;
    [SerializeField] private float ZAngle;

    private void Update()
    {
        transform.Rotate(new(XAngle,YAngle,ZAngle));
    }
}