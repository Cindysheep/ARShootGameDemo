using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using System.Collections.Generic;
using UnityEngine.EventSystems;

public class ARButtonController : MonoBehaviour
{
    public void OnARButtonClicked()
    {
        Debug.Log("AR Button Clicked!");
    }

    // void Update()
    // {
    //     // 检测鼠标左键点击或手指触摸
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         PointerEventData eventData = new PointerEventData(EventSystem.current);
    //         eventData.position = Input.mousePosition;

    //         // 存储射线碰撞到的所有 UI 对象
    //         List<RaycastResult> results = new List<RaycastResult>();
    //         EventSystem.current.RaycastAll(eventData, results);

    //         foreach (RaycastResult result in results)
    //         {
    //             // 如果碰撞到的对象是我们的按钮
    //             if (result.gameObject.GetComponent<Button>() != null)
    //             {
    //                 Debug.Log("击中了按钮: " + result.gameObject.name);
    //                 result.gameObject.GetComponent<Button>().onClick.Invoke();
    //             }
    //         }
    //     }
    // }
}
