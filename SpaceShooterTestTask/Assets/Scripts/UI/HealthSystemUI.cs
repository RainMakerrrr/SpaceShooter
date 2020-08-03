using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystemUI : MonoBehaviour
{
    [SerializeField] private List<Image> Hearts = new List<Image>();
    private int _index;
    private PlayerStats _player;

    private void Start()
    {
        _index = 0;
        _player = FindObjectOfType<PlayerStats>();
        Hearts.AddRange(GetComponentsInChildren<Image>());
        _player.OnTakingDamage += DamageUIHandler; 
    }

    private void DamageUIHandler()
    {
        Hearts[_index].enabled = false;
        _index++;
    }
}
