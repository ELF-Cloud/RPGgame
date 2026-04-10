using UnityEngine;
using TMPro;


public class PlayerHeaths : MonoBehaviour
{
    public int maxHealth;
   public int currentHealth;
   public TMP_Text healthText;
   public Animator healTextAnim;

    private void Start()
    {
         healthText.text = "HP: " + currentHealth + "/" + maxHealth;
    }

   public void changeHealth(int amount)
   {
       currentHealth += amount;
       healTextAnim.Play("TextUpdate");
         healthText.text = "HP: " + currentHealth + "/" + maxHealth;    
       if (currentHealth <= 0)
       {
           gameObject.SetActive(false);
       }
   }
}
