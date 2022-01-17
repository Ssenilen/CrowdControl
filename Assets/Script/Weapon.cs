using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public enum Type { Melee, Range };
    public Type type;
    public int damage;
    public float rate;
    public BoxCollider meleeArea;
    public TrailRenderer trailEffect;

    public void Use()
    {
        if (type == Type.Melee)
        {
            StopCoroutine("Swing");
            StartCoroutine("Swing");
        }
    }

    IEnumerator Swing()
    {
        yield return new WaitForSeconds(0.1f); // 0.1초 대기
        meleeArea.enabled = true;
        trailEffect.enabled = true;
        
        yield return new WaitForSeconds(0.3f); // 0.3초 대기
        meleeArea.enabled = false;
        
        yield return new WaitForSeconds(0.3f); // 0.3초 대기
        trailEffect.enabled = true;
    }
}
