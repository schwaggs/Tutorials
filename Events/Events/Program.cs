using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate our class containing the event
            Event1 MainEvent = new Event1(true);

            // Create an event handler to fire whenever the event happens
            MainEvent.OnPropertyChanged += MainEvent_OnPropertyChanged;

            // Test the event hanlder by simultaneously changing the boolean
            for(int i = 0; i < 10; i ++)
            {
                MainEvent.Property = !MainEvent.Property;
            }

            Console.WriteLine("\n\nRunning Task\n\n");

            // Test a task
            Task.Run(() =>
            {
                for(int i = 0; i < 10; i ++)
                {
                    MainEvent.Property = !MainEvent.Property;
                }

                Console.WriteLine("Task Actually Finished");
            });

            // Notice how this displays before the task completes
            Console.WriteLine("Task Finished.");

            // Notice how this displays before the task completes
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i.ToString());
            }

            // Notice how this displays before the task completes
            Console.WriteLine("Press ENTER to quit");

            // Notice how this displays after the task completes
            Console.ReadLine();
        }

        // The event handler that was created to fire whenever the boolean changes
        private static void MainEvent_OnPropertyChanged(object sender, BoolChangedEventArgs e)
        {
            if(e.FalseToTrue)
            {
                Console.WriteLine("Changed to True!");
            }
            else if(e.TrueToFalse)
            {
                Console.WriteLine("Changed to False!");
            }
        }
    }

    public class Event1
    {
        // Event to trigger whenever the boolean changes
        public event EventHandler<BoolChangedEventArgs> OnPropertyChanged;

        // Internal boolean so we can keep track of previous states and determine if a change has occured with new information
        private bool _property { get; set; }

        // The public facing property accessed by other classes. Whenever this boolean is set i.e. Property = <new property> it will create event args and fire the event.
        // Then it will set the internal property to the new value
        public bool Property
        {
            get
            {
                return _property;
            }
            set
            {
                BoolChangedEventArgs args = new BoolChangedEventArgs
                {
                    FalseToTrue = false,
                    TrueToFalse = false
                };

                if (_property && !value)
                {
                    // Went from true to false
                    args.TrueToFalse = true;
                    OnPropertyChanged(this, args);

                }
                else if(!_property && value)
                {
                    // Went from false to true
                    args.FalseToTrue = true;
                    OnPropertyChanged(this, args);
                }

                _property = value;
            }
        }

        // Default constructor
        public Event1(bool InitialValue = false)
        {
            _property = InitialValue;
        }
    }

    // Class to hold our event arguments for access from the event handler
    public class BoolChangedEventArgs : EventArgs
    {
        public bool TrueToFalse { get; set; }
        public bool FalseToTrue { get; set; }
    }
}
