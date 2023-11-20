namespace Lab3;

internal class Inspector
{
    public ILoggable Loggable { private get; set; }

    public Inspector(ILoggable log)
    {
        Loggable = log;
    }

    public void MakeLog() => Loggable.Log();
}
