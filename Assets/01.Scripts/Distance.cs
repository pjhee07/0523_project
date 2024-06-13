using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;

public class Distance : MonoBehaviour
{
    public TextMeshProUGUI distanceText; 
    [SerializeField] private int distance;
    [SerializeField] private RectTransform _imageRect;
    private float interval = 1f;

    void Start()
    {
        StartCoroutine(DecreaseDistance());
    }

    IEnumerator DecreaseDistance()
    {
        while (distance > 0)
        {
            distance--;
            distanceText.text = "남은 거리: " + distance.ToString();
            yield return new WaitForSeconds(interval);
        }
        ChangeScene();
    }

    void ChangeScene()
    {
        _imageRect.DOAnchorPosX(0, 0.5f)
           .SetEase(Ease.OutCubic)
           .OnComplete(() =>
           {
               SceneManager.LoadScene("GameClear");
           });
    }
}
