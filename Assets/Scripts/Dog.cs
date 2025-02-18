using UnityEngine;

public class Dog : Animal // INHERITANCE
{
    
    private void Start()
    {
        Name = "Sam";
    }
    
    protected override void Speak() // POLYMORPHISM
    {
        infoText.text = $"{Name} is a dog and says Woof!";
    }
}
