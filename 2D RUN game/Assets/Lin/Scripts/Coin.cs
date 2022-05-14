using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class Coin : MonoBehaviour
    {
        [SerializeField]
        private float roundTimeGain = 5f;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GamePlayManager.Instance.TimeLeft += roundTimeGain;
                GamePlayManager.Instance.Score++;
                Destroy(gameObject);
            }
        }
    }
}

