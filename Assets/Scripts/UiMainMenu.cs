using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*using clase1;*/

namespace UiMainMenu
{
    public class Ui : MonoBehaviour
    {

        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button settingsBackButton;
        [SerializeField] private Button creditsButton;
        [SerializeField] private Button exitButton;

        [SerializeField] private GameObject settingsPanel;
        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject creditsPanel;
        [SerializeField] private GameObject playersSettingsPanel;
        [SerializeField] private GameObject settingsP1;
        [SerializeField] private GameObject settingsP2;

        [SerializeField] private Slider sliderSpeedPlayer1;
        [SerializeField] private Slider sliderSpeedPlayer2;
        [SerializeField] private Slider sliderSizeXPlayer1;
        [SerializeField] private Slider sliderSizeXPlayer2;

        /*[SerializeField] private Movement movementP1;
        [SerializeField] private Movement movementP2;*/

        [SerializeField] private PaddleMovement paddle1Movement;
        [SerializeField] private PaddleMovement paddle2Movement;
        [SerializeField] private PaddleSizeAndColour paddle1;
        [SerializeField] private PaddleSizeAndColour paddle2;


        [SerializeField] private BallMovement ballMovement;

        public KeyCode Esc;
        private void Awake()
        {
            playButton.onClick.AddListener(OnPlayButtonClicked);
            settingsButton.onClick.AddListener(OnSettingsButtonClicked);
            settingsBackButton.onClick.AddListener(OnBackToMainMenuButtonClicked);
            creditsButton.onClick.AddListener(OnCreditsButtonClicked);
            exitButton.onClick.AddListener(OnExitButtonClicked);
            /*sliderSpeedPlayer1.onValueChanged.AddListener(OnP1SpeedChange);
            sliderSpeedPlayer2.onValueChanged.AddListener(OnP2SpeedChange);*/
            sliderSpeedPlayer1.onValueChanged.AddListener(OnPaddle1SpeedChange);
            sliderSpeedPlayer2.onValueChanged.AddListener(OnPaddle2SpeedChange);
            sliderSizeXPlayer1.onValueChanged.AddListener(OnPaddle1XSizeChange);
            sliderSizeXPlayer2.onValueChanged.AddListener(OnPaddle2XSizeChange);
            mainMenuPanel.SetActive(true);
            settingsPanel.SetActive(false);
            creditsPanel.SetActive(false);
            settingsP1.SetActive(false);
            settingsP2.SetActive(false);
        }

        private void Update()
        {
            OnEsc();
        }

        public void OnTriggerEnter()
        {
            GameManager player1Score = gameObject.GetComponent<GameManager>();
            GameManager player2Score = gameObject.GetComponent<GameManager>();


        }

        private void OnDestroy()
        {
            playButton.onClick.RemoveAllListeners();
            settingsButton.onClick.RemoveAllListeners();
            settingsBackButton.onClick.RemoveAllListeners();
            creditsButton.onClick.RemoveAllListeners();
            exitButton.onClick.RemoveAllListeners();
            sliderSpeedPlayer1.onValueChanged.RemoveAllListeners();
            sliderSpeedPlayer2.onValueChanged.RemoveAllListeners();
            sliderSizeXPlayer1.onValueChanged.RemoveAllListeners();
            sliderSizeXPlayer2.onValueChanged.RemoveAllListeners();
        }
        private void OnPlayButtonClicked()
        {
            mainMenuPanel.SetActive(false);
            settingsPanel.SetActive(false);
            playersSettingsPanel.SetActive(false);
            creditsPanel.SetActive(false);
            settingsP1.SetActive(false);
            settingsP2.SetActive(false);



            Debug.Log("Play Button Clicked");
        }

        private void OnSettingsButtonClicked()
        {
            mainMenuPanel.SetActive(false);
            settingsPanel.SetActive(true);
            playersSettingsPanel.SetActive(true);
            settingsP1.SetActive(true);
            settingsP2.SetActive(true);
            creditsPanel.SetActive(false);

            Debug.Log("Settings Button Clicked");
        }

        private void OnBackToMainMenuButtonClicked()
        {
            mainMenuPanel.SetActive(true);
            settingsPanel.SetActive(false);
            playersSettingsPanel.SetActive(false);
            settingsP1.SetActive(false);
            settingsP2.SetActive(false);
            creditsPanel.SetActive(false);

        }


        private void OnCreditsButtonClicked()
        {
            mainMenuPanel.SetActive(false);
            settingsPanel.SetActive(false);
            playersSettingsPanel.SetActive(false);
            settingsP1.SetActive(false);
            settingsP2.SetActive(false);
            creditsPanel.SetActive(true);

            Debug.Log("Credits Button Clicked");
        }

        private void OnExitButtonClicked()
        {

            Debug.Log("Exit Button Clicked");
            if (UnityEditor.EditorApplication.isPlaying)
            {
                UnityEditor.EditorApplication.ExitPlaymode();
            }

        }

        private void OnEsc()
        {
            if (Input.GetKeyDown(Esc) && mainMenuPanel.activeSelf == false)
            {
                mainMenuPanel.SetActive(true);
                settingsPanel.SetActive(false);
                playersSettingsPanel.SetActive(false);
                creditsPanel.SetActive(false);
                settingsP1.SetActive(false);
                settingsP2.SetActive(false);

            }

            Debug.Log("Esc Key");
        }

        /*private void OnP1SpeedChange(float newSpeed)
        {
            newSpeed = sliderSpeedPlayer1.value;
            movementP1.SetMovementSpeed(newSpeed);
        }

        private void OnP2SpeedChange(float newSpeed)
        {
            newSpeed = sliderSpeedPlayer2.value;
            movementP2.SetMovementSpeed(newSpeed);
        }*/

        private void OnPaddle1SpeedChange(float newSpeed)
        {
            newSpeed = sliderSpeedPlayer1.value;
            paddle1Movement.SetMovementSpeed(newSpeed);
        }

        private void OnPaddle2SpeedChange(float newSpeed)
        {
            newSpeed = sliderSpeedPlayer2.value;
            paddle2Movement.SetMovementSpeed(newSpeed);
        }

        private void OnPaddle1XSizeChange(float newXScale)
        {
            newXScale = sliderSizeXPlayer1.value;
            paddle1.SetPaddleHeight(newXScale);
        }

        private void OnPaddle2XSizeChange(float newXScale)
        {
            newXScale = sliderSizeXPlayer2.value;
            paddle2.SetPaddleHeight(newXScale);
        }
    }
}
