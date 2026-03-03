namespace dev.xrlab.byos.ui
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class UIManager : MonoBehaviour
    {
        [Header("Main Panels")]
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject infoPanel;
        [SerializeField] private GameObject ingredientsPanel;
        [SerializeField] private GameObject burgerPanel;
        [SerializeField] private GameObject qrPanel;

        [Header("Overlay Panels")]
        [SerializeField] private GameObject projectsPanel; // Overlay

        private GameObject currentPanel;

        private void Start()
        {
            Show(startPanel);
            projectsPanel.SetActive(false); // aseguramos que el overlay inicie apagado
        }

        // ---------- Main Navigation ----------

        public void GoToInfo()
        {
            Show(infoPanel);
        }

        public void GoToIngredients()
        {
            Show(ingredientsPanel);
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
            SceneManager.LoadScene(0);
        }

        // ---------- Overlay Control (Projects) ----------

        public void OpenProjects()
        {
            projectsPanel.SetActive(true);
        }

        public void CloseProjects()
        {
            projectsPanel.SetActive(false);
        }

        // ---------- Internal ----------

        private void Show(GameObject panel)
        {
            if (currentPanel != null && currentPanel != panel)
                currentPanel.SetActive(false);

            currentPanel = panel;
            currentPanel.SetActive(true);
        }
    }
}