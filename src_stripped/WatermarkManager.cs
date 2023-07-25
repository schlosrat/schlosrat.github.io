// Decompiled with JetBrains decompiler
// Type: WatermarkManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
