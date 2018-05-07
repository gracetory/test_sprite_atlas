using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	/**
	 * エントリポイント
	 *
	 * @access private
	 */
	void Start () {
		// ゲームオブジェクトのコンポーネントを取得
		ChipManager chip_manager = GetComponent<ChipManager>();	// チップ管理

		// チップ初期化
		chip_manager.init();
	}
	
	/**
	 * 更新
	 *
	 * @access private
	 */
	void Update () {
	}
}
