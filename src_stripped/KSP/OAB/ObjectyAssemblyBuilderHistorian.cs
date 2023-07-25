// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectyAssemblyBuilderHistorian
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectyAssemblyBuilderHistorian
  {
    private List<OABHistoricalSnapshot> _history;
    private ObjectAssemblyBuilderEvents _internalOABEvents;
    private ObjectAssemblyBuilderFileIO _fileIO;
    private ObjectAssemblyPartTracker _partTracker;
    private SubscriptionHandle _oabUnloadedHandle;
    private SubscriptionHandle _oabTakeHistorySnapshotHandle;
    private int _currentOperations;

    public int HistoryPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    public IReadOnlyCollection<OABHistoricalSnapshot> History
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectyAssemblyBuilderHistorian(
      ObjectAssemblyBuilderEvents events,
      ObjectAssemblyBuilderFileIO fileIO,
      ObjectAssemblyPartTracker partTracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABHistoricalSnapshot GenerateSnapshot(OABActionType type = OABActionType.None) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySnapshot(OABHistoricalSnapshot snapshot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OABTakeHistorySnapshot(MessageCenterMessage msgRaw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OABUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrackStateSnapshot(OABActionType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Undo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Redo() => throw null;
  }
}
