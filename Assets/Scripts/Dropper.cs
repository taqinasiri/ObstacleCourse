using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;

    private Rigidbody rb;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        meshRenderer.enabled = false;
    }

    private void Update()
    {
        if(Time.time >= timeToWait)
        {
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}