using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExpManager : MonoBehaviour
{
    [SerializeField] float Exp = 0f;
    [SerializeField] float ExpMax = 100f;
    [SerializeField] float ExpMultiplier = 1.2f;
    public Slider ExpSlider;
    void Start()
    {
    }
    void Update()
    {
        
    }
    void ExpAdded(float rawExp)
    {
        Exp += rawExp;
        SetExpSlider();
        if (Exp >= ExpMax)
        {
            Exp = 0;
            ExpMax = ExpMax * ExpMultiplier;
            SetExpSlider();
        }
    }
    private void SetExpSlider()
    {
        if ( ExpSlider != null )
        {
            ExpSlider.value = NormalisedExp();
        }
    }
    float NormalisedExp()
    {
        return Exp / ExpMax;
    }
}
