using System;

namespace TemplateMethod
{
    public class WebBuildProduction : BuildProduction
    {
        public override void CommitCode()
        {
            Console.WriteLine("Web commit code");
        }

        public override void QAQC()
        {
            Console.WriteLine("Web QA/QC");
        }

        public override void Assemble()
        {
            Console.WriteLine("Web assemble");
        }

        public override void Deploy()
        {
            Console.WriteLine("Web deploy");
        }
    }
}