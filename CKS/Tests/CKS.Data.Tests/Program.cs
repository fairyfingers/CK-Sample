#if !NET461
using System;
using System.Reflection;
using NUnit.Common;
using NUnitLite;

namespace CKS.Data.Tests
{
    public class Program
    {
        public static int Main( string[] args )
        {
            return new AutoRun( typeof( Program ).GetTypeInfo().Assembly )
                .Execute( args, new ExtendedTextWrapper( Console.Out ), Console.In );
        }
    }
}
#endif
