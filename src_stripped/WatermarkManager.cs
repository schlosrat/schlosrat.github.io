// Decompiled with JetBrains decompiler
// Type: WatermarkManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
