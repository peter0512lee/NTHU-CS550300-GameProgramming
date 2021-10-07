using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CarrotVFX : MonoBehaviour
{

	public GameObject carrotDestroy;
	public float rotateSpeed;
	public float floatingSpeed;
	public float floatingRange;

	private float rotIdx;
	private float floatIdx;
	private float initHeight;
	private Vector3 initRot;

	void Start()
	{
		rotIdx = 0.0f;
		floatIdx = 0.0f;

		initHeight = transform.position.y;
		initRot = transform.rotation.eulerAngles;
	}
	private void Update()
	{
		Float();
		Rotate();
	}

	void Rotate()
	{
		Vector3 rot = initRot;
		rotIdx = (rotIdx + 100.0f * rotateSpeed * Time.deltaTime) % 360.0f;
		rot.y = (rot.y + rotIdx);

		transform.rotation = Quaternion.Euler(rot);
	}

	void Float()
	{
		float y = initHeight;

		floatIdx = (floatIdx + floatingSpeed * Time.deltaTime) % 360.0f;
		y += Mathf.Sin(floatIdx) * floatingRange;

		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}

	private void OnDestroy()
	{
		if (!EditorApplication.isPlayingOrWillChangePlaymode &&
			 EditorApplication.isPlaying) return;

		Vector3 offset = new Vector3(0.0f, 0.5f, 0.0f);
		GameObject obj = Instantiate(carrotDestroy, this.transform.position + offset, Quaternion.identity);
		ParticleSystem p = obj.GetComponent<ParticleSystem>();

		float duration = p.main.duration + p.main.startLifetime.constant;
		p.Play();
		Destroy(obj, duration);
	}
}
