using dev.xrlab.byos.core;
using UnityEngine;
using UnityEngine.UI;

namespace dev.xrlab
{
    public class BurgerViewController : MonoBehaviour
    {
        [Header("UI Slots (P_00 to P_14)")]
        [SerializeField] private GameObject[] projectSlots;   // P_00 … P_14

        [Header("Project Sprites")]
        [SerializeField] private Sprite[] projectSprites;     // index = projectId

        [Header("References")]
        [SerializeField] private Cart cart;

        private void Awake()
        {
            ClearSlots();
        }

        public void RefreshBurgerView()
        {
            ClearSlots();

            int leftCount = 0;   // P_00 – P_04
            int centerCount = 0; // P_05 – P_09
            int rightCount = 0;  // P_10 – P_14

            foreach (int projectId in cart.GetProjects())
            {
                int slotIndex = GetSlotIndex(projectId, ref leftCount, ref centerCount, ref rightCount);

                if (slotIndex < 0 || slotIndex >= projectSlots.Length)
                    continue;

                Image image = projectSlots[slotIndex].GetComponent<Image>();
                if (image != null)
                    image.sprite = projectSprites[projectId];

                projectSlots[slotIndex].SetActive(true);
            }
        }

        private int GetSlotIndex(int projectId, ref int left, ref int center, ref int right)
        {
            // Left group (0–4) → P_00 – P_04
            if (projectId >= 0 && projectId <= 4)
            {
                if (left >= 5) return -1;
                return left++;
            }

            // Center group (5–9) → P_05 – P_09
            if (projectId >= 5 && projectId <= 9)
            {
                if (center >= 5) return -1;
                return 5 + center++;
            }

            // Right group (10–14) → P_10 – P_14
            if (projectId >= 10 && projectId <= 14)
            {
                if (right >= 5) return -1;
                return 10 + right++;
            }

            return -1;
        }

        private void ClearSlots()
        {
            for (int i = 0; i < projectSlots.Length; i++)
                projectSlots[i].SetActive(false);
        }
    }
}