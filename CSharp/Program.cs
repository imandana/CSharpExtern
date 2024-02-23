using System;
using System.Runtime.InteropServices;

class Example
{
    [DllImport("DLLFORCSHARP.dll", CharSet = CharSet.Unicode)]
    public static extern int GetHasil();
    
	[DllImport("DLLFORCSHARP.dll", CharSet = CharSet.Unicode)]
    public static extern int SuperConductorExport(int a, int b);
        
	[DllImport("DLLFORCSHARP.dll", CharSet = CharSet.Unicode)]
    public static extern void AddToHasilExport(int a);
    
    static void Main()
    {
       Console.WriteLine( SuperConductorExport( 20, 30 ) );
       Console.WriteLine( GetHasil() );
	   
       AddToHasilExport( 999 );
	   Console.WriteLine( GetHasil() );
    }
}