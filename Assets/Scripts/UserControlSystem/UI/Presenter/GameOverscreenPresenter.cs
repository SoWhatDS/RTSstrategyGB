using System.Text;
using TMPro;
using UniRx;
using UnityEngine;
using Zenject;

public class GameOverscreenPresenter : MonoBehaviour
{
    [Inject] private IGameStatus _gameStatus;

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _view;



    [Inject]
    private void Init()
    {
        _view.SetActive(false);
        _gameStatus.Status.ObserveOnMainThread().Subscribe(result =>
        {
            var sb = new StringBuilder($"Game Over!");
            if (result == 0)
            {
                sb.AppendLine("?????!");
            }
            else
            {
                sb.AppendLine($"???????? ?????? ?{result}");
            }
            _view.SetActive(true);
            _text.text = sb.ToString();
            Time.timeScale = 0;
        });
    }

}
