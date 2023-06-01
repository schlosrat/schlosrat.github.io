// Decompiled with JetBrains decompiler
// Type: LuaDebugPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LuaDebugPanel : MonoBehaviour
{
  private Rect titleBar;
  private Rect browserGroup;
  private Rect browserGroupTotal;
  private Rect _entry;
  private GUIStyle elementStyle;
  private GUIStyle toggleStyle;
  private Vector2 scrollPos;
  private string currentFolder;
  private string currentParameter;
  private Texture2D backGroundTex;
  private Texture2D buttonTex;
  private Texture2D buttonHoverTex;
  private Texture2D buttonDownTex;
  private string title;
  private int windowId;
  protected bool showWindow;
  private Rect windowRect;
  protected GUIStyle windowStyle;
  private IScriptEnvironment ScriptInjector;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ShowScriptBrowserWindow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HideScriptBrowserWindow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitLuaDirectoryAccess() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void drawWindow(int id) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool InjectLuaFile(string file) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ExectuteLua(string luaScript) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ChangeFolder(string localPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateFolderIfNeeded(string localPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D CreateUITexture(int texSize, Color col, bool border) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void SetupWindowStyles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetEntry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Rect IncrementEntry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LuaDebugPanel() => throw null;
}
