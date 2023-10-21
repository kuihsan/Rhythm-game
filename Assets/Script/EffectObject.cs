using UnityEngine;

public class EffectObject : MonoBehaviour
{
    public float lifetime = 1f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Destroy(gameObject, lifetime);
    }
}