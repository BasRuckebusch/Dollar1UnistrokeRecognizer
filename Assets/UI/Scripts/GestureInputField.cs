using TMPro;
using UnityEngine;

public class GestureInputField : MonoBehaviour
{
	[SerializeField] private TMP_InputField input;

	private void Start()
	{
		input.onValueChanged.AddListener(UpdateName);
	}
	private void UpdateName(string newValue)
	{
		GestureManager.Instance.templateName = newValue;
	}

	private void OnDestroy()
	{
		input.onValueChanged.RemoveListener(UpdateName);
	}
}
