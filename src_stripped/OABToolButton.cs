// Decompiled with JetBrains decompiler
// Type: OABToolButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OABToolButton : MonoBehaviour
{
  [SerializeField]
  public Color selectedColor;
  public Color unselectedColor;
  protected Image icon;
  protected bool selected;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSelected(bool b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABToolButton() => throw null;
}
