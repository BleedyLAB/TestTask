using System.Collections.Generic;

namespace Task.Interfaces
{
    public interface IMath<T>
    {

        T GetMediana(List<T> list, int digits);

        List<T> GetModa(List<T> list, int digits);

        T GetMSD(List<T> list, int digits);

        T GetDispersion(List<T> list, int digits);

    }
}
