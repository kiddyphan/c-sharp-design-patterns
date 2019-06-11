using System;

namespace TemplateMethod
{
    public class IosBuildProduction : BuildProduction
    {
        public override void CommitCode()
        {
            Console.WriteLine("Ios commit code");
        }

        public override void QAQC()
        {
            Console.WriteLine("Ios QA/QC");
        }

        public override void Assemble()
        {
            Console.WriteLine("Ios assemble");
        }

        public override void Deploy()
        {
            Console.WriteLine("Ios deploy");
        }
    }
}