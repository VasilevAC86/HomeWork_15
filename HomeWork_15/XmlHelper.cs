using HomeWork_15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class XmlHelper
    {
        public static Grid DeserializeXml(string xmlPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Grid));
            using (StreamReader reader = new StreamReader(xmlPath))
            {
                Grid grid = (Grid)serializer.Deserialize(reader);
                // Преобразование строк "True" и "False" в булевые значения
                foreach (var dockPanel in grid.DockPanels)
                {
                    if (dockPanel.LastChildFill == "True")
                        dockPanel.LastChildFill = "true";
                    else if (dockPanel.LastChildFill == "False")
                        dockPanel.LastChildFill = "false";
                }
                return grid;
            }
        }
        // После того, как мы что-нибудь поменяем в объектах, записываем в файл изменённые данные
        public static void SerializeXml(Grid grid, string xmlPath)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Grid));
            using (StreamWriter writer = new StreamWriter(xmlPath))
            {
                ser.Serialize(writer, grid);
            }
        }
        // Метод для добавления текст-блоков
        public static void AddTextBlock(Grid grid, string text, string dock, int fontSize, string horizontalAligment)
        {
            TextBlock newTextBlock = new TextBlock
            {
                Text = text,
                Dock = dock,
                FontSize = fontSize,
                HorizontalAlignment = horizontalAligment
            };
            DockPanel targetDocPanel = grid.DockPanels[0]; // Выбираем первый DockPanels для примера
            targetDocPanel.Elements.Add(newTextBlock);
        }
        public static void AddButton(Grid grid, string text, string doc, int gridColumn, int maxWidth, int minHeight, string background, string margin, string padding, string click)
        {
            Button newButton = new Button
            {
                Text = text,
                Dock = doc,
                GridColumn = gridColumn,
                MaxWidth = maxWidth,
                MinHeight = minHeight,
                Background = background,
                Margin = margin,
                Padding = padding,
                Click = click
            };
            DockPanel targetDockPanel = grid.DockPanels[0]; // Выбираем первый DockPanels для примера
            targetDockPanel.Elements.Add(newButton);
        }
        public static void AddElement<T>(T el, Grid grid) where T : class
        {
            // Выбор DockPanels, в который будет добавлен новый элемент            
            Console.Write($"\nВыберите номер DockPanel (от 1 до { (int)grid.DockPanels.Count })\nВаш выбор -> ");
            // Выбираем DockPanels, который указал пользователь
            DockPanel dock = grid.DockPanels[Exc_Int(Console.ReadLine(), (int)grid.DockPanels.Count) - 1]; 
            dock.Elements.Add(el); // Добавляем элемент в выбранный пользователем DockPanels
        }

        static int Exc_Int(string message, int max) // Метод обработки введённого пользователем номера DockPanels
        {
            int number = 0;
            // Если введённое значение можно преобразовать в int, то записываем его в number
            if (int.TryParse(message, out number)) { }
            if (!int.TryParse(message, out int value) || number < 1 || number > max) 
            {
                while (!int.TryParse(message, out value) || number < 1 || number > max)
                {
                    Console.Write($"Введённое некорректное значение! Введите номер DockPanel (от 1 до {max}) ещё один раз -> ");
                    message = Console.ReadLine();
                    if (int.TryParse(message, out number)) { }
                }
            }
            return number;
        }
    }
}