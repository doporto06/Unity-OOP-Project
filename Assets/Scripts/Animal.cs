using UnityEngine;
using TMPro;

public abstract class Animal : MonoBehaviour
{
    private static Animal lastClickedAnimal;
    [SerializeField] protected TMP_Text infoText;
    protected string Name { get; set; } // ENCAPSULATION
    protected abstract void Speak();

    private void OnMouseDown()
    {
        ShowText(); // ABSTRACTION
        Speak();
    }

    private void ShowText() {
        if (lastClickedAnimal != null && lastClickedAnimal != this)
        {
            lastClickedAnimal.infoText.gameObject.SetActive(false);
        }

        infoText.gameObject.SetActive(true);
        lastClickedAnimal = this;
    }
}
