using UnityEngine;
using UnityEngine.Rendering;

public class SortingOrderTrigger : MonoBehaviour
{
    public int targetOrder = 12;
    public bool restoreDefault = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        SortingGroup sg = other.GetComponent<SortingGroup>();
        if (sg == null) return;

        PlayerSorting ps = other.GetComponent<PlayerSorting>();

        if (restoreDefault)
            sg.sortingOrder = ps.defaultOrder;
        else
            sg.sortingOrder = targetOrder;
    }
}