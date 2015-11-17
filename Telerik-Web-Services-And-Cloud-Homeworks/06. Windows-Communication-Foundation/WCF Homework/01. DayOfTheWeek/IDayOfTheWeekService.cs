namespace DayOfTheWeek
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IDayOfTheWeekService
    {
        [OperationContract]
        string DayOfWeekBulgarian(DateTime date);
    }
}
