using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    

    [SerializeField]
    private SpriteRenderer _prefabToSpawn;

    private SpriteRenderer _spawnerSprite;
    private int _numToSpawn = 0;

    private void Awake()
    {
        _spawnerSprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        EventManager.Instance.OnMinigame1 += SpawnCircles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { EventManager.Instance.StartMinigame1(); } 
    }
    

    private void SpawnCircles()
    {
        _numToSpawn = Random.Range(4, 9);
        
        var boundMod = 2f;
       

        for (int i = 0; i < _numToSpawn; i++)
        {    
            
            var position = new Vector3(Random.Range(_spawnerSprite.bounds.min.x + boundMod, _spawnerSprite.bounds.max.x - boundMod), Random.Range(_spawnerSprite.bounds.min.y + boundMod, _spawnerSprite.bounds.max.y - boundMod), 1);
            
            var newCircle = Instantiate(_prefabToSpawn, position, Quaternion.identity, this.gameObject.transform);
            newCircle.name = _prefabToSpawn.name + $"{i}";
            newCircle.GetComponent<CircleInfo>().CircleIndex = i + 1;  
        }
        EventManager.Instance.CirclesSpawned();
    }

    private void OnEnable()
    {
        //EventManager.Instance.OnMinigame1 += SpawnCircles;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnMinigame1 -= SpawnCircles;
    }

    IEnumerator TimeBetweenSpawns(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
