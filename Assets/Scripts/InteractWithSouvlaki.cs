using UnityEngine;

public class InteractWithSouvlaki : MonoBehaviour
{
    // Αυτή η μέθοδος καλείται όταν το σουβλάκι έρχεται σε επαφή με άλλο αντικείμενο
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Ελέγξτε αν το αντικείμενο που αγγίζει το σουβλάκι είναι ο παίκτης (ή άλλο αντικείμενο)
        if (collision.gameObject.CompareTag("Player"))
        {
            // Κάνουμε το σουβλάκι αόρατο ή το καταστρέφουμε
            Destroy(gameObject);  // Εξαφανίζει το σουβλάκι
        }
    }

    // Αν χρησιμοποιείς Trigger αντί για Collision (χωρίς φυσική επαφή)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);  // Εξαφανίζει το σουβλάκι
        }
    }
}

