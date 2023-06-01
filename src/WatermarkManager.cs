// Decompiled with JetBrains decompiler
// Type: WatermarkManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (CanvasGroup))]
internal class WatermarkManager : MonoBehaviour
{
  private const string _waterMarkedText = "KSP2 - ";
  private bool invertEveryOtherText;
  private CanvasGroup _canvasgroup;
  private TextMeshProUGUI[] _textMeshPros;
  private Vector3 _textScale;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DisplayBetaTesterWark() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string TryGetSteamUserName() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public WatermarkManager() => throw null;
}
