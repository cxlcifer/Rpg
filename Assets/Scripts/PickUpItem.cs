using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private Outline _outline;
    public bool IsPotionTaken { get; private set; } = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsPotionTaken = true;
            Destroy(gameObject);
            _outline.OutlineWidth = 2f;
        }
    }
}
