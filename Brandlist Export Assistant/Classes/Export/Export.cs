using Brandlist_Export_Assistant.Forms;

namespace Brandlist_Export_Assistant.Classes
{
    public abstract class Export
    {
        protected readonly ExcelProcessor _brandlist;

        public Export(ExcelProcessor _brandlist)
        {
            this._brandlist = _brandlist;
        }

        public abstract string Dir { get;}

        public abstract void _Export(MainUI ui);

    }
}
