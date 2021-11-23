using UnityEngine;
using UnityEngine.UI;

public class ScrollingBackground : MonoBehaviour
{
  [SerializeField] private RawImage _img;
  [SerializeField] public float _x, _y;

  void Update()
  {
    Scroll();
  }
  void Scroll()
  {
    _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
  }
}
