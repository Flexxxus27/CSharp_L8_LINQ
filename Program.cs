namespace CSharp_L8
{


    //Делигаты, события, анонимные методы, лямбды и LINQ
    internal class Program
    {


        //public static void HandleMes(string msg) { Console.WriteLine(msg); }
        static void Main(string[] args)
        {

            //Делигат - это массив ссылок на методы

            //Event n = new Event();
            //n.TakeMsg("asda");
            //n.onMsg += HandleMes("ddd");

            //LINQ

            List<Person> list = new List<Person>();

            var result = from x in list //query syntax
                         select x.Name;
            var result2 = from x in list
                          where x.Age > 18
                          select x;
            var result3 = from x in list
                          group x by x.Name;
            var result4 = list.Where(x => x.Age > 18).ToList();
            var result5 = list.Select(x => x.Age * 2).ToList();

            //OrderBy / OrderByDescending: Сортирует элементы в последовательности данных по возрастанию/убыванию.
            //GroupBy: Группирует элементы по определенному ключу.
            //Distinc: Удаляет дублирующиеся элементы из последовательности данных.
            //Reverse: Разворачивает порядок элементов в последовательности.
            //First / FirstOrDefault: Возвращает первый элемент из последовательности. First выбросит исключение, если последовательность пуста, а
            // FirstOrDefault вернет значение по умолчанию.


            List<Student> students = new List<Student>
            {
                new Student{Name = "Alice", Grades = new List<int> {5, 3, 4}},
                new Student{Name = "Bob", Grades = new List<int> {3, 3, 2}},
                new Student{Name = "Vasilii", Grades = new List<int> {4, 2, 5}}
            };

            var sorterList = students.OrderByDescending(student => student.Grades.Average());
            Console.WriteLine("Отсортированый список: ");
            foreach(var student in sorterList)
            {
                Console.WriteLine($"{student.Name}:{student.Grades.Average()}");
            }

            List<Order> orders = new List<Order>
            {
                new Order {OrderId = 1, Castomer = "Mike", Products = new List<OrderProduct> {
                    new OrderProduct {ProductName = "CPU", price = 4500},
                    new OrderProduct {ProductName = "GPU", price = 12350}
                }},
                new Order {OrderId = 2, Castomer ="Jhon",Products = new List<OrderProduct>
                {
                    new OrderProduct{ProductName = "Mause",price = 3400},
                    new OrderProduct{ProductName = "Keyboard",price= 450}
                } },
                new Order {OrderId = 3, Castomer ="Anna",Products = new List<OrderProduct>
                {
                    new OrderProduct{ProductName = "Fen",price = 5630},
                    new OrderProduct{ProductName = "Headphone",price= 7450}
                } }
            };

            var Osumin = orders.Select(x => new
            {
                OrderId = x.OrderId,
                Sum = x.Products.Sum(x => x.price)
            });
           foreach (var order in Osumin)
            {
                Console.WriteLine($"OrderId: {order.OrderId}, TotalSum: {order.Sum}");
            }
            var Osum = orders.Select(x => x.Products).Select(p => p.Sum(n => n.price));
            
            Console.WriteLine($"{Osum}");
            

        }
    }
}
