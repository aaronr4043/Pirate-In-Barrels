using UnityEngine;
using System.Collections;

public class WaveSpawning : MonoBehaviour {

    float spawnCD = 5.0f;
    float spawnCDremaining = 0;
    bool waveCheckEnemy;
    bool waveCheckIncrement;

    [System.Serializable]
    public class WaveComponent
    {
        public GameObject enemyPrefab;
        public int num;
        [System.NonSerialized]
        public int spawned = 0;
    }

    public WaveComponent[] waveComps;

    void Start()
    {
        waveCheckEnemy = false;
        waveCheckIncrement = false;

    }//end start

    void Update()
    {
        
        spawnCDremaining -= Time.deltaTime;
        if (spawnCDremaining < 0)
        {
            bool didSpawn = false;
            spawnCDremaining = spawnCD;
            //go through waves
            foreach(WaveComponent wc in waveComps)
            {
                if (wc.spawned < wc.num)
                {
                    wc.spawned++;
                    
                    Instantiate(wc.enemyPrefab, this.transform.position, this.transform.rotation);
                    didSpawn = true;

                    if (wc.enemyPrefab.tag == "Enemy")
                    {
                        waveCheckEnemy = true;

                    }//end if

                    if(wc.enemyPrefab.tag == "WavePause" && waveCheckEnemy)
                    {
                        CoreBehaviour.waveIncrement();
                        waveCheckEnemy = false;

                    }//end if
                    
                    break;
                }
            }//end for each

        }
    }//end update
    
}
