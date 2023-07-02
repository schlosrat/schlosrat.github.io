// Decompiled with JetBrains decompiler
// Type: ToolFramework
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ToolFramework : MonoBehaviour
{
  private string _title;
  private KeyCode _activationKey;
  private int _windowId;
  protected bool _showWindow;
  private Rect _windowRect;
  protected GUIStyle _windowStyle;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected ToolFramework(KeyCode activationKey, string title, Rect windowRect) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void _updateVisibility() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected string _getCurrentUserName() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void SetupWindowStyles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void _start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void drawWindow(int id) => throw null;
}
