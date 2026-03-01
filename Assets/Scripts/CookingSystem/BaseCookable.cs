using System.Collections;
using UnityEngine;

public class BaseCookable : MonoBehaviour, ICookable
{
    [SerializeField] Color rawColor;
    [SerializeField] Color cookedColor;
    [SerializeField] Color burntColor;
    [SerializeField] protected float cookingTime;
    protected bool isCooking = false;
    [SerializeField] protected float burnTime;
    protected Renderer renderer;

    public void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    public void Cook()
    {
        StartCoroutine(CookingRoutine());
    }

    private void Update()
    {
        if (!isCooking)
        {
            StopAllCoroutines();
        }
    }

    public virtual IEnumerator CookingRoutine()
    {
        isCooking = true;
        yield return new WaitForSeconds(cookingTime);
        // At this point food is done.
        if (renderer != null)
        {
            renderer.materials[0].color = cookedColor;
        }
        yield return new WaitForSeconds(burnTime);
        // At this point food is burnt.
        if (renderer != null)
        {
            renderer.materials[0].color = burntColor;
        }

    }

    public void StopCooking()
    {
        isCooking = false;
    }
}
