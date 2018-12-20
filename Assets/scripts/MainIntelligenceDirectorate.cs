using UnityEngine;

public class MainIntelligenceDirectorate : MonoBehaviour
{
    private static int count = 0;
    public StepBCDHandler FloorHandler;
    public Vector3[] _massiveBcd = new Vector3[10];

    void Awake()
    {
        FloorHandler.CollisionEnter += OnFloorCollision;
        FloorHandler.CollisionStay += OnFloorStay;
    }

    private void OnFloorCollision(object sender, StepBCDHandler.StepBCDHandlerArgs e)
    {
        Debug.Log(e.Collision.contacts[0].point);
        Debug.Log(e.Collision.gameObject.name);
    }

    private void OnFloorStay(object sender, StepBCDHandler.StepBCDHandlerArgs e)
    {
        _massiveBcd[count % 20] = e.Collision.contacts[0].point;
        count++;
    }


}