using UnityEngine;

public abstract class Enemy : MonoBehaviour, ILevelObjectConfigure
{
    public EnemyConfig Config;
    
    public void Configure(LevelObjectConfiguration config)
    {
        
    }
}