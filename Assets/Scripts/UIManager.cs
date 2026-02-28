namespace dev.xrlab.byos.ui
{
    using UnityEngine;

    public class UIManager : MonoBehaviour
    {
        [Header("Panels")]
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject infoPanel;
        [SerializeField] private GameObject ingredientsPanel;
        [SerializeField] private GameObject projectsPanel;
        [SerializeField] private GameObject burgerPanel;
        [SerializeField] private GameObject qrPanel;

        private GameObject currentPanel;

        private void Start()
        {
            Show(startPanel);
        }

        // ---------- Navigation ----------

        public void GoToInfo()
        {
            Show(infoPanel);
        }

        public void GoToIngredients()
        {
            Show(ingredientsPanel);
        }

        public void GoToProjects()
        {
            Show(projectsPanel);
        }

        public void GoToBurger()
        {
            Show(burgerPanel);
        }

        public void GoToQR()
        {
            Show(qrPanel);
        }

        public void GoToStart()
        {
            Show(startPanel);
        }

        // ---------- Internal ----------

        private void Show(GameObject panel)
        {
            if (currentPanel != null)
                currentPanel.SetActive(false);

            currentPanel = panel;
            currentPanel.SetActive(true);
        }
    }
}