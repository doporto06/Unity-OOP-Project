using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    private void Start()
    {
        Name = "Max";
    }

    protected override void Speak() // POLYMORPHISM
    {
        infoText.text = $"{Name} is a cat and says: Meow!";
    }
}
