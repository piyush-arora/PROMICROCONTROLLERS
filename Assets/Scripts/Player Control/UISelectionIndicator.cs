using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UISelectionIndicator : MonoBehaviour {

	MouseManager mm;
	private static Vector3[] screenSpaceCorners;
	public Text text_info;


	// Use this for initialization
	void Start () {
		mm = GameObject.FindObjectOfType<MouseManager>();
	}

	// Update is called once per frame
	void Update () {
		if(mm.hoveredObject != null) 
		{
			text_info.text = mm.hoveredObject.GetComponent<My_Info> ().Name ;
			gameObject.GetComponent<CanvasGroup>().alpha = 1;
			gameObject.GetComponent<CanvasGroup>().interactable = true;
			Rect visualRect = RendererBoundsInScreenSpace(mm.hoveredObject.GetComponentsInChildren<Renderer>());
			RectTransform rt = GetComponent<RectTransform>();
			rt.position = new Vector2( visualRect.xMin, visualRect.yMin );
			rt.sizeDelta = new Vector2( visualRect.width, visualRect.height ); 
		}
		else 
		{
			gameObject.GetComponent<CanvasGroup>().alpha = 0;
			gameObject.GetComponent<CanvasGroup>().interactable = false;

		}
	}

	// It can find minimum and maximum bounds for one mesh renderer
	static Rect RendererBoundsInScreenSpace(Renderer[] rs) 
	{
		Rect my_rect;
		float[] min_x = new float[rs.Length];
		float[] min_y = new float[rs.Length];
		float[] max_x = new float[rs.Length];
		float[] max_y = new float[rs.Length];

		float minx;
		float miny;
		float maxx;
		float maxy;

		int i = 0;
		foreach (Renderer r in rs) {
		
			my_rect = RendererBoundsInScreenSpace (r);
			min_x[i] = my_rect.xMin;
			max_x [i] = my_rect.xMax;
			min_y [i] = my_rect.yMin;
			max_y [i] = my_rect.yMax;
			i++;
			
		}

		minx = min_x [0];
		miny = min_y [0];
		maxx = max_x [0];
		maxy = max_y [0];


		for (i = 1; i < rs.Length; i++) {
			if(min_x[i] < minx) {
				minx = min_x[i];
			}
			if(min_y[i] < miny) {
				miny = min_y[i];
			}
			if(max_x[i] > maxx) {
				maxx = max_x[i];
			}
			if(max_y[i] < maxy) {
				maxy = max_y[i];
			}
		}




		return Rect.MinMaxRect( minx, miny, maxx, maxy );

	}


	// It can find minimum and maximum bounds for one mesh renderer
	static Rect RendererBoundsInScreenSpace(Renderer r) 
	{
		

			// This is the space occupied by the object's visuals
			// in WORLD space.
			Bounds bigBounds = r.bounds;

			if(screenSpaceCorners == null)
				screenSpaceCorners = new Vector3[8];

			
		Camera theCamera = Camera.main;
			// For each of the 8 corners of our renderer's world space bounding box,
			// convert those corners into screen space.
			screenSpaceCorners[0] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x + bigBounds.extents.x, bigBounds.center.y + bigBounds.extents.y, bigBounds.center.z + bigBounds.extents.z ) );
			screenSpaceCorners[1] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x + bigBounds.extents.x, bigBounds.center.y + bigBounds.extents.y, bigBounds.center.z - bigBounds.extents.z ) );
			screenSpaceCorners[2] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x + bigBounds.extents.x, bigBounds.center.y - bigBounds.extents.y, bigBounds.center.z + bigBounds.extents.z ) );
			screenSpaceCorners[3] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x + bigBounds.extents.x, bigBounds.center.y - bigBounds.extents.y, bigBounds.center.z - bigBounds.extents.z ) );
			screenSpaceCorners[4] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x - bigBounds.extents.x, bigBounds.center.y + bigBounds.extents.y, bigBounds.center.z + bigBounds.extents.z ) );
			screenSpaceCorners[5] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x - bigBounds.extents.x, bigBounds.center.y + bigBounds.extents.y, bigBounds.center.z - bigBounds.extents.z ) );
			screenSpaceCorners[6] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x - bigBounds.extents.x, bigBounds.center.y - bigBounds.extents.y, bigBounds.center.z + bigBounds.extents.z ) );
			screenSpaceCorners[7] = theCamera.WorldToScreenPoint( new Vector3( bigBounds.center.x - bigBounds.extents.x, bigBounds.center.y - bigBounds.extents.y, bigBounds.center.z - bigBounds.extents.z ) );

			// Now find the min/max X & Y of these screen space corners.
			float min_x = screenSpaceCorners[0].x;
			float min_y = screenSpaceCorners[0].y;
			float max_x = screenSpaceCorners[0].x;
			float max_y = screenSpaceCorners[0].y;

			for (int i = 1; i < 8; i++) {
				if(screenSpaceCorners[i].x < min_x) {
					min_x = screenSpaceCorners[i].x;
				}
				if(screenSpaceCorners[i].y < min_y) {
					min_y = screenSpaceCorners[i].y;
				}
				if(screenSpaceCorners[i].x > max_x) {
					max_x = screenSpaceCorners[i].x;
				}
				if(screenSpaceCorners[i].y > max_y) {
					max_y = screenSpaceCorners[i].y;
				}
			}





			return Rect.MinMaxRect( min_x, min_y, max_x, max_y );

		}
}
