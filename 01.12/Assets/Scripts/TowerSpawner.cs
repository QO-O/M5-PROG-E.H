using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;

    [Header("Spawn area (centered on the origin)")]
    [SerializeField] private float areaWidth = 20f;
    [SerializeField] private float areaLength = 20f;

    [Header("Spawn position")]
    [SerializeField] private float spawnY = 0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnTower();
        }
    }

    private void SpawnTower()
    {
        float x = Random.Range(-areaWidth / 2f, areaWidth / 2f);
        float z = Random.Range(-areaLength / 2f, areaLength / 2f);

        Vector3 spawnPosition = new Vector3(x, spawnY, z);
        Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}