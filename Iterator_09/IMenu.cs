using System.Collections;

namespace Iterator_09
{
    public partial class MyWaitress
    {
        public interface IMenu
        {
            IEnumerator CreateIEnumerator();
        }
    }
}