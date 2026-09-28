using UnityEngine;

public class VRMenuController : MonoBehaviour
{
    [Header("Menu")]
        public GameObject menuRoot;

            [Header("Controller Anchors")]
                public Transform leftHandAnchor;
                    public Transform rightHandAnchor;

                        [Header("Position")]
                            public bool followRightHand = true;
                                public float distance = 0.25f;

                                    private bool menuOpen;

                                        private void Start()
                                            {
                                                    SetMenu(false);
                                                        }

                                                            private void Update()
                                                                {
                                                                        if (Input.GetKeyDown(KeyCode.M))
                                                                                    ToggleMenu();

                                                                                            if (!menuOpen || menuRoot == null)
                                                                                                        return;

                                                                                                                Transform hand = followRightHand
                                                                                                                            ? rightHandAnchor
                                                                                                                                        : leftHandAnchor;

                                                                                                                                                if (hand == null)
                                                                                                                                                            return;

                                                                                                                                                                    menuRoot.transform.position =
                                                                                                                                                                                hand.position + hand.forward * distance;

                                                                                                                                                                                        menuRoot.transform.rotation =
                                                                                                                                                                                                    Quaternion.LookRotation(
                                                                                                                                                                                                                    menuRoot.transform.position -
                                                                                                                                                                                                                                    Camera.main.transform.position
                                                                                                                                                                                                                                                );
                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                        public void ToggleMenu()
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                    SetMenu(!menuOpen);
                                                                                                                                                                                                                                                                        }

                                                                                                                                                                                                                                                                            public void OpenMenu()
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                        SetMenu(true);
                                                                                                                                                                                                                                                                                            }

                                                                                                                                                                                                                                                                                                public void CloseMenu()
                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                            SetMenu(false);
                                                                                                                                                                                                                                                                                                                }

                                                                                                                                                                                                                                                                                                                    private void SetMenu(bool state)
                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                menuOpen = state;

                                                                                                                                                                                                                                                                                                                                        if (menuRoot != null)
                                                                                                                                                                                                                                                                                                                                                    menuRoot.SetActive(state);
                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                        }