﻿using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {
	
	void Update () {
		// 從滑鼠的位置到手臂的向量
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;

		//計算向量和x軸的夾角(度數)
		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		//如果Player X scale為-1(向左) 角度需做修正
		if(transform.parent.localScale.x == -1)
			rotZ = rotZ - 180;

        //設定手臂的旋轉角度為夾角
        transform.rotation = Quaternion.Euler (0f, 0f, rotZ);
	}
	
}
