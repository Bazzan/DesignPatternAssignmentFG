using UnityEngine;

public class MoveCommand : Command
{
    Vector3 MoveTo;
    Transform transformToMove;
    public MoveCommand(Vector3 MoveTo, Transform transformToMove)
    {
        this.MoveTo = MoveTo;
        this.transformToMove = transformToMove;
        Debug.Log("MoveCommand created");

    }

    public override void Execute()
    {

        transformToMove.position = MoveTo;
        Debug.Log($"moved {transformToMove.name}");
    }

    //public IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(1f);
    //}
}

