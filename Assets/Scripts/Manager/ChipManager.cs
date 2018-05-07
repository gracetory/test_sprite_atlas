using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipManager : MonoBehaviour {
	GameObject[] _chip = new GameObject[3];

	/**
	 * 初期化
	 *
	 * @access public
	 */
	public void init() {
		// 生成
		create();
	}

	/**
	 * チップ生成
	 *
	 * @access private
	 */
	private void create() {
		// プレハブ取得
		GameObject chip = (GameObject)Resources.Load("Prefabs/chip");

		// 座標
		Vector2 pos;

		// 各チップのインスタンス化
		pos.x = 0.0f;
		pos.y = 150.0f;
		_chip[0] = Instantiate(chip, pos, Quaternion.identity);
		_chip[0].GetComponent<Chip>().init("chip_1");
		pos.x = 0.0f;
		pos.y = 0.0f;
		_chip[1] = Instantiate(chip, pos, Quaternion.identity);
		_chip[1].GetComponent<Chip>().init("chip_2");
		pos.x = 0.0f;
		pos.y = -150.0f;
		_chip[2] = Instantiate(chip, pos, Quaternion.identity);
		_chip[2].GetComponent<Chip>().init("chip_3");
	}
}
