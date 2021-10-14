using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public static readonly int speed = Animator.StringToHash("Speed");
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.CompareTag("AnimStarter"))
        {
            animator.SetFloat(speed, 1.0f);
        }
    }
}
