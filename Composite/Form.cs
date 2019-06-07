using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Form : IRenderable
    {
        private List<IRenderable> _elements = new List<IRenderable>();

        public string render()
        {
            var form = new StringBuilder("<form>\n");

            foreach (var element in _elements)
            {
                form.Append(element.render());
            }

            form.Append("</form>");

            return form.ToString();
        }

        public void addElement(IRenderable element)
        {
            this._elements.Add(element);
        }
    }
}