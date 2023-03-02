using System;
namespace behavioraldesignpatterns.Example1
{
	public class ActualContainer : IContainer
	{
	    string[] names = { "Rahul", "Ravi", "Ashi", "Bhagat" };

        private class ActualIterator : IIterator
        {
            private int index = 0;

            string[] names;

            public ActualIterator(string[] names)
            {
                this.names = names;
            }

            public object? GetNext()
            {
                if (index == names.Length)
                {
                    return null;
                }

                var data = names[index];
                index += 1;
                return data;
            }

            public bool HasNext()
            {
                if (index == names.Length)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public IIterator GetIterator()
        {
            return new ActualIterator(names);
        }
    }
}

