using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] GameObject TurretProjecitlePrefab;
    [SerializeField] float firePeriod = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireProjectile());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FireProjectile()
    {
        while (1 == 1)
        {

            GameObject laser = Instantiate(
                     TurretProjecitlePrefab, transform.position,
                    Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);
            yield return new WaitForSeconds(firePeriod);
        }
    }

}
