// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.Buffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class Buffer : IDisposable
  {
    public const string NEW_LINE_STRING_PC = "\r\n";
    public const string NEW_LINE_STRING_MAC_UNIX = "\n";
    public static string NEW_LINE_STRING;
    public const bool DEFAULT_ERROR_AS_WARNING = false;
    public const int DEFAULT_ALLOC_INITIAL_SIZE = 1024;
    public const int DEFAULT_ALLOC_GROW_BLOCK_SIZE = 1024;
    public const int DEFAULT_ALLOC_MAX_SIZE = -1;
    public const int VAR_LENGTH_UINT64_CONTINUE_BIT_POSITION = 7;
    public const byte VAR_LENGTH_UINT64_CONTINUE_FLAG = 128;
    public const byte VAR_LENGTH_UINT64_DATA_BIT_MASK = 127;
    public static string[] gNewLineStringArray;
    public static byte[] gWhitespaceByteArray;
    private string _uniqueIdString;
    private Buffer.BufferType _bufferType;
    private int _allocInitialSize;
    private int _allocGrowBlockSize;
    private int _allocMaxSize;
    private byte[] _byteArray;
    private int _byteArrayAllocSize;
    private int _numBytes;
    private int _position;
    private ErrorFlag _errorFlag;
    private byte[] _tempReaderByteArray;
    private BufferCachePool _bufferCachePool;

    public string UniqueIdString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUniqueIdString(string uniqueIdString) => throw null;

    public ErrorFlag ErrorFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorFlag(string errorString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearErrorFlag() => throw null;

    public bool IsErrorFlagSet
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ErrorString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ErrorAsWarning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorAsWarning(bool errorAsWarning) => throw null;

    public BufferCachePool BufferCachePool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBufferCachePool(BufferCachePool bufferCachePool) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Buffer(byte[] byteArray, int byteArrayAllocSize, int numBytes = 0, int position = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Buffer(int allocInitialSize = 1024, int allocGrowBlockSize = 1024, int allocMaxSize = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Buffer(Buffer src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitStatic(byte[] byteArray, int byteArrayAllocSize, int numBytes = 0, int position = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitDynamic(int allocInitialSize = 1024, int allocGrowBlockSize = 1024, int allocMaxSize = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitDynamic(Buffer src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDynamic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsStatic() => throw null;

    public byte[] ByteArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ByteArrayAllocSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetByteArrayAsUTF8String() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetByteArrayAsUTF8String(int index, int numBytes) => throw null;

    public int NumBytes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumBytesYouBetterKnowWhatYouAreDoing(int numBytes) => throw null;

    public int Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEOB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumBytesLeftToRead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanRead() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanRead(int numBytes) => throw null;

    public int AllocInitialSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllocInitialSize(int allocInitialSize) => throw null;

    public int AllocGrowBlockSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllocGrowBlockSize(int allocGrowBlockSize) => throw null;

    public int AllocMaxSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllocMaxSize(int allocMaxSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty(bool freeBuffer = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(bool freeBuffer = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Truncate(int newSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Resize(int newSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SeekBegin(int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SeekCurrent(int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SeekEnd(int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Seek(Buffer.SeekPos seekPosIn, int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveBytes(int index, int numBytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PrivatePrepareWriteData(int numBytesToWrite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteData(
      byte[] byteArrayIn,
      int positionToReadFromIn,
      int numBytesToWriteIn,
      bool okToLogInfoIn = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteDataFromBuffer(
      Buffer bufferSrcIn,
      int positionToReadFromIn,
      int numBytesToWriteIn,
      bool okToLogInfoIn = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteByte(byte val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteSByte(sbyte val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteBool(bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteChar(char val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt16(short val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt16(ushort val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt32(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt32(uint val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt64(long val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt64(ulong val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteFloat(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteDouble(double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteByteArrayOrNull(byte[] byteArrayOrNull) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetVarLengthedUInt64NumBytesNeeded(ulong val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteVarLengthedUInt64(ulong val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteString(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteLine(string line = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteStringAndNull(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteIPEndPointOrNull(IPEndPoint ipEndPointOrNull) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WritePrintableLogBytes(
      string timeString,
      byte[] byteArray,
      int numBytes,
      int numColumns)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteDataAtIndex(
      int indexIn,
      byte[] byteArrayIn,
      int positionToReadFromIn,
      int numBytesToWriteIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteByteAtIndex(int indexIn, byte valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteSByteAtIndex(int indexIn, sbyte valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteBoolAtIndex(int indexIn, bool valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteCharAtIndex(int indexIn, char valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt16AtIndex(int indexIn, short valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt16AtIndex(int indexIn, ushort valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt32AtIndex(int indexIn, int valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt32AtIndex(int indexIn, uint valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteInt64AtIndex(int indexIn, long valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteUInt64AtIndex(int indexIn, ulong valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteFloatAtIndex(int indexIn, float valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteDoubleAtIndex(int indexIn, double valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteVarLengthedUInt64AtIndex(int indexIn, ulong valueIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteStringAtIndex(int indexIn, string stringIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteLineAtIndex(int indexIn, string stringIn = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteStringAndNullAtIndex(int indexIn, string stringIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteIPEndPointOrNullAtIndex(int indexIn, IPEndPoint ipEndPointOrNull) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PrivatePrepareReadData(int numBytesToReadIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SkipData(int numBytesToSkipIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadData(
      byte[] destByteArrayIn,
      int startingPositionInDestByteArrayIn,
      int numBytesToReadIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadData(Buffer bufferDestIn, int numBytesToReadIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte ReadByte() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public sbyte ReadSByte() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadBool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public char ReadChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public short ReadInt16() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ushort ReadUInt16() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ReadInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint ReadUInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long ReadInt64() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong ReadUInt64() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ReadFloat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ReadDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte[] ReadByteArrayOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong ReadVarLengthedUInt64() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadString(int numBytesIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindOffsetOfNextMatchingByte(byte byteIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindOffsetOfNextMatchingStringInArray(
      string[] stringArrayIn,
      ref string strFoundRefIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindOffsetOfNextMatchingByteInArray(byte[] byteArrayIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindOffsetOfNextNotMatchingByteInArray(byte[] byteArrayIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadStringAndNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadWhitespace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadNonWhitespace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPEndPoint ReadIPEndPointOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadDataFromIndex(
      int indexIn,
      byte[] destByteArrayIn,
      int startingPostionInDestByteArrayIn,
      int numBytesToReadIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte ReadByteFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public sbyte ReadSByteFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadBoolFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public char ReadCharFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public short ReadInt16FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ushort ReadUInt16FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ReadInt32FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint ReadUInt32FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long ReadInt64FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong ReadUInt64FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ReadFloatFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ReadDoubleFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong ReadVarLengthedUInt64FromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadStringFromIndex(int indexIn, int numBytesIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadStringAndNullFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadLineFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadWhitespaceFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ReadNonWhitespaceFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPEndPoint ReadIPEndPointOrNullFromIndex(int indexIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekData(
      byte[] destByteArrayIn,
      int startingPositionInDestByteArrayIn,
      int numBytesToReadIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekByte(ref byte returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekSByte(ref sbyte returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekBool(ref bool returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekChar(ref char returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt16(ref short returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt16(ref ushort returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt32(ref int returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt32(ref uint returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt64(ref long returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt64(ref ulong returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekFloat(ref float returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekDouble(ref double returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekString(int numBytesIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekStringAndNull(ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekLine(ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekWhitespace(ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekNonWhitespace(ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekDataFromIndex(
      int indexIn,
      byte[] destByteArrayIn,
      int startingPositionInDestByteArrayIn,
      int numBytesToReadIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekByteFromIndex(int indexIn, ref byte returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekSByteFromIndex(int indexIn, ref sbyte returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekBoolFromIndex(int indexIn, ref bool returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt16FromIndex(int indexIn, ref short returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt16FromIndex(int indexIn, ref ushort returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt32FromIndex(int indexIn, ref int returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt32FromIndex(int indexIn, ref uint returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekInt64FromIndex(int indexIn, ref long returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekUInt64FromIndex(int indexIn, ref ulong returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekFloatFromIndex(int indexIn, ref float returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekDoubleFromIndex(int indexIn, ref double returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekStringFromIndex(int indexIn, int numBytesIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekStringAndNullFromIndex(int indexIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekLineFromIndex(int indexIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekWhitespaceFromIndex(int indexIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeekNonWhitespaceFromIndex(int indexIn, ref string returnValueRefIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ConsumeDataFromFrontOfBuffer(int numBytesIn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SkipLiteralString(string stringIn, bool caseSensitiveIn = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchLiteralStringAtIndex(int indexIn, string stringIn, bool caseSensitiveIn = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SkipWhitespace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SkipNonWhitespace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Save(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Load(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Buffer() => throw null;

    public enum BufferType : byte
    {
      None,
      Static,
      Dynamic,
    }

    public enum SeekPos : byte
    {
      Begin,
      Current,
      End,
    }
  }
}
