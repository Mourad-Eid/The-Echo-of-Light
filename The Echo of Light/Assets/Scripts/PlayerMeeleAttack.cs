using System.Collections;
using UnityEngine;

public class PlayerMeeleAttack : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] GameObject attackBox;
    [SerializeField] int hitRate =1;
    [SerializeField] float attackTime;
    private float lastHitTime;
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        input.playerActionControls.Land.MeleeHit.performed += _ => AttackMelee();
    }

    void AttackMelee()
    {
        if (Time.time > (1 / hitRate) + lastHitTime)
        {
            StartCoroutine(Attack(attackTime));
        }
    }
    IEnumerator Attack(float attackTime)
    {
        attackBox.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        attackBox.SetActive(false);
    }
}
