using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 圆 : MonoBehaviour {
		public Camera _观画摄像头, _曝光摄像头;
		public float _颜料深度 = 5.0f;
		public GameObject _颜料;
		public Transform _颜料空间;

		public float _时间权重 = 1.0f;
		public float _位移权重 = 1.0f;

		public float _涂颜料间隔 = 1.0f;


		// Use this for initialization
		void Start () {
			
		}

		// Update is called once per frame
		void Update () {
			bool bDrawing = 
				Input.GetMouseButton (0);
			Vector2 鼠标位置 = Input.mousePosition;

	
		}

		private void 根据鼠标位置赋以颜料 (Vector2 鼠标位置)
		{
			Ray 从鼠标向画布出发的射线 = _观画摄像头.ScreenPointToRay (鼠标位置);
			float 两个摄像头的深度差 = (_曝光摄像头.transform.position - 
				_观画摄像头.transform.position).z;
			Vector3 颜料位置 = 从鼠标向画布出发的射线.GetPoint (_颜料深度 + 两个摄像头的深度差);
			GameObject newPaintObj = Instantiate (_颜料) as GameObject;
			newPaintObj.transform.SetParent (_颜料空间);
			newPaintObj.transform.position = 颜料位置;

			
		}


}
