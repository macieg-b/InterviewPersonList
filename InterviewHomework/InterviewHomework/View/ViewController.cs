using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterviewHomework.Model.Utilities;

namespace InterviewHomework.View
{
    public class ViewController
    {
        private Stack<View> _viewList;
        private PersonList _personList;

        public ViewController()
        {
            _personList = new PersonList();
            _viewList = new Stack<View>();
        }

        public void Run()
        {
            View nextView, mainView = new Main_View(_personList);
            ConsoleKeyInfo cKeyInfo;   
            _viewList.Push(mainView);
            do
            {
                _viewList.Peek().Launch();
                cKeyInfo = ReadIntKey(true);
                if(cKeyInfo.Key != ConsoleKey.Escape)
                {
                    nextView = _viewList.Peek().Control(int.Parse(cKeyInfo.KeyChar.ToString()));
                    if (nextView == null)
                    {
                        _viewList.Pop();
                    }
                    else if (nextView is View && nextView.GetType() != _viewList.Peek().GetType())
                    {
                        _viewList.Push(nextView);
                    }
                }        
            } while (cKeyInfo.Key != ConsoleKey.Escape);
        }

    }
}
