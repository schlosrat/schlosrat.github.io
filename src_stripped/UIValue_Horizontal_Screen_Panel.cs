// Decompiled with JetBrains decompiler
// Type: UIValue_Horizontal_Screen_Panel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIValue_Horizontal_Screen_Panel : MonoBehaviour
{
  public List<GameObject> gameObjList;
  public Transform CurrentPos;
  public Transform RightPos;
  public Transform LeftPos;
  public Transform DeleteRightPos;
  public Transform DeleteLeftPos;
  public GameObject BG;
  public Image LeftArrow;
  public Sprite noArrow;
  public Sprite arrow;
  private int CurrentIndex;
  private int leftIndex;
  private int rightIndex;
  private int preLeftIndex;
  private int preRightIndex;
  private int frameCount;
  private int maxIndex;
  private float moveTime;
  private bool startEnd;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GetCurrentIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RightUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LeftUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DeleteObjUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SelectCorrectToggle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClosePanel(InputAction.CallbackContext obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIValue_Horizontal_Screen_Panel() => throw null;
}
