using UnityEngine;

[CreateAssetMenu(fileName = "Animator Provider", menuName = "Scriptable Objects/Animator Provider")]
public class AnimatorProvider : ScriptableObject
{
    public RuntimeAnimatorController animatorController;
}