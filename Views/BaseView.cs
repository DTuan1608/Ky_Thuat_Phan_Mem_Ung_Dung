using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceConfig.Views
{
    public class BaseView<TControl, TModel> : System.Mvc.IView
        where TControl : System.Windows.UIElement, new()
    {
        public TControl MainContent { get; set; }
        public TModel Model { get; set; }
        public object Content => MainContent;

        protected virtual void RenderCore() { }
        public void Render(object model)
        {
            Model = (TModel)model;
            MainContent = new TControl();

            RenderCore();
        }
    }
}
