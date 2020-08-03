using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private JoyButton _joyButton;
    private float _nextShootTime = 0f;
    private float _shootRate = 1.2f;

    private void Start()
    {
        _joyButton = FindObjectOfType<JoyButton>();
    }

    private void Update()
    {
        if (Time.time > _nextShootTime)
        {
            if (Input.GetKeyDown(KeyCode.Space) || _joyButton.IsPressed)
            {
                Shoot();
                AudioManager.Instance.Play(0);
                _nextShootTime = Time.time + 1 / _shootRate;
            }
        }
    }

    private void Shoot()
    {
        var bullet =  ShotPool.Instance.Get();
        bullet.transform.position = transform.position;
        bullet.transform.rotation = Quaternion.identity;
        bullet.gameObject.SetActive(true);
        
    }
}
