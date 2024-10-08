using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.Threading.Tasks;
using UnityEditor;
using Unity.VisualScripting;

public class PauseMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] RectTransform pausePanelRect;
    [SerializeField] RectTransform pauseButtonRect;
    [SerializeField] RectTransform timerTextRect;
    [SerializeField] RectTransform gemsCollectRect;
    [SerializeField] RectTransform groundMobRect;
    [SerializeField] RectTransform groundMobRect2;
    [SerializeField] RectTransform groundMobRect3;
    [SerializeField] RectTransform groundMobRect4;
    [SerializeField] RectTransform groundMobRect5;
    [SerializeField] RectTransform groundMobRect6;
    [SerializeField] RectTransform groundMobRect7;
    [SerializeField] float topPosY, middlePosY;
    [SerializeField] float tweenDuration;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] CanvasGroup canvasGroup2;
    private static PauseMenu instance;
    public static PauseMenu Instance { get => instance; }


    void Awake()
    {
        if (PauseMenu.instance != null)
        {
            Debug.LogError("Only 1 PauseMenu allow to exist");
        }
        PauseMenu.instance = this;
    }

    void Start()
    {
        
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        PausePanelIntro();
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }

    public async void Remuse()
    {
        await PausePanelOutro();
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Settings()
    {
        settingsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void Back()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    void PausePanelIntro()
    {
        canvasGroup.DOFade(1, tweenDuration).SetUpdate(true);
        canvasGroup2.DOFade(1, tweenDuration).SetUpdate(true);
        pausePanelRect.DOAnchorPosY(middlePosY, tweenDuration).SetUpdate(true);
        pauseButtonRect.DOAnchorPosX(200, tweenDuration).SetUpdate(true);
        gemsCollectRect.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect2.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect3.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect4.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect5.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect6.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
        groundMobRect7.DOAnchorPosX(-400, tweenDuration).SetUpdate(true);
    }

    async Task PausePanelOutro()
    {
        canvasGroup.DOFade(1, tweenDuration).SetUpdate(true);
        canvasGroup2.DOFade(0, tweenDuration).SetUpdate(true);
        await pausePanelRect.DOAnchorPosY(topPosY, tweenDuration).SetUpdate(true).AsyncWaitForCompletion();
        pauseButtonRect.DOAnchorPosX(-5, tweenDuration).SetUpdate(true);
        gemsCollectRect.DOAnchorPosX(0, tweenDuration).SetUpdate(true);
        groundMobRect.DOAnchorPosX(0, tweenDuration).SetUpdate(true);
        groundMobRect2.DOAnchorPosX(0, tweenDuration).SetUpdate(true);
        groundMobRect3.DOAnchorPosX(0, tweenDuration).SetUpdate(true);
        groundMobRect4.DOAnchorPosX(0, tweenDuration).SetUpdate(true);
        groundMobRect5.DOAnchorPosX(300, tweenDuration).SetUpdate(true);
        groundMobRect6.DOAnchorPosX(300, tweenDuration).SetUpdate(true);
        groundMobRect7.DOAnchorPosX(300, tweenDuration).SetUpdate(true);
    }
}
