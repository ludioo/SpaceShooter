using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Arena : MonoBehaviour
    {
        public GameObject water;
        public Island[] islands;
        private float generateIslandDelayCount;
        private Vector2 minPosition, maxPosition;
        void Start()
        {
            minPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            maxPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
            float waterPosX = minPosition.x, waterPosY = minPosition.y;
            SpriteRenderer instWater = (Instantiate(water, new
            Vector2(waterPosX, waterPosY), Quaternion.identity) as
            GameObject).GetComponent<SpriteRenderer>();
            instWater.transform.parent = this.transform;
            while (waterPosY - 2 * instWater.sprite.bounds.max.y <
            maxPosition.y)
            {
                waterPosX = minPosition.x;
                while (waterPosX - 2 * instWater.sprite.bounds.max.x <
                maxPosition.x)
                {
                    instWater = (Instantiate(water, new
                    Vector2(waterPosX, waterPosY), Quaternion.identity) as
                    GameObject).GetComponent<SpriteRenderer>();
                    instWater.transform.parent = this.transform;
                    waterPosX += 2 * instWater.sprite.bounds.max.x;
                }
                waterPosY += 2 * instWater.sprite.bounds.max.y;
            }
        }
        void Update()
        {
            generateIslandDelayCount -= Time.deltaTime;
            if (generateIslandDelayCount <= 0)
            {
                Instantiate(islands[Random.Range(0, islands.Length - 1)], new
                Vector2(Random.Range(minPosition.x, maxPosition.x), 20),
                Quaternion.identity);
                generateIslandDelayCount = Random.Range(5, 15);
            }
        }
    }
