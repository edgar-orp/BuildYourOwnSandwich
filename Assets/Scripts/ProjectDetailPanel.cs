namespace dev.xrlab.byos.ui
{
    using dev.xrlab.byos.core;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class ProjectDetailPanel : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private Image projectImage;
        [SerializeField] private Sprite[] projectSprites;
        [SerializeField] private TMP_Text projectsCounterText;

        [Header("References")]
        [SerializeField] private Cart cart;

        [SerializeField] private int currentProjectIndex = -1;

        public void Open(int projectIndex)
        {
            currentProjectIndex = projectIndex;
            projectImage.sprite = projectSprites[projectIndex];
        }

        public void Close()
        {
            currentProjectIndex = -1;
        }

        public void Buy()
        {
            if (currentProjectIndex >= 0)
            {
                cart.Add(currentProjectIndex);
                UpdateCounter();
            }

            Close();
        }

        private void UpdateCounter()
        {
            int count = cart.GetProjects().Count;
            projectsCounterText.text = count.ToString();
        }
    }
}