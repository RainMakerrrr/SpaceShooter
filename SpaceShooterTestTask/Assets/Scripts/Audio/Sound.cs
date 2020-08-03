using UnityEngine;


[System.Serializable]
public class Sound
{
    [SerializeField] private string _name;
    
    public int Index;
    public AudioClip AudioClip;

    [HideInInspector]
    public AudioSource AudioSource;
    
    [Range(0f, 1f)]
    public float Volume;

    [Range(0.1f, 3f)]
    public float Pitch;

}
