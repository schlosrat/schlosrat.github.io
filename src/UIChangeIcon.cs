// Decompiled with JetBrains decompiler
// Type: UIChangeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIChangeIcon : KerbalMonoBehaviour
{
  [SerializeField]
  private Sprite _pcSprite;
  [SerializeField]
  private Sprite _gamecoreSprite;
  [SerializeField]
  private Sprite _psSprite;
  [SerializeField]
  private Image _currentImage;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIChangeIcon() => throw null;
}
