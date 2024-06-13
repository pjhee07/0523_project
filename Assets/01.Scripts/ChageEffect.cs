using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ChageEffect : MonoBehaviour
{
    [SerializeField] private RectTransform _imageRect;
    private Button _startBtn;

    private void Awake()
    {
        _startBtn = GetComponent<Button>();
        _startBtn.onClick.AddListener(HandleGameStart);
    }

    private void HandleGameStart()
    {
        _imageRect.DOAnchorPosX(0, 0.5f)
            .SetEase(Ease.OutCubic)
            .OnComplete(() =>
            {
                SceneManager.LoadScene("SelectStage");
            });
    }
}
