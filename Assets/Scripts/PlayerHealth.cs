using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public BarreDeVie healthBar;

    // Start is called before the first frame update
    void Start()
    {
        // le joueur commence avec toute sa vie
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // test pour voir si ca fonctionne
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage (int damage)
    {
        currentHealth -= damage;  // si on prends des degats ont retire de la vie a la vie actuelle
        healthBar.SetHealth(currentHealth); // pour mettre a jour le visuel de la barre de vie
    }
}
