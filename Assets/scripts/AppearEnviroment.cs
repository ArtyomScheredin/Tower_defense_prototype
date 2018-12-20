using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearEnviroment : MonoBehaviour
{
    public Rigidbody groundPrefab;
    public Rigidbody ground;
    public Rigidbody rocksPrefab;
    public Rigidbody rocks;
    public Rigidbody treePrefab;
    public Rigidbody tree;
    public Rigidbody towerPrefab;
    public Rigidbody tower;
    public Rigidbody mortar;
    public Rigidbody mortarPrefab;
    void Start()
    {
        ground = Instantiate(groundPrefab, transform.position + new Vector3(0, -591.7f, 0), Quaternion.identity);
        rocks = Instantiate(rocksPrefab, transform.position + new Vector3(-8, -592, 0), Quaternion.identity);
        tree = Instantiate(treePrefab, transform.position + new Vector3(295, -64, -113), Quaternion.identity);
        tower = Instantiate(towerPrefab, transform.position + new Vector3(0, -120, 0), Quaternion.identity);
        mortar = Instantiate(mortarPrefab, transform.position + new Vector3(-48.7f, 223.7f, 58.9f), Quaternion.identity);
    }
}
