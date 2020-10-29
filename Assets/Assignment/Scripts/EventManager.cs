using UnityEngine;

public abstract class EventManager : MonoBehaviour
{
    /// <summary>
    /// class that is supposed to manage and hold diffrent events in this case 
    /// OnTakingDamge. Which is only updating the enemys healthbar;
    /// </summary>

    public delegate void OnTakingDamageDelegete();
    public static event OnTakingDamageDelegete OnTakingDamage;

    public static void FireOnTakingDamage()
    {
        OnTakingDamage();
    }


}

