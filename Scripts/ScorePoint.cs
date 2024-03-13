
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScorePoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    private int ScoreNum;

    private void Start()
    {
        ScoreNum = 0;
        ScoreText.text = "Score: " + ScoreNum;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            ScoreNum++;
            Destroy(collision.gameObject);
            ScoreText.text = "Score: " + ScoreNum;
        }
      
    }

}
