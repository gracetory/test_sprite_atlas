using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Chip : MonoBehaviour
{
	/**
	 * 初期化
	 *
	 * @access public
	 * @param string file_name
	 * @return void
	 */
	public void init(string file_name)
	{
		// 画像設定
		SpriteAtlas chip_atlas = Resources.Load<SpriteAtlas>("Sprites/Atlas/Chip");
		this.GetComponent<SpriteRenderer>().sprite = chip_atlas.GetSprite(file_name);

		// ソート順
		this.GetComponent<SpriteRenderer>().sortingOrder = 1;
	}
}
