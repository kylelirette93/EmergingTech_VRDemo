using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField] private GameObject burgerPrefab;
    //[SerializeField] private Transform burgerSpawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cookable"))
        {
            // Spawn another burger.
            SpawnBurger();
        }
    }

    private void SpawnBurger()
    {
        Instantiate(burgerPrefab, burgerPrefab.transform.position, Quaternion.identity);
    }
}
