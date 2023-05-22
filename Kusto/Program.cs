namespace Kusto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DevTask> myTasks = new()
            {
                new(2023, 05, 17, 1, "Хранилище глобальных данных"),
                new(2023, 05, 19, 1, "Новая внутренняя заявка на ТМЦ"),
                new(2023, 05, 19, 2, "Изменения в механизме проверки контрагентов СЕБ")
            };

            foreach (DevTask task in myTasks) Console.WriteLine(task);
        }
    }

    public class DevTask
    {
        DateTime TimeStamp { get; set; }

        Int32 TaskOrder { get; set; }

        String TaskName { get; set; }

        public DevTask(Int32 year, Int32 month, Int32 day, Int32 taskOrder, String taskName)
        {
            TimeStamp = new DateTime(year, month, day);
            TaskOrder = taskOrder;
            TaskName = taskName;
        }

        public override String ToString()
        {
            return $"| {TimeStamp:yy.MM.dd(ddd)} | {TimeStamp:yy}{TimeStamp.DayOfYear}{TaskOrder:00} | {TaskName}";
        }
    }
}