namespace MIAC.Patterns.Creational
{
    /// <summary>
    /// Представляет реализацию паттерна "фабричный метод"
    /// <para>https://en.wikipedia.org/wiki/Factory_method_pattern</para>
    /// </summary>
    /// <typeparam name="T">Тип создаваемого объекта</typeparam>
    public interface ICreator<T> : ICanCreateObject<T> where T : class
    {

    }
}
