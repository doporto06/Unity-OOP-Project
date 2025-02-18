using UnityEngine;

public class Chicken : Animal // INHERITANCE
{
    
    private void Start()
    {
        Name = "Bob";
    }

    protected override void Speak() // POLYMORPHISM
    {
        infoText.text = $"{Name} is a chicken and says Cluck!";
    }
}
