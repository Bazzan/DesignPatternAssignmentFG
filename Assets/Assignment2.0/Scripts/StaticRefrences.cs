using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(-100)]
public class StaticRefrences : MonoBehaviour
{
    public static StaticRefrences instance;
    public Camera camera;
    public NavMeshAgent playerAgent;
    public CommandInvoker playerCommandInvoker;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    
        playerCommandInvoker = new CommandInvoker();
    }


}
