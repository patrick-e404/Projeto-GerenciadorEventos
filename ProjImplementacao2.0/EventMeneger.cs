using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImplementacao2._0
{
    public class EventManager
    {
        private static EventManager _instance;
        private List<IEvent> _events = new List<IEvent>();
        private List<IEventObserver> _observers = new List<IEventObserver>();

        private EventManager() { }

        public static EventManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventManager();
                }
                return _instance;
            }
        }
        public void AddEvent(IEvent ev)
        {
            _events.Add(ev);
            NotifyObservers();
        }
        public void RemoveEvent(IEvent ev)
        {
            _events.Remove(ev);
            NotifyObservers();
        }
        public List<IEvent> ListEvents()
        {
            return new List<IEvent>(_events);
        }
        public void RegistrarObserver(IEventObserver observer)
        {
            _observers.Add(observer);
        }
        public void SemRegistroObserver(IEventObserver observer)
        {
            _observers.Remove(observer);
        }
        public List<IEventObserver> ListObservers()
        {
            return new List<IEventObserver>(_observers);
        }
        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_events);
            }
        }
    }
}
