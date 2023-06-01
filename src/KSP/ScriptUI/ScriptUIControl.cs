// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.ScriptUI
{
  public abstract class ScriptUIControl
  {
    public int controlID;
    protected ScriptUIWindow ownerWnd;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int RegisterWnd(ScriptUIWindow wnd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsValidWnd(ScriptUIWindow wnd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ValidateControl<T>(ScriptUIWindow wnd, int controlID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract string ToLuaVariable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Draw(ScriptUIMgr context, ScriptUIStyles guiStyles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ScriptUIControl() => throw null;
  }
}
