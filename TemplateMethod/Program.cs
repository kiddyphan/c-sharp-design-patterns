using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var androidBuild = new AndroidBuildProduction();
            androidBuild.Build();

            var iosBuild = new IosBuildProduction();
            iosBuild.Build();
        }
    }
}