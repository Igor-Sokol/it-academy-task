using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Subject[] subjects;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(subjects[Random.Range(0, subjects.Length)]);
        }
    }
}
