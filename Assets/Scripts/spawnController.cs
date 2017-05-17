using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour {

    public GameObject barreiraPrefab; //Objeto a ser spawnado
    public float rateSpawn;           //Intervalo de spawn
    public float currentTime;         //Armazena o tempo entre um spawn e outro
    private int posicao;
    private float y;

	// Use this for initialization
	void Start () {
        currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpawn)
        {
            currentTime = 0;
            posicao = Random.Range(1, 100);
            
            GameObject tempPrefab = Instantiate(barreiraPrefab) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, tempPrefab.transform.position.y, tempPrefab.transform.position.z);
        }
	}
}
