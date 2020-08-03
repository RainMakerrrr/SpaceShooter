using UnityEngine;

[CreateAssetMenu(fileName ="PlayerData", menuName ="Data/PlayerData")]
public class PlayerData : ScriptableObject
{
	public int Health;
	public int CountOfAsteroids;
	public Vector3 Position;
	
}
