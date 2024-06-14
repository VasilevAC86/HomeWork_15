using System.Xml.Linq;

namespace HomeWork_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = "XML.xml";
            Grid grid = XmlHelper.DeserializeXml("XML.xml");
            XmlHelper xmlHelper = new XmlHelper();
            XmlHelper.AddButton(grid, "Обновить", "Новая", 15, 50, 5, "Чёрный", "08500", "5", "Да фиг знает что делает");
            XmlHelper.AddTextBlock(grid, "Новый текстовый блок", "Топ", 20, "Center");
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");
            
            // ------------- ДОМАШКА ------------------

            // Добавляем новый GroupBox в DockPanel
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nДобавление нового GroupBox в DockPanel");
            Console.ForegroundColor= ConsoleColor.White;
            XmlHelper.AddElement(new GroupBox
            {
                Background = "Цвет фона",
                Name = "Имя атрибута",
                BorderBrush = "Заливка границы",
                BorderThickness = "Толщина границы",
                StackPanel = new StackPanel
                {
                    TextBlocks = new List<TextBlock>
                    {
                        new TextBlock{ Dock = "Низ", FontSize = 46, HorizontalAlignment = "Центр", Text = "Список всего"},
                        new TextBlock{ Dock = "Середина", FontSize = 37, HorizontalAlignment = "Смещение вверх", Text = "Новое"},
                        new TextBlock{ Dock = "Верх", FontSize = 28, HorizontalAlignment = "Смещение вниз", Text = "Старое"}
                    }
                }
            }, grid);
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");
            // Добавляем новый ListBox в DockPanel
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nДобавление нового ListBox в DockPanel");
            Console.ForegroundColor = ConsoleColor.White;
            XmlHelper.AddElement(new ListBox
            {
                Background = "Серо-буро-малиновый",
                GridColumnSpan = 10,
                Name = "Лист того, что надо сделать",
                ItemTemplate = new ItemTemplate
                {
                   DataTemplate = new DataTemplate
                   {
                       StackPanel = new StackPanel
                       {
                           TextBlocks = new List<TextBlock>
                           {
                               new TextBlock{ Dock = "Право", FontSize = 46, HorizontalAlignment = "Центр", Text = "Список всего"},
                               new TextBlock{ Dock = "Середина", FontSize = 37, HorizontalAlignment = "Смещение вверх", Text = "Новое"},
                               new TextBlock{ Dock = "Лево", FontSize = 28, HorizontalAlignment = "Смещение вниз", Text = "Старое"}
                           }
                       }
                   }
                }
            }, grid);
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");
        }
    }
}