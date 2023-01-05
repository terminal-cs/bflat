namespace System.Runtime.InteropServices
{
  public static unsafe class NativeMemory
  {
    public static void* Alloc(nuint ElementCount, nuint ElementSize)
    {
      fixed (byte* P = stackalloc byte[ElementCount * ElementSize]
      {
        return (void*)P;
      }
    }
  }
}
