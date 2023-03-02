namespace behavioraldesignpatterns.Example1;

public interface IIterator
{
	public abstract bool HasNext();

	public abstract object? GetNext();
}

