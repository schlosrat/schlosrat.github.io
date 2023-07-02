// Decompiled with JetBrains decompiler
// Type: UIChangeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
