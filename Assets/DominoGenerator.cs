using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoGenerator : MonoBehaviour
{
    public Transform lastDomino;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = lastDomino.position + lastDomino.forward;

        Vector3 rot = lastDomino.eulerAngles;
        for (int i = 0; i < 40; i++)
        {
            rot += new Vector3(0, -8.0f, 0);

            GameObject obj = Instantiate(
                prefab,
                position,
                Quaternion.Euler(rot)
                );
            position += obj.transform.forward + (-obj.transform.right) * 0.2f;

        }
    }
}
