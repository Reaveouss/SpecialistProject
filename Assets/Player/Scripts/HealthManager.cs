using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] float HitPoints;
    [SerializeField] float MaxHitPoints = 100;
    public Slider healthSlider;

    private void Start()
    {
        HitPoints = MaxHitPoints;
    }
    void Hit(float rawDamage)
    {
        HitPoints -= rawDamage;
        SetHealthSlider();
        Debug.Log("HIT");

        if (HitPoints <= 0)
        {
            OnDeath();
        }
    }
    private void Update()
    {
        if (HitPoints > MaxHitPoints)
        {
            HitPoints = MaxHitPoints;
        }
    }
    void Heal(float rawHealing)
    {
        HitPoints += rawHealing;
        SetHealthSlider();
    }
    private void SetHealthSlider()
    {
        if (healthSlider != null)
        {
            healthSlider.value = NormalisedHitPoints();
        }
    }
    float NormalisedHitPoints()
    {
        return HitPoints / MaxHitPoints;
    }
    private void OnDeath()
    {
        
    }
}
