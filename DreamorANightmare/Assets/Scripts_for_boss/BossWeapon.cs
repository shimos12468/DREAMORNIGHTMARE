using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
	public int attackDamage = 20;
	public int enragedAttackDamage = 40;

	public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;
    public Transform firepoint;
	public void Attack()
	{
		Debug.Log("TakeDamage");
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

        RaycastHit2D hitinfo = Physics2D.Raycast(firepoint.position,firepoint.right);

        Debug.Log(hitinfo.transform.tag);
        if (hitinfo&&hitinfo.transform.tag=="Player")
        {
            Debug.Log("TakeDamagefew");
            hitinfo.transform.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
        //if (colInfo != null&&colInfo.tag=="Player")
        //{
        //Debug.Log("TakeDamagefew");
        //colInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        //}
    }

	public void EnragedAttack()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

        RaycastHit2D hitinfo = Physics2D.Raycast(firepoint.position, firepoint.right);

        Debug.Log(hitinfo.transform.tag);
        if (hitinfo && hitinfo.transform.tag == "Player")
        {
            hitinfo.transform.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }

	void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
	}
}
