using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DP_T06
{
    public class MessagePublisher:Subject
    {
        private List<Observer> observers = new List<Observer>();
        int state = 1;
        public int State { get { return state; } set { value = state; } }
        public void Attach(Observer o)
        {
            observers.Add(o);
        }
        public void ChangeState(int val)
        {
            if (val != state)
            {
                State = val;
                NotifyUpdate(new Message("Subject state is changed"));
            }
        }
        public void Detach(Observer o)
        {
            observers.Remove(o);
        }
        public void NotifyUpdate(Message m)
        {
            foreach(Observer observer in observers)
            {
                observer.Update(m);
            }
        }
    }
}
