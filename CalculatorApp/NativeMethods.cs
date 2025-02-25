using System;
using System.Runtime.InteropServices;

public static class NativeMethods
{
    private const string DllName = "Calculator.dll";  // Ensure this matches your DLL name

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double add(double a, double b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double subtract(double a, double b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double multiply(double a, double b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double divide(double a, double b);
}
