using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Sprite))]
public class ItemButton : MonoBehaviour {

	public int m_iItemId;
	public int m_iIndex;
	public Sprite m_sprImage;

	public void Initialize( int _iIndex , ItemManager _manager)
	{
		m_iIndex = _iIndex;
		m_sprImage = gameObject.GetComponent<Image>().sprite;

		gameObject.GetComponent<Button>().onClick.AddListener(() =>
		{
			_manager.OnPushed(this);
		});
	}

	public void Set( int _iItemId , Sprite _sprite)
	{
		m_iItemId = _iItemId;
		m_sprImage = _sprite;
	}
}
