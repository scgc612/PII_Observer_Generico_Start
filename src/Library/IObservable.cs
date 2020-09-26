namespace Observer
{
    /// <summary>
    /// En la interfaz se determina un tipo generico que T que recibirá por parametro en sus operaciones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservable<T>
    {
        void Subscribe(IObserver<T> observer);

        void Unsubscribe(IObserver<T> observer);

        
    }
}