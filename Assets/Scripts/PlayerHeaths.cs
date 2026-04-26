using UnityEngine;
using TMPro;


public class PlayerHeaths : MonoBehaviour
{
    
   public TMP_Text healthText;
   public Animator healTextAnim;

    private void Start()
    {
         healthText.text = "HP: " + StatsManager.Instance.currentHealth + "/" + StatsManager.Instance.maxHealth;
    }

   public void changeHealth(int amount)
   {
       StatsManager.Instance.currentHealth += amount;
       healTextAnim.Play("TextUpdate");
         healthText.text = "HP: " + StatsManager.Instance.currentHealth + "/" + StatsManager.Instance.maxHealth;    
       if (StatsManager.Instance.currentHealth <= 0)
       {
           gameObject.SetActive(false);
       }
   }
}
