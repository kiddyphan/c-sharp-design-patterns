using System;

namespace TemplateMethod
{
    public class AndroidBuildProduction : BuildProduction
    {
        public override void CommitCode()
        {
            Console.WriteLine("Android commit code");
        }

        public override void QAQC()
        {
            Console.WriteLine("Android QA/QC");
        }

        public override void Assemble()
        {
            Console.WriteLine("Android assemble");
        }

        public override void Deploy()
        {
            Console.WriteLine("Android deploy");
        }
    }
}