using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager> {

	[SerializeField]
	private List<ItemButton> item_button_list = new List<ItemButton>();

	public ItemButton selecting;

	public override void Initialize()
	{
		selecting = null;
		base.Initialize();
		int iIndex = 0;
		foreach( ItemButton button in item_button_list)
		{
			button.Initialize(iIndex,this);
			iIndex += 1;
		}
	}

	public void OnPushed(ItemButton _button)
	{

	}




}
