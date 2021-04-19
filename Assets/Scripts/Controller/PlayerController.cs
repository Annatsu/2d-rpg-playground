using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{

    Player player;
    Rigidbody2D rb2d;
    Animator animator;
    Vector2 movementDirection = Vector2.zero;

    void Awake()
    {
        player = GetComponent<Player>();
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        if (player.CanMove())
        {
            if (movementDirection.x != 0 || movementDirection.y != 0)
            {
                player.ActiveEntityState = Entity.EntityState.MOVING;
                animator.SetInteger("state", (int)player.ActiveEntityState);
                animator.SetFloat("input_x", movementDirection.x);
                animator.SetFloat("input_y", movementDirection.y);
                rb2d.MovePosition(player.MoveTowards(rb2d.position, movementDirection, Time.fixedDeltaTime));
            }
            else
            {
                player.ActiveEntityState = Entity.EntityState.IDLE;
                animator.SetInteger("state", (int)player.ActiveEntityState);
            }
        }
    }
}
