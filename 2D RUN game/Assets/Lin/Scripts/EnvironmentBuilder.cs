using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBuilder : MonoBehaviour
{
    [SerializeField]
    private List<Transform> blocks = new List<Transform>();

    [SerializeField]
    private float blockSpacing = 3;

    private void Start()
    {
        Build();
    }

    public void Build()
    {
        int index = 0;

        while(blocks.Count > 0)
        {
            int randomIndex = Random.Range(0, blocks.Count);
            var block = blocks[randomIndex];
            blocks.RemoveAt(randomIndex);

            block.transform.position = new Vector2(index * blockSpacing, block.transform.position.y);
            index++;
        }
    }
}
