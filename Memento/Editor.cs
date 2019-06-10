namespace Memento
{
    public class Editor
    {
        private string _content = string.Empty;
        private EditorMemento _memento;

        public Editor()
        {
            _memento = new EditorMemento(string.Empty);
        }

        public string Content => _content;

        public void Type(string content)
        {
            _content = string.Concat(_content + content);
        }

        public void Save()
        {
            _memento = new EditorMemento(_content);
        }

        public void Restore()
        {
            _content = _memento.Content;
        }
    }
}