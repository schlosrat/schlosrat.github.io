// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABAutosave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class OABAutosave : KerbalMonoBehaviour
  {
    private bool _autosavesEnabled;
    private float _secondsBetweenSaves;
    private int _maxNumberAutosaves;
    private float _secondsSoFar;
    private ObjectAssemblyBuilderEvents _eventsBuilder;
    private ObjectAssemblyUIEvents _eventsUI;
    private OABSessionInformation _sessionInfo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI,
      OABSessionInformation sessionInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceTryAutoSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryCreateAutosave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteOldAutosaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteBackupWorkspace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABAutosave() => throw null;

    private class SaveInfo
    {
      public long time;
      public string relativePath;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SaveInfo() => throw null;
    }
  }
}
