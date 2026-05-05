using UnityEngine;
using UnityEngine.Rendering;

public class PlayerSorting : MonoBehaviour
{
    public int defaultOrder;

    private void Awake()
    {
        SortingGroup sg = GetComponent<SortingGroup>();
        defaultOrder = sg.sortingOrder;
    }
}