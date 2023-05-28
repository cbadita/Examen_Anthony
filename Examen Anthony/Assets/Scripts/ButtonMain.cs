using UnityEngine;

public abstract class ButtonMain : MonoBehaviour
{
    [SerializeField] protected int score;

    public abstract void Click();

}
