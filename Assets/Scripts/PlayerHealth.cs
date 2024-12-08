using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Μέγιστη υγεία
    private float currentHealth; // Τρέχουσα υγεία

    public Image healthBarFill; // Αναφορά στη μπάρα υγείας για να ενημερώνεται το fill amount

    public float knifeDamage = 20f; // Ζημιά που προκαλεί το μαχαίρι

    void Start()
    {
        currentHealth = maxHealth; // Ξεκινάμε με πλήρη υγεία
    }

    void Update()
    {
        // Ενημερώνουμε την μπάρα υγείας
        UpdateHealthBar();
    }

    // Μέθοδος για την ενημέρωση της μπάρας υγείας
    void UpdateHealthBar()
    {
        healthBarFill.fillAmount = currentHealth / maxHealth; // Ενημερώνουμε το fill της μπάρας υγείας
    }

    // Μέθοδος για τη μείωση της υγείας του παίκτη
    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // Μειώνουμε την υγεία
        if (currentHealth < 0)
            currentHealth = 0; // Εξασφαλίζουμε ότι η υγεία δεν είναι αρνητική
    }

    // Μέθοδος για να προσθέσουμε υγεία στον παίκτη (π.χ. θεραπεία)
    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth; // Εξασφαλίζουμε ότι η υγεία δεν ξεπερνά το μέγιστο
    }

    // Ανιχνεύουμε τη σύγκρουση με το μαχαίρι
    void OnCollisionEnter(Collision collision)
    {
        // Ελέγχουμε αν το αντικείμενο με το οποίο συγκρούστηκε είναι το μαχαίρι
        if (collision.gameObject.CompareTag("Knife"))
        {
            TakeDamage(knifeDamage); // Αν ναι, μειώνουμε την υγεία
        }
    }
}

