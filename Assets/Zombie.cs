using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{

    [SerializeField] private int HP = 100;
    private Animator animator;

    private NavMeshAgent navAgent;

    public ZombieHand zombieHand;

    public int zombieDamage;

    //testing
    private bool isDead = false;

    public bool IsDead => isDead;

    private void Start()
    {
        animator = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();

        zombieHand.damage = zombieDamage;

    }

    public void TakeDamage(int damageAmount)
    {
        //testing -> uignore damage if already dead 
        if(isDead) return;

        HP -= damageAmount;

        if (HP <= 0)
        {
            //added dead
            isDead = true;


            int randomValue = Random.Range(0, 2); 

            if (randomValue == 0)
            {
                animator.SetTrigger("DIE1");


                navAgent.isStopped = true;
                navAgent.enabled = false;
            }
            else
            {
                animator.SetTrigger("DIE2");


                navAgent.isStopped = true;
                navAgent.enabled = false;
            }
        }
        else
        {
            animator.SetTrigger("DAMAGE");
        }
    }

}
