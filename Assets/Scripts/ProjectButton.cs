namespace dev.xrlab.byos.ui
{
    using UnityEngine;

    public class ProjectButton : MonoBehaviour
    {
        [SerializeField] private int projectIndex;
        [SerializeField] private ProjectDetailPanel detailPanel;

        public void OnClick()
        {
            detailPanel.Open(projectIndex);
        }
    }
}