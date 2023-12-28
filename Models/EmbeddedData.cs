using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEmbeddedProduct.Models
{
    internal class EmbeddedData
    {
        internal readonly List<ExecutionProperties> executionProperties = new()
        {
            new ExecutionProperties("Открытые" , "MC", "Полосовые", 1, "С нормальными анкерами без усиления", 0),
            new ExecutionProperties("Открытые" , "MC", "Полосовые", 1, "С нормальными анкерами и анкерными пластинами", 1),
            new ExecutionProperties("Открытые" , "MC", "Полосовые", 1, "С нормальными анкерами с высаженными головками", 2),
            new ExecutionProperties("Открытые" , "MC", "Полосовые", 1, "С наклонным расположением анкеров", 3),
            new ExecutionProperties("Открытые" , "MC", "Полосовые", 1, "С изогнутыми анкерами", 4),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С нормальными анкерами без усиления", 0),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С нормальными анкерами и анкерными пластинами", 1),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С нормальными анкерами с высаженными головками", 2),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С наклонным расположением анкеров", 3),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С изогнутыми анкерами", 4),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "Со смешанным расположением анкеров", 5),
            new ExecutionProperties("Открытые" , "MC", "Точечные", 2, "С параллельным расположением анкеров", 6),

            new ExecutionProperties("Закрытые" , "MCс", "Полосовые", 1, "-", 0),
            new ExecutionProperties("Закрытые" , "MCс", "Точечные", 2, "-", 0),

            new ExecutionProperties("Обрамляющие" , "MCe", "Уголковые", 1, "Односторонние с анкерами без усиления", 0),
            new ExecutionProperties("Обрамляющие" , "MCe", "Уголковые", 1, "Односторонние с загнутыми анкерами", 1),
            new ExecutionProperties("Обрамляющие" , "MCe", "Уголковые", 1, "Односторонние с анкерами с высаженными головками", 2),
            new ExecutionProperties("Обрамляющие" , "MCe", "Уголковые", 1, "Двусторонние впритык", 3),
            new ExecutionProperties("Обрамляющие" , "MCe", "Уголковые", 1, "Двусторонние с соединительными стержнями", 4),
            new ExecutionProperties("Обрамляющие" , "MCe", "-", 2, "-", 0),
            new ExecutionProperties("Обрамляющие" , "MCe", "-", 3, "-", 0),

            new ExecutionProperties("Рамные" , "MCf", "С анкерами", 1, "С нормальными анкерами без усиления", 0),
            new ExecutionProperties("Рамные" , "MCf", "С анкерами", 1, "С загнутыми анкерами", 1),
            new ExecutionProperties("Рамные" , "MCf", "С анкерами", 1, "С анкерами с высаженными головками", 2),

            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "Без анкеров", 1),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С анкерами, приваренными к трубе", 2),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С анкерами, приваренными к фланцам", 3),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С ребрами из пластин", 4),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С ребрами из арматуры", 5),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С выпуском трубы, без анкеров", 6),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С выпуском трубы, с анкерами", 7),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С выпуском трубы, с ребрами из пластин", 8),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С переходом на другой диаметр", 9),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С прямоугольными фланцами, без анкеров", 10),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение с фланцами (с 1-м, 2-мя или 3-мя фланцами и с фланцами под углом", 1, "С прямоугольными фланцами, объединенные, без анкеров", 11),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение без фланцев", 2, "Без анкеров", 1),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение без фланцев", 2, "С анкерами", 2),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение без фланцев", 2, "С ребрами из пластин", 3),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение без фланцев", 2, "Изогнутые", 4),
            new ExecutionProperties("Трубные" , "T", "Круглое сечение без фланцев", 2, "Изогнутые, секционные", 5),
            new ExecutionProperties("Трубные" , "T", "Прямоугольное сечение с фланцами", 3, "С фланцами из уголков", 1),

        };

        //        internal readonly (string, string)[] typeCode =
        //{
        //            ("Открытые","MC" ),
        //            ("Закрытые","MCс" ),
        //            ("Обрамляющие","MCe" ),
        //            ("Рамные","MCf" ),
        //            ("Трубные","T" ),
        //        };

        //        internal readonly (string, string)[] subTypeCode =
        //{
        //            ("Полосовые","MC" ),
        //            ("Закрытые","MCс" ),
        //            ("Обрамляющие","MCe" ),
        //            ("Рамные","MCf" ),
        //            ("Трубные","T" ),
        //        };


        // Ключ 1-тип, 2-подтип, 3-исполнение, 4-ряд, 5-наличие отвертия.
        internal readonly Dictionary<string, string> parametricsDrawing = new()
        {
            {"00000", "\\img\\01.01.01.10.00.0 БД.jpg" },
            {"00010", "\\img\\01.01.01.20.00.0 БД.jpg" },
            {"00011", "\\img\\01.01.01.20.00.1 БД.jpg" },
            {"00020", "\\img\\01.01.01.30.00.0 БД.jpg" },
            {"00021", "\\img\\01.01.01.30.00.1 БД.jpg" },
            {"00100", "\\img\\01.01.02.10.00.0 БД.jpg" },
            {"00110", "\\img\\01.01.02.20.00.0 БД.jpg" },
            {"00111", "\\img\\01.01.02.20.00.1 БД.jpg" },
            {"00120", "\\img\\01.01.02.30.00.0 БД.jpg" },
            {"00121", "\\img\\01.01.02.30.00.1 БД.jpg" },
            {"00200", "\\img\\01.01.03.10.00.0 БД.jpg" },
            {"00210", "\\img\\01.01.03.20.00.0 БД.jpg" },
            {"00211", "\\img\\01.01.03.20.00.1 БД.jpg" },
            {"00220", "\\img\\01.01.03.30.00.0 БД.jpg" },
            {"00221", "\\img\\01.01.03.30.00.1 БД.jpg" }
        };


        internal readonly (string, string)[] widthParam =
        {
            ("100","10" ),
            ("150","15" ),
            ("200","20" ),
            ("250","25" ),
            ("300","30" ),
            ("350","35" ),
            ("400","40" ),
            ("450","45" ),
            ("500","50" ),
            ("550","55" ),
            ("600","60" ),
        };


        internal readonly (string, string)[] thicknessParam =
        {
            ("8","8" ),
            ("10","10" ),
            ("12","12" ),
            ("14","14" ),
            ("16","16" ),
            ("18","18" ),
            ("20","20" ),
            ("25","25" ),
        };

        internal readonly (string, string)[] materialOPParam =
        {
            ("С245 ГОСТ 27772-88","С245" ),
            ("Ст3сп5 ГОСТ 14637-89","Ст3сп5" ),
            ("08Х18Н10Т ГОСТ 7350-77","08Х18" ),
            ("12Х18Н10Т ГОСТ 7350-77","12Х18" ),
            ("S355J2 MSZ EN 10025-2:2020","S355J2" ),
            ("1,4301 EN 10088-2:2005","1_4301" ),
            ("1,4541 EN 10088-2:2005","1_4541" ),
        };

        internal readonly (string, string)[] holeParam =
        {
            ("Нет","0" ),
            ("Да","1" ),
        };

        internal readonly (string, string)[] rowParam =
        {
            ("1","1" ),
            ("2","2" ),
            ("3","3" ),
        };

        internal readonly (string, string)[] stepParam =
        {
            ("100","100" ),
            ("200","200" ),
        };

        internal readonly (string, string)[] betweenParam =
        {
            ("50","50" ),
            ("100","100" ),
            ("120","120" ),
            ("140","140" ),
            ("150","150" ),
            ("165","165" ),
            ("175","175" ),
            ("180","180" ),
            ("200","200" ),
            ("230","230" ),
            ("250","250" ),
            ("280","280" ),
            ("300","300" ),
        };

        internal readonly (string, string)[] anchorLengthParam =
        {
            ("80","8" ),
            ("130","13" ),
            ("150","15" ),
            ("200","20" ),
            ("230","23" ),
            ("250","25" ),
            ("270","27" ),
            ("300","30" ),
            ("320","32" ),
            ("330","33" ),
            ("350","35" ),
            ("380","38" ),
            ("400","40" ),
            ("450","45" ),
            ("480","48" ),
            ("500","50" ),
            ("550","55" ),
            ("600","60" ),
            ("650","65" ),
            ("700","70" ),
            ("750","75" ),
            ("800","80" ),
            ("850","85" ),
            ("900","90" ),
            ("950","95" ),
        };

        internal readonly (string, string)[] anchorDiameterParam =
        {
            ("8","8" ),
            ("10","10" ),
            ("12","12" ),
            ("16","16" ),
            ("20","20" ),
            ("22","22" ),
            ("25","25" ),
        };

        internal readonly (string, string)[] classArmParam =
        {
            ("А500СЕУ ГОСТ 34028-2016","А500СЕУ" ),
            ("A500СНУ ГОСТ 34028-2016","А500СНУ" ),
            ("B500C MSZ EN 10027-1:2017","B500C" ),
        };

        internal readonly (string, string)[] pairOPParam =
        {
            ("Т1-Мф ГОСТ 14098-2014","Т1_Мф" ),
            ("Т2-Рф ГОСТ 14098-2014","Т2_РФ" ),
            ("Т12-Рз ГОСТ 14098-2014","Т12_Рз" ),
            ("111 EN ISO 17660-1:2006","111" ),
            ("135 EN ISO 17660-1:2006","135" ),
        };


        internal readonly List<LoadEmbedded> loadEmbeddeds = new()
        {
            new LoadEmbedded("Стена","Вертикально","3 силы, 2 момента"),
            new LoadEmbedded("Стена","Вертикально","Равные 3 силы, равные 2 момента"),
            new LoadEmbedded("Стена","Вертикально","1 сила, 1 момент"),
            new LoadEmbedded("Стена","Горизонтально","3 силы, 2 момента"),
            new LoadEmbedded("Стена","Горизонтально","Равные 3 силы, равные 2 момента"),
            new LoadEmbedded("Стена","Горизонтально","1 сила, 1 момент"),

            new LoadEmbedded("Перекрытие","Под перекрытием","3 силы, 2 момента"),
            new LoadEmbedded("Перекрытие","Под перекрытием","Равные 3 силы, равные 2 момента"),

            new LoadEmbedded("Перекрытие","На перекрытие","3 силы, 2 момента"),
            new LoadEmbedded("Перекрытие","На перекрытие","Равные 3 силы, равные 2 момента"),
        };

        internal readonly string[] scheme =
            { "1","2","3"};

    }

    internal class LoadEmbedded
    {
        public string TypeZBKName { get; set; }
        public string Orientation { get; set; }
        public string Variable { get; set; }

        public LoadEmbedded(string typeZBKName, string orientation, string variable)
        {
            TypeZBKName = typeZBKName;
            Orientation = orientation;
            Variable = variable;
        }
    }

    internal class ExecutionProperties
    {
        internal string TypeName { get; set; }
        internal string TypeCode { get; set; }
        internal string SubTypeName { get; set; }
        internal int SubTypeCode { get; set; }
        internal string ExecutionName { get; set; }
        internal int ExecutionCode { get; set; }

        public ExecutionProperties(string typeName, string typeCode, string subTypeName, int subTypeCode
            , string executionName, int executionCode)
        {
            TypeName = typeName;
            TypeCode = typeCode;
            SubTypeName = subTypeName;
            SubTypeCode = subTypeCode;
            ExecutionName = executionName;
            ExecutionCode = executionCode;
        }
    }

}
