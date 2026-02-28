namespace dev.xrlab.byos.ui
{
    using UnityEngine;
    using UnityEngine.UI;
    using dev.xrlab.byos.core;

    public class ProjectDetailPanel : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private Image projectImage;
        [SerializeField] private Sprite[] projectSprites;

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
                cart.Add(currentProjectIndex);

            Close();
        }
    }
}