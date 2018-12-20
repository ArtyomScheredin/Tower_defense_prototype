using UnityEngine;
using System.Collections;

public class WayPointGlav : MonoBehaviour
{
    // The target marker.
    public GameObject Skeleton;
    [SerializeField] private GameObject Tower;
    // Speed in units per sec.
    public float speed;
    private void Awake()
    {
        Skeleton = gameObject;
    }
    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = 45 * Time.deltaTime;
        // Move our position a step closer to the target.
        Skeleton.transform.position = Vector3.MoveTowards(Skeleton.transform.position, Tower.transform.position, step);
    }
}