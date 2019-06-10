namespace Memento
{
    public class EditorMemento
    {
        private string _content;

        public EditorMemento(string content)
        {
            _content = content;
        }

        public string Content => _content;
    }
}