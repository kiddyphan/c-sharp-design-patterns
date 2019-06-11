namespace TemplateMethod
{
    public abstract class BuildProduction
    {
        public void Build()
        {
            CommitCode();
            QAQC();
            Assemble();
            Deploy();
        }

        public abstract void CommitCode();
        public abstract void QAQC();
        public abstract void Assemble();
        public abstract void Deploy();
    }
}