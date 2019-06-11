namespace State
{
    public class Editor
    {
        private IState _state;

        public Editor()
        {
            _state = new NormalCaseState();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Type(string text)
        {
            _state.Write(text);
        }
    }
}