using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    public GameObject animal;
    public float timemax, timemin;
    public float posisimax, posisimin;

    // Start is called before the first frame update



    void Start()
    {
        StartCoroutine(SpawnAnimal());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnAnimal()
    {
        Instantiate(animal, transform.position + Vector3.right * Random.Range(posisimin, posisimax), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(timemin, timemax));
        StartCoroutine(SpawnAnimal());

    }


}
