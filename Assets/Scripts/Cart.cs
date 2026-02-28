namespace dev.xrlab.byos.core
{
    using System.Collections.Generic;
    using UnityEngine;

    public class Cart : MonoBehaviour
    {
        [SerializeField] private List<int> projectIds = new();

        public void Add(int projectId)
        {
            if (!projectIds.Contains(projectId))
                projectIds.Add(projectId);
        }

        public IReadOnlyList<int> GetProjects()
        {
            return projectIds;
        }

        public void Clear()
        {
            projectIds.Clear();
        }
    }
}