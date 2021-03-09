using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 縦14 横10のmap
        var map = new List<List<int>>();
        for(int i = 1; i <= 20; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                map[i].Add(0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public int[] map()
    {
        return (map);
    }
    */
}
