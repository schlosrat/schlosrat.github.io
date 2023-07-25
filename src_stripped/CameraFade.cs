// Decompiled with JetBrains decompiler
// Type: CameraFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraFade : MonoBehaviour
{
  private GUIStyle m_BackgroundStyle;
  private Texture2D m_FadeTexture;
  private Color m_CurrentScreenOverlayColor;
  private Color m_TargetScreenOverlayColor;
  private Color m_DeltaColor;
  private int m_FadeGUIDepth;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetScreenOverlayColor(Color newScreenOverlayColor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartFade(Color newScreenOverlayColor, float fadeDuration) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CameraFade() => throw null;
}
