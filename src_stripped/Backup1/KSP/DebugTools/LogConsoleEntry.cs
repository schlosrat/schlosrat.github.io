// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.LogConsoleEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.DebugTools
{
  public class LogConsoleEntry : MonoBehaviour
  {
    public const float Height = 16f;
    private const int MaxLineLenght = 150;
    [SerializeField]
    private Color _errorColor;
    [SerializeField]
    private Color _warnColor;
    [SerializeField]
    private Color _infoColor;
    [SerializeField]
    private TMP_Text _messageText;
    [SerializeField]
    private TMP_Text _timeText;
    [SerializeField]
    private TMP_Text _typeText;
    private RectTransform _rectTransform;
    private LogEntry _entry;
    private LogConsoleWindow _logConsoleWindow;

    public float Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(LogConsoleWindow logConsoleWindow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(LogEntry entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string SubstringMessageText(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string TypeToString(LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color TypeToColor(LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogConsoleEntry() => throw null;
  }
}
