using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public event UnityAction OnDie;
    public event UnityAction OnTakingDamage;

    [SerializeField] private PlayerData _playerData; 

    public void TakeDamage()
    {
        _playerData.Health--;
        OnTakingDamage?.Invoke();
        if (_playerData.Health <= 0)
            Die();
    }
    private void Die()
    {
        Debug.Log("DIe");
        OnDie?.Invoke();
        Destroy(gameObject);
    }
}
