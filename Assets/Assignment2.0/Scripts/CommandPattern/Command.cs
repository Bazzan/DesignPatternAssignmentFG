using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public Player player;
    public abstract void Execute();



}
