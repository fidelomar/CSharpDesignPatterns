using System;

namespace DesignPatternsExplanation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;
            log.Save("og");
            log.Save("cg");
            log.Save("as");
            log.Save("dg");          
        }
    }
}
