using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Purple5Test();
            //a.Purple5Test();
            //a.Purple10Test();
        }
        void Purple1Test()
        {
            Purple_1.Participant participant1 = new Purple_1.Participant("Алевтина", "Петрова");
            Purple_1.Participant participant2 = new Purple_1.Participant("Иван", "Козлов");
            Purple_1.Participant participant3 = new Purple_1.Participant("Татьяна", "Пономарева");
            Purple_1.Participant participant4 = new Purple_1.Participant("Ярослав", "Степанов");
            Purple_1.Participant participant5 = new Purple_1.Participant("Марк", "Иванов");
            Purple_1.Participant participant6 = new Purple_1.Participant("Татьяна", "Тихонова");
            Purple_1.Participant participant7 = new Purple_1.Participant("Дарья", "Свиридова");
            Purple_1.Participant participant8 = new Purple_1.Participant("Александр", "Кристиан");
            Purple_1.Participant participant9 = new Purple_1.Participant("Анастасия", "Полевая");
            Purple_1.Participant participant10 = new Purple_1.Participant("Артем", "Иванов");


            participant1.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant2.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant3.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant4.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant5.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant6.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant7.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant8.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant9.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });
            participant10.SetCriterias(new double[] { 3.01, 3.16, 2.94, 3.10 });

            // Participant 1
            participant1.Jump(new int[] { 5, 6, 2, 1, 5, 4, 6 });
            participant1.Jump(new int[] { 2, 2, 2, 6, 5, 4, 6 });
            participant1.Jump(new int[] { 1, 3, 5, 5, 2, 6, 6 });
            participant1.Jump(new int[] { 4, 6, 6, 3, 5, 3, 4 });

            // Participant 2
            participant2.Jump(new int[] { 1, 6, 4, 1, 2, 3, 2 });
            participant2.Jump(new int[] { 6, 3, 5, 1, 6, 3, 6 });
            participant2.Jump(new int[] { 3, 2, 2, 5, 3, 5, 5 });
            participant2.Jump(new int[] { 5, 6, 5, 6, 1, 1, 4 });

            // Participant 3
            participant3.Jump(new int[] { 3, 5, 4, 5, 3, 6, 1 });
            participant3.Jump(new int[] { 2, 1, 4, 6, 1, 6, 6 });
            participant3.Jump(new int[] { 1, 1, 6, 6, 6, 1, 1 });
            participant3.Jump(new int[] { 2, 2, 6, 1, 5, 3, 3 });

            // Participant 4
            participant4.Jump(new int[] { 3, 1, 3, 6, 4, 2, 5 });
            participant4.Jump(new int[] { 6, 5, 5, 2, 4, 1, 1 });
            participant4.Jump(new int[] { 3, 3, 4, 4, 3, 6, 4 });
            participant4.Jump(new int[] { 6, 6, 5, 3, 6, 3, 3 });

            // Participant 5
            participant5.Jump(new int[] { 6, 6, 1, 3, 1, 1, 6 });
            participant5.Jump(new int[] { 6, 2, 6, 4, 3, 4, 3 });
            participant5.Jump(new int[] { 6, 2, 3, 4, 3, 1, 3 });
            participant5.Jump(new int[] { 2, 1, 3, 6, 1, 3, 5 });

            // Participant 6
            participant6.Jump(new int[] { 6, 1, 4, 1, 3, 1, 1 });
            participant6.Jump(new int[] { 6, 5, 5, 3, 2, 3, 3 });
            participant6.Jump(new int[] { 5, 1, 1, 3, 4, 3, 1 });
            participant6.Jump(new int[] { 6, 1, 5, 5, 3, 3, 6 });

            // Participant 7
            participant7.Jump(new int[] { 6, 5, 1, 1, 6, 6, 2 });
            participant7.Jump(new int[] { 5, 6, 3, 2, 4, 6, 4 });
            participant7.Jump(new int[] { 4, 5, 4, 1, 2, 1, 3 });
            participant7.Jump(new int[] { 3, 4, 5, 6, 5, 1, 6 });

            // Participant 8
            participant8.Jump(new int[] { 3, 3, 4, 4, 4, 2, 2 });
            participant8.Jump(new int[] { 3, 2, 2, 4, 3, 1, 3 });
            participant8.Jump(new int[] { 5, 3, 6, 4, 2, 1, 2 });
            participant8.Jump(new int[] { 6, 1, 3, 1, 6, 2, 6 });
            // Participant 9
            participant9.Jump(new int[] { 4, 6, 3, 2, 3, 6, 2 });
            participant9.Jump(new int[] { 5, 6, 6, 4, 3, 6, 6 });
            participant9.Jump(new int[] { 3, 1, 2, 1, 1, 6, 4 });
            participant9.Jump(new int[] { 5, 3, 6, 6, 2, 3, 4 });

            // Participant 10
            participant10.Jump(new int[] { 3, 6, 3, 4, 6, 2, 1 });
            participant10.Jump(new int[] { 3, 1, 2, 5, 3, 2, 4 });
            participant10.Jump(new int[] { 5, 3, 6, 2, 5, 6, 4 });
            participant10.Jump(new int[] { 5, 3, 1, 3, 4, 3, 6 });

            Purple_1.Participant[] participants = new Purple_1.Participant[] { participant1, participant2, participant3, participant4, participant5, participant6, participant7, participant8, participant9, participant10 };

            Purple_1.Participant.Sort(participants);

            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Name} {participant.Surname}: {participant.TotalScore}");
            }
        }
        void Purple2Test()
        {
            Purple_2.Participant participant1 = new Purple_2.Participant("Оксана", "Сидорова");
            Purple_2.Participant participant2 = new Purple_2.Participant("Полина", "Полевая");
            Purple_2.Participant participant3 = new Purple_2.Participant("Дмитрий", "Полевой");
            Purple_2.Participant participant4 = new Purple_2.Participant("Евгения", "Распутина");
            Purple_2.Participant participant5 = new Purple_2.Participant("Савелий", "Луговой");
            Purple_2.Participant participant6 = new Purple_2.Participant("Евгения", "Павлова");
            Purple_2.Participant participant7 = new Purple_2.Participant("Егор", "Свиридов");
            Purple_2.Participant participant8 = new Purple_2.Participant("Степан", "Свиридов");
            Purple_2.Participant participant9 = new Purple_2.Participant("Анастасия", "Козлова");
            Purple_2.Participant participant10 = new Purple_2.Participant("Светлана", "Свиридова");


            participant1.Jump(135, new int[] { 15, 1, 3, 9, 15 });
            participant2.Jump(191, new int[] { 19, 14, 9, 11, 4 });
            participant3.Jump(147, new int[] { 20, 9, 1, 13, 6 });
            participant4.Jump(115, new int[] { 5, 20, 17, 9, 16 });
            participant5.Jump(112, new int[] { 19, 8, 1, 6, 17 });
            participant6.Jump(151, new int[] { 16, 12, 5, 20, 4 });
            participant7.Jump(186, new int[] { 5, 20, 3, 19, 18 });
            participant8.Jump(166, new int[] { 16, 12, 5, 4, 15 });
            participant9.Jump(112, new int[] { 7, 4, 19, 11, 12 });
            participant10.Jump(197, new int[] { 14, 3, 6, 17, 1 });

            Purple_2.Participant[] participants = new Purple_2.Participant[] { participant1, participant2, participant3, participant4, participant5, participant6, participant7, participant8, participant9, participant10 };
            Purple_2.Participant.Sort(participants);

            // Выводим результаты
            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Name} {participant.Surname}: {participant.Result}");
            }
        }
        void Purple3Test()
        {
            Purple_3.Participant participant1 = new Purple_3.Participant("Виктор", "Полевой");
            Purple_3.Participant participant2 = new Purple_3.Participant("Алиса", "Козлова");
            Purple_3.Participant participant3 = new Purple_3.Participant("Ярослав", "Зайцев");
            Purple_3.Participant participant4 = new Purple_3.Participant("Савелий", "Кристиан");
            Purple_3.Participant participant5 = new Purple_3.Participant("Алиса", "Козлова");
            Purple_3.Participant participant6 = new Purple_3.Participant("Алиса", "Луговая");
            Purple_3.Participant participant7 = new Purple_3.Participant("Александр", "Петров");
            Purple_3.Participant participant8 = new Purple_3.Participant("Мария", "Смирнова");
            Purple_3.Participant participant9 = new Purple_3.Participant("Полина", "Сидорова");
            Purple_3.Participant participant10 = new Purple_3.Participant("Татьяна", "Сидорова");
            participant1.Evaluate(5.93);
            participant1.Evaluate(5.44);
            participant1.Evaluate(1.20);
            participant1.Evaluate(0.28);
            participant1.Evaluate(1.57);
            participant1.Evaluate(1.86);
            participant1.Evaluate(5.89);

            participant2.Evaluate(1.68);
            participant2.Evaluate(3.79);
            participant2.Evaluate(3.62);
            participant2.Evaluate(2.76);
            participant2.Evaluate(4.47);
            participant2.Evaluate(4.26);
            participant2.Evaluate(5.79);

            participant3.Evaluate(2.93);
            participant3.Evaluate(3.10);
            participant3.Evaluate(5.46);
            participant3.Evaluate(4.88);
            participant3.Evaluate(3.99);
            participant3.Evaluate(4.79);
            participant3.Evaluate(5.56);

            participant4.Evaluate(4.20);
            participant4.Evaluate(4.69);
            participant4.Evaluate(3.90);
            participant4.Evaluate(1.67);
            participant4.Evaluate(1.13);
            participant4.Evaluate(5.66);
            participant4.Evaluate(5.40);

            participant5.Evaluate(3.27);
            participant5.Evaluate(2.43);
            participant5.Evaluate(0.90);
            participant5.Evaluate(5.61);
            participant5.Evaluate(3.12);
            participant5.Evaluate(3.76);
            participant5.Evaluate(3.73);

            participant6.Evaluate(0.75);
            participant6.Evaluate(1.13);
            participant6.Evaluate(5.43);
            participant6.Evaluate(2.07);
            participant6.Evaluate(2.68);
            participant6.Evaluate(0.83);
            participant6.Evaluate(3.68);

            participant7.Evaluate(3.78);
            participant7.Evaluate(3.42);
            participant7.Evaluate(3.84);
            participant7.Evaluate(2.19);
            participant7.Evaluate(1.20);
            participant7.Evaluate(2.51);
            participant7.Evaluate(3.51);

            participant8.Evaluate(1.35);
            participant8.Evaluate(3.40);
            participant8.Evaluate(1.85);
            participant8.Evaluate(2.02);
            participant8.Evaluate(2.78);
            participant8.Evaluate(3.23);
            participant8.Evaluate(3.03);

            participant9.Evaluate(0.55);
            participant9.Evaluate(5.93);
            participant9.Evaluate(0.75);
            participant9.Evaluate(5.15);
            participant9.Evaluate(4.35);
            participant9.Evaluate(1.51);
            participant9.Evaluate(2.77);

            participant10.Evaluate(3.86);
            participant10.Evaluate(0.19);
            participant10.Evaluate(0.46);
            participant10.Evaluate(5.14);
            participant10.Evaluate(5.37);
            participant10.Evaluate(0.94);
            participant10.Evaluate(0.84);

            Purple_3.Participant[] participants = new Purple_3.Participant[] { participant1, participant2, participant3, participant4, participant5, participant6, participant7, participant8, participant9, participant10 };
            Purple_3.Participant.SetPlaces(participants);
            Purple_3.Participant.Sort(participants);
            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Name} {participant.Surname}: {participant.Score} {participant.Places[0]}");
            }

           
        }
        void Purple4Test()
        {
            Purple_4.Sportsman sportsman1 = new Purple_4.Sportsman("Полина", "Луговая");
            Purple_4.Sportsman sportsman2 = new Purple_4.Sportsman("Савелий", "Козлов");
            Purple_4.Sportsman sportsman3 = new Purple_4.Sportsman("Екатерина", "Жаркова");
            Purple_4.Sportsman sportsman4 = new Purple_4.Sportsman("Дмитрий", "Иванов");
            Purple_4.Sportsman sportsman5 = new Purple_4.Sportsman("Дмитрий", "Полевой");
            Purple_4.Sportsman sportsman6 = new Purple_4.Sportsman("Савелий", "Петров");
            Purple_4.Sportsman sportsman7 = new Purple_4.Sportsman("Евгения", "Распутина");
            Purple_4.Sportsman sportsman8 = new Purple_4.Sportsman("Екатерина", "Луговая");
            Purple_4.Sportsman sportsman9 = new Purple_4.Sportsman("Мария", "Иванова");
            Purple_4.Sportsman sportsman10 = new Purple_4.Sportsman("Степан", "Павлов");
            Purple_4.Sportsman sportsman11 = new Purple_4.Sportsman("Ольга", "Павлова");
            Purple_4.Sportsman sportsman12 = new Purple_4.Sportsman("Ольга", "Полевая");
            Purple_4.Sportsman sportsman13 = new Purple_4.Sportsman("Дарья", "Павлова");
            Purple_4.Sportsman sportsman14 = new Purple_4.Sportsman("Дарья", "Свиридова");
            Purple_4.Sportsman sportsman15 = new Purple_4.Sportsman("Евгения", "Свиридова");
            sportsman1.Run(422.64);
            sportsman2.Run(142.05);
            sportsman3.Run(185.23);
            sportsman4.Run(294.32);
            sportsman5.Run(79.26);
            sportsman6.Run(230.63);
            sportsman7.Run(35.16);
            sportsman8.Run(376.12);
            sportsman9.Run(279.20);
            sportsman10.Run(292.38);
            sportsman11.Run(467.60);
            sportsman12.Run(473.82);
            sportsman13.Run(290.14);
            sportsman14.Run(368.60);
            sportsman15.Run(212.67);
            
            Purple_4.Group group1 = new Purple_4.Group("Gum");
            Purple_4.Sportsman[] g = new Purple_4.Sportsman[] { sportsman1, sportsman2, sportsman3, sportsman4, sportsman5, sportsman6, sportsman7, sportsman8, sportsman9, sportsman10, sportsman11, sportsman12, sportsman13, sportsman14, sportsman15 };
            group1.Add(g);
            Purple_4.Sportsman sportsman16 = new Purple_4.Sportsman("Анастасия", "Жаркова");
            Purple_4.Sportsman sportsman17 = new Purple_4.Sportsman("Александр", "Павлов");
            Purple_4.Sportsman sportsman18 = new Purple_4.Sportsman("Степан", "Свиридов");
            Purple_4.Sportsman sportsman19 = new Purple_4.Sportsman("Игорь", "Сидоров");
            Purple_4.Sportsman sportsman20 = new Purple_4.Sportsman("Евгения", "Сидорова");
            Purple_4.Sportsman sportsman21 = new Purple_4.Sportsman("Мария", "Сидорова");
            Purple_4.Sportsman sportsman22 = new Purple_4.Sportsman("Лев", "Петров");
            Purple_4.Sportsman sportsman23 = new Purple_4.Sportsman("Савелий", "Козлов");
            Purple_4.Sportsman sportsman24 = new Purple_4.Sportsman("Егор", "Свиридов");
            Purple_4.Sportsman sportsman25 = new Purple_4.Sportsman("Оксана", "Жаркова");
            Purple_4.Sportsman sportsman26 = new Purple_4.Sportsman("Светлана", "Петрова");
            Purple_4.Sportsman sportsman27 = new Purple_4.Sportsman("Полина", "Петрова");
            Purple_4.Sportsman sportsman28 = new Purple_4.Sportsman("Екатерина", "Павлова");
            Purple_4.Sportsman sportsman29 = new Purple_4.Sportsman("Юлия", "Полевая");
            Purple_4.Sportsman sportsman30 = new Purple_4.Sportsman("Евгения", "Павлова");
            sportsman16.Run(112.49);
            sportsman17.Run(472.11);
            sportsman18.Run(213.92);
            sportsman19.Run(102.13);
            sportsman20.Run(263.21);
            sportsman21.Run(350.75);
            sportsman22.Run(248.68);
            sportsman23.Run(325.28);
            sportsman24.Run(300.00);
            sportsman25.Run(252.16);
            sportsman26.Run(402.20);
            sportsman27.Run(397.33);
            sportsman28.Run(384.94);
            sportsman29.Run(8.09);
            sportsman30.Run(480.52);
            Purple_4.Group group2 = new Purple_4.Group("Gum");
            Purple_4.Sportsman[] g2 = new Purple_4.Sportsman[] { sportsman16, sportsman17, sportsman18, sportsman19, sportsman20, sportsman21, sportsman22, sportsman23, sportsman24, sportsman25, sportsman26, sportsman27, sportsman28, sportsman29, sportsman30};
            group2.Add(g2);
            group1.Sort();
            group2.Sort();
            Purple_4.Group group3 = new Purple_4.Group("Ur");
            group3 = Purple_4.Group.Merge(group1, group2);
            foreach (var men in group3.Sportsmen)
            {
                Console.WriteLine($"{men.Name} {men.Surname}: {men.Time}");
            }
        }
        void Purple5Test()
        {
            Purple_5.Research r = new Purple_5.Research("tetr");
            r.Add(new string[] { "Макака", "-", "Манга" });
            r.Add(new string[] { "Тануки", "Проницательность", "Манга" });
            r.Add(new string[] { "Тануки", "Скромность", "Кимоно" });
            r.Add(new string[] { "Кошка", "Внимательность", "Суши" });
            r.Add(new string[] { "Сима_энага", "Дружелюбность", "Кимоно" });
            r.Add(new string[] { "Макака", "Внимательность", "Самурай" });
            r.Add(new string[] { "Панда", "Проницательность", "Манга" });
            r.Add(new string[] { "Сима_энага", "Проницательность", "Суши" });
            r.Add(new string[] { "Серау", "Внимательность", "Сакура" });
            r.Add(new string[] { "Панда", "-", "Кимоно" });
            r.Add(new string[] { "Сима_энага", "Дружелюбность", "Сакура" });
            r.Add(new string[] { "Кошка", "Внимательность", "Кимоно" });
            r.Add(new string[] { "Панда", "-", "Сакура" });
            r.Add(new string[] { "Кошка", "Уважительность", "Фудзияма" });
            r.Add(new string[] { "Панда", "Целеустремленность", "Аниме" });
            r.Add(new string[] { "Серау", "Дружелюбность", "-" });
            r.Add(new string[] { "Панда", "-", "Манга" });
            r.Add(new string[] { "Сима_энага", "Скромность", "Фудзияма" });
            r.Add(new string[] { "Панда", "Проницательность", "Самурай" });
            r.Add(new string[] { "Кошка", "Внимательность", "Сакура" });
            string[] animal = r.GetTopResponses(1);
            for (int i = 0; i < animal.Length; i++)
                Console.WriteLine($"{animal[i]}");
            Console.WriteLine();
            string[] character = r.GetTopResponses(2);
            for (int i = 0; i < animal.Length; i++)
                Console.WriteLine($"{character[i]}");
            Console.WriteLine();
            string[] concept = r.GetTopResponses(3);
            for (int i = 0; i < animal.Length; i++)
                Console.WriteLine($"{concept[i]} ");
            Console.WriteLine();
        }
        
     }
}
