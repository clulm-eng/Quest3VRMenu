using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StandaloneVRMenu : MonoBehaviour
{
    [Header("Menu")]
        public GameObject menuRoot;
            public Transform content;
                public Button buttonPrefab;
                    public Toggle togglePrefab;

                        [Header("Settings")]
                            public bool playerOutline;
                                public bool showNames;
                                    public bool enhancedGraphics;
                                        public bool vibration;
                                            public bool leftHanded;

                                                private void Start()
                                                    {
                                                            CreateToggle("Player Outline", playerOutline,
                                                                        value => playerOutline = value);

                                                                                CreateToggle("Show Names", showNames,
                                                                                            value => showNames = value);

                                                                                                    CreateToggle("Enhanced Graphics", enhancedGraphics,
                                                                                                                value => enhancedGraphics = value);

                                                                                                                        CreateToggle("Controller Vibration", vibration,
                                                                                                                                    value => vibration = value);

                                                                                                                                            CreateToggle("Left-Handed Mode", leftHanded,
                                                                                                                                                        value => leftHanded = value);

                                                                                                                                                                CreateButton("Test Feature", TestFeature);
                                                                                                                                                                        CreateButton("Reset Settings", ResetSettings);
                                                                                                                                                                                CreateButton("Close Menu", CloseMenu);
                                                                                                                                                                                    }

                                                                                                                                                                                        private void CreateToggle(
                                                                                                                                                                                                string label,
                                                                                                                                                                                                        bool initialValue,
                                                                                                                                                                                                                UnityEngine.Events.UnityAction<bool> callback)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                            Toggle toggle = Instantiate(togglePrefab, content);

                                                                                                                                                                                                                                    TMP_Text text = toggle.GetComponentInChildren<TMP_Text>();

                                                                                                                                                                                                                                            if (text != null)
                                                                                                                                                                                                                                                        text.text = label;

                                                                                                                                                                                                                                                                toggle.isOn = initialValue;
                                                                                                                                                                                                                                                                        toggle.onValueChanged.AddListener(callback);
                                                                                                                                                                                                                                                                            }

                                                                                                                                                                                                                                                                                private void CreateButton(
                                                                                                                                                                                                                                                                                        string label,
                                                                                                                                                                                                                                                                                                UnityEngine.Events.UnityAction callback)
                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                            Button button = Instantiate(buttonPrefab, content);

                                                                                                                                                                                                                                                                                                                    TMP_Text text = button.GetComponentInChildren<TMP_Text>();

                                                                                                                                                                                                                                                                                                                            if (text != null)
                                                                                                                                                                                                                                                                                                                                        text.text = label;

                                                                                                                                                                                                                                                                                                                                                button.onClick.AddListener(callback);
                                                                                                                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                                                                                                                        private void TestFeature()
                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                    Debug.Log("Test feature activated.");
                                                                                                                                                                                                                                                                                                                                                                        }

                                                                                                                                                                                                                                                                                                                                                                            private void ResetSettings()
                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                        playerOutline = false;
                                                                                                                                                                                                                                                                                                                                                                                                showNames = false;
                                                                                                                                                                                                                                                                                                                                                                                                        enhancedGraphics = false;
                                                                                                                                                                                                                                                                                                                                                                                                                vibration = false;
                                                                                                                                                                                                                                                                                                                                                                                                                        leftHanded = false;

                                                                                                                                                                                                                                                                                                                                                                                                                                foreach (Toggle toggle in content.GetComponentsInChildren<Toggle>())
                                                                                                                                                                                                                                                                                                                                                                                                                                            toggle.isOn = false;
                                                                                                                                                                                                                                                                                                                                                                                                                                                }

                                                                                                                                                                                                                                                                                                                                                                                                                                                    private void CloseMenu()
                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                if (menuRoot != null)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            menuRoot.SetActive(false);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }